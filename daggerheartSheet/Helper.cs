using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daggerheartSheet
{
    internal class Helper
    {
        public static Color GetContrastColor(Color backgroundColor)
        {
            double brightness =
                (0.299 * backgroundColor.R) +
                (0.587 * backgroundColor.G) +
                (0.114 * backgroundColor.B);

            return brightness > 128 ? Color.Black : Color.White;
        }
    }
}
