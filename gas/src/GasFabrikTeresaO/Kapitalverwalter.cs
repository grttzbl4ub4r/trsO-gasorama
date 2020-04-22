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
    class Kapitalverwalter
    {
        private decimal _startkapital = 2500000.00M;
        private decimal _kapital;

        public decimal startkapital
        {
            get => _startkapital;
        }
        public decimal kapital
        {
            get => _kapital;
            set => _kapital = value;
        }
    }
}