using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mars_rover.Models
{
    interface IPlateau
    {
        int Min_Width { get; set; }

        int Min_Height { get; set; }

        int Width { get; set; }

        int Height { get; set; }
    }

    public class Plateau : IPlateau
    {
        #region Field 

        private int _Min_Width;
        private int _Min_Height;
        private int _Width;
        private int _Height;

        #endregion

        #region Constructor

        public Plateau(int Width, int Height)
        {
            _Min_Width = 0;
            _Min_Height = 0;
            _Width = Width;
            _Height = Height;
        }

        #endregion

        #region Property         

        public int Min_Width
        {
            get { return _Min_Width; }

            set { _Min_Width = value; }
        }

        public int Min_Height
        {
            get { return _Min_Height; }

            set { _Min_Height = value; }
        }

        public int Width
        {
            get { return _Width; }

            set { _Width = value; }
        }

        public int Height
        {
            get { return _Height; }

            set { _Height = value; }
        }

        #endregion        
    }
}
