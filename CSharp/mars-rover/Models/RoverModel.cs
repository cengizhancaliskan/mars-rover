using mars_rover.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mars_rover.Models
{
    interface IRover
    {
        Plateau plateau { get; set; }

        Position position { get; set; }

        DirectionEnum heading { get; set; }
    }

    public class Rover : IRover
    {
        #region Field 

        private Plateau _plateau;
        private Position _position;
        private DirectionEnum _heading = MainRoverClass.heading;

        #endregion

        #region Constructor

        public Rover(Plateau plateau, Position position, DirectionEnum heading)
        {
            _plateau = plateau;
            _position = position;
            _heading = heading;
        }

        #endregion

        #region Property

        public Plateau plateau
        {
            get { return _plateau; }

            set { _plateau = value; }
        }

        public Position position
        {
            get { return _position; }

            set { _position = value; }
        }

        public DirectionEnum heading
        {
            get { return _heading; }

            set { _heading = value; }
        }

        #endregion
    }
}
