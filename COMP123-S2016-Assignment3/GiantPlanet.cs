using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_S2016_Assignment3
{
    class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        //Private instance variable
        private string _type;

        //Constructor
        public GiantPlanet(string type, string name, double diameter, double mass)
            : base(name, diameter, mass)
        {
            this._type = type;
        }

        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasRings()
        {
            return (RingCount > 0) ? true : false;
        }
    }
}