using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Core
{
    public class UI_FontUtil
    {
        
        public static Font SetMainFont()
        {
            PrivateFontCollection font = new PrivateFontCollection();
            var str = AppDomain.CurrentDomain.BaseDirectory + "PF-Mdi.ttf";
            font.AddFontFile(str);//字体的路径及名字
            Font myFont = new Font(font.Families[0].Name, 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(134)));
            return myFont;
        }

        public static Font SetControlFont()
        {
            PrivateFontCollection font = new PrivateFontCollection();
            var str = AppDomain.CurrentDomain.BaseDirectory + "PF-Mdi.ttf";
            font.AddFontFile(str);//字体的路径及名字
            Font myFont = new Font(font.Families[0].Name, 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(134)));
            //pfc.AddFontFile(path);
            //System.Drawing.Font fn = new Font(pfc.Families[0], 12, FontStyle.Regular);//Fixedsys Excelsior 3.01
            return myFont;
        }

        public static Font SetChildControlsFont()
        {
            PrivateFontCollection font = new PrivateFontCollection();
            var str = AppDomain.CurrentDomain.BaseDirectory + "PF-Mdi.ttf";
            font.AddFontFile(str);//字体的路径及名字
            Font myFont = new Font(font.Families[0].Name, 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            //pfc.AddFontFile(path);
            //System.Drawing.Font fn = new Font(pfc.Families[0], 12, FontStyle.Regular);//Fixedsys Excelsior 3.01
            return myFont;
        }

        public static Font SetRoomControlsFont()
        {
            PrivateFontCollection font = new PrivateFontCollection();
            var str = AppDomain.CurrentDomain.BaseDirectory + "PF-Mdi.ttf";
            font.AddFontFile(str);//字体的路径及名字
            Font myFont = new Font(font.Families[0].Name, 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            //pfc.AddFontFile(path);
            //System.Drawing.Font fn = new Font(pfc.Families[0], 12, FontStyle.Regular);//Fixedsys Excelsior 3.01
            return myFont;
        }
    }
}
