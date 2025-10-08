using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public class MyColors : ProfessionalColorTable
    {
        public override Color MenuItemPressedGradientBegin
        {
            get { return Color.FromArgb(41, 128, 185); }
        }
        public override Color MenuItemPressedGradientEnd
        {
            get { return Color.FromArgb(41, 128, 185); }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get { return Color.FromArgb(41, 128, 185); }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return Color.FromArgb(41, 128, 185); }
        }
    }
}
