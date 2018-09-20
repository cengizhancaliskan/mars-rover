using mars_rover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mars_rover
{   
    public static class MainPlateauClass
    {
        public static bool IsMoveAvailable(this Plateau plateau, Position position)
        {
            return plateau.Min_Width <= position.x && position.x <= plateau.Width && plateau.Min_Height <= position.y && position.y <= plateau.Height;
        }
    }
}
