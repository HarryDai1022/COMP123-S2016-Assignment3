using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_S2016_Assignment3
{
    class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        //Private instance variable
        private bool _oxygen;

        //Constructor
        public TerrestrialPlanet(bool oxygen, string name, double diameter, double mass)
            : base(name, diameter, mass)
        {
            this._oxygen = oxygen; //local variable
        }

        public bool Habitable()
        {
            return this._oxygen;
        }

        public bool HasMoons()
        {
            return (MoonCount > 0) ? true : false;
        }
    }
}