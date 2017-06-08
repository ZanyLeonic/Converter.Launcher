using System.Windows.Forms;
using System.Drawing;

namespace Converter.Launcher.Lib
{
    public class MenuStripRenderer : ToolStripProfessionalRenderer
    {
        public MenuStripRenderer() : base(new MenuStripColours()) { }
    }
    public class MenuStripColours : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get
            {
                return base.MenuItemSelected;
            }
        }
    }
}
