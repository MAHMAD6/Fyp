using System.Drawing;

namespace Project_Pulse.DL
{
    internal class Essentials
    {
        public Color BgColor { get; } = ColorTranslator.FromHtml("#323437");
        public Color MainColor { get; } = ColorTranslator.FromHtml("#e2b714");
        public Color CaretColor { get; } = ColorTranslator.FromHtml("#e2b714");
        public Color SubColor { get; } = ColorTranslator.FromHtml("#646669");
        public Color SubAltColor { get; } = ColorTranslator.FromHtml("#2c2e31");
        public Color TextColor { get; } = ColorTranslator.FromHtml("#d1d0c5");
        public Color ErrorColor { get; } = ColorTranslator.FromHtml("#ca4754");
        public Color ErrorExtraColor { get; } = ColorTranslator.FromHtml("#7e2a33");
        public Color ColorfulErrorColor { get; } = ColorTranslator.FromHtml("#ca4754");
        public Color ColorfulErrorExtraColor { get; } = ColorTranslator.FromHtml("#7e2a33");

    }
}
