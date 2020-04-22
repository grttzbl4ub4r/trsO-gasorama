/*
Copyright 2020 Carsten Lange

    This file is part of Gasfabrik Teresa O.

    Gasfabrik Teresa O is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Gasfabrik Teresa O is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Gasfabrik Teresa O.  If not, see <http://www.gnu.org/licenses/>.

Licence:
GNU General Public License 3.0 or later
*/

namespace GasFabrikTeresaO
{
    public class Itsagas
    {
        private string name;
        public string GetName()
        {return this.name;}
        public void SetName(string name)
        {this.name=name;}
        private string farbe;
        public string GetFarbe()
        {return this.farbe;}
        public void SetFarbe(string farbe)
        {this.farbe=farbe;}
        private double menge;
        public double GetMenge()
        {return this.menge;}
        public void SetMenge(double menge)
        {this.menge=menge;}
        public Itsagas(string name, string farbe, double menge)
        {
            this.name=name;
            this.farbe=farbe;
            this.menge=menge;
        }

    }
}