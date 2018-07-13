using AForge.Imaging;
using System.Drawing.Imaging;
using System.Drawing;
using Tesseract;

using WindowsFormsApp6.Core;
using System.Windows.Forms;
using System;
using AForge.Imaging.Filters;
using AForge;

namespace Card_Info.Core
{
    public class CardsImage
    {
        private static Settings sets = new Settings();

        private static Bitmap sourceImage = new Bitmap(sets.PathToSrcImg);
        private static Bitmap template = new Bitmap(sets.PathToTemplateImg);

        private static ExhaustiveTemplateMatching tm = null;
        private static TemplateMatch[] matchings = null;
        private static BitmapData data = null;

        private static TesseractEngine tesseng = null;
        public static Rectangle match { get; set; }

        private int[] mask = new int[9];

        public CardsImage()
        {
            InitSettings();
            sourceImage = new Bitmap(sets.PathToSrcImg);
            FindShape();
        }

        public void InitSettings()
        {
            if (sets != null)
            {
                sets = new Settings();
            }
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                sets.PathToSrcImg = ofd.FileName;
            }
        }

        public void FindShape()
        {
            sourceImage = ConvertBitmapTo24bpp(sourceImage);
            template = ConvertBitmapTo24bpp(template);

            tm = new ExhaustiveTemplateMatching(0.875f);

            matchings = tm.ProcessImage(sourceImage, template);

            data = sourceImage.LockBits(
                new Rectangle(0, 0, sourceImage.Width, sourceImage.Height),
                ImageLockMode.ReadWrite, sourceImage.PixelFormat);

            foreach (var m in matchings)
            {
                Drawing.Rectangle(data, m.Rectangle, Color.White);
            }

            sourceImage.UnlockBits(data);

            if (matchings.Length > 0)
            {
                match = matchings[0].Rectangle;
            }



        }

        public int FindPosition()
        {
            double pos = (((double)match.X - (double)sets.MarginRightToFirstCard) / (double)sets.DistanceBetweenCards) + 1;
            return (int)Math.Round(pos);
        }

        public Bitmap FindTextBitmap()
        {
            Bitmap textBmp = new Bitmap(sets.BmpTextWidth, sets.BmpTextHeight);
            textBmp = sourceImage.Clone(new Rectangle(match.X + sets.TextMarginRight, match.Y + sets.TextMarginTop, sets.BmpTextWidth, sets.BmpTextHeight), PixelFormat.Format24bppRgb);
            Grayscale gs = new Grayscale(0.2125, 0.7154, 0.0721);
            SISThreshold th = new SISThreshold();
            BinaryErosion3x3 bs = new BinaryErosion3x3();

            ColorFiltering cf = new ColorFiltering();
            cf.Red = new IntRange(90, 160);
            cf.Green = new IntRange(55, 110);
            cf.Blue = new IntRange(15, 85);
            cf.ApplyInPlace(textBmp);

            //for (int i = 0; i < textBmp.Width; i++)
            //{
            //    for (int j = 0; j < textBmp.Height; j++)
            //    {
            //        if (((textBmp.GetPixel(i, j).R > 95) && (textBmp.GetPixel(i, j).R < 155)) && ((textBmp.GetPixel(i, j).G > 60) && (textBmp.GetPixel(i, j).G > 105)) && ((textBmp.GetPixel(i, j).B > 20 && (textBmp.GetPixel(i, j).B < 80))))
            //        {
            //            textBmp.SetPixel(i, j, Color.Black);
            //        }
            //        else
            //        {
            //            textBmp.SetPixel(i, j, Color.White);
            //        }
            //    }
            //}

            BilateralSmoothing bss = new BilateralSmoothing();
            bss.KernelSize = 7;
            bss.SpatialFactor = 5;
            bss.ColorFactor = 30;
            bss.ColorPower = 0.5;



            bss.ApplyInPlace(textBmp); 

            textBmp = gs.Apply(textBmp);
            th.ApplyInPlace(textBmp);
            //bs.ApplyInPlace(textBmp);
            //erose.ApplyInPlace(textBmp);


            return textBmp;
        }

        public string FindCardName()
        {
            Bitmap textBitmap = FindTextBitmap();

            var textImg = PixConverter.ToPix(textBitmap);

            tesseng = new TesseractEngine("./tessdata", "eng", EngineMode.TesseractAndCube);

            Page card = tesseng.Process(textImg);
            if (card.GetText() == "")
            {
                MessageBox.Show("Cannot Find Card");
            }
            return card.GetText();
        }

        private Bitmap ConvertBitmapTo24bpp(Bitmap orig)
        {
            Bitmap pic;
            pic = new Bitmap(orig.Width, orig.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            using (Graphics gr = Graphics.FromImage(pic))
            {
                gr.DrawImage(orig, new Rectangle(0, 0, pic.Width, pic.Height));
            }

            orig.Dispose();

            return pic;
        }

        public Bitmap GetSource()
        {
            return sourceImage;
        }

        public Bitmap GetTemplate()
        {
            return template;
        }

        public bool IsFind()
        {
            return matchings.Length > 0;
        }




    }
}
