namespace WindowsFormsApp6.Core
{
    public class Settings
    {
        public int BmpTextWidth { get; set; } = 90;
        public int BmpTextHeight { get; set; } = 15;

        public int TextMarginRight { get; set; } = 25;
        public int TextMarginTop { get; set; } = 81;

        public string PathToSrcImg { get; set; } = "1_0.png";
        public string PathToTemplateImg { get; set; } = "template2.png";

        public int MarginRightToFirstCard { get; set; } = 525;
        public int DistanceBetweenCards { get; set; } = 65;
    }
}
