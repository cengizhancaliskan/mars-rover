using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mars_rover.Models
{
    interface IPosition
    {
        int x { get; set; }

        int y { get; set; }
    }

    public class Position : IPosition
    {
        #region Field 

        private int _x;
        private int _y;

        #endregion

        #region Constructor

        public Position(int x, int y)
        {
            _x = x;
            _y = y;
        }

        #endregion

        #region Property

        public int x
        {
            get { return _x; }

            set { _x = value; }
        }

        public int y
        {
            get { return _y; }

            set { _y = value; }
        }

        #endregion
    }
}
