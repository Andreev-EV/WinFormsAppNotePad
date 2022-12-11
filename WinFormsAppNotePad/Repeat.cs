using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppNotePad
{
    internal class Repeat
    {
        public string Text { get; set; }
        public Font fontColor { get; set; }
        public Color backColor { get; set; }
        public int curPos { get; set; }

        public Repeat(string text, Font fontColor, Color backColor, int curPos)
        {
            this.Text = text;
            this.fontColor = fontColor;
            this.backColor = backColor;
            this.curPos = curPos;
        }
    }
}
