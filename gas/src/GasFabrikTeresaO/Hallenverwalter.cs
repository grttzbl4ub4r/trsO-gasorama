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

using System;

namespace GasFabrikTeresaO

{
    class Hallenverwalter
    {
        private static int _anzahlhallen = 0;
        private static float _gesamtvolumen = 0;
        private int _hallennummer;
        private string _hallenname;
        private float _hallenlaenge;
        private float _hallenbreite;
        private float _hallehoehe;
        private float _hallenvolumen;
        private string _hallengasart;


        public int anzahlhallen
        {
            get => _anzahlhallen;
        }
        public float gesamtvolumen
        {
            get => _gesamtvolumen;
        }
        
    }
}