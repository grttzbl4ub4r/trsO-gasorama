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
    class Program
    {
        static void Main(string[] args)
        {
            GasFabrikTeresaO.Greeting.TheOpener();

            string weiter = "y";
            for (int i=0;weiter == "y";i++)
            {
                Console.WriteLine("Name der neuen Halle?");
                string lname=Convert.ToString(Console.ReadLine());
                Console.WriteLine("Größe der Halle (Volumen in m³");
                double lvol=Convert.ToDouble(Console.ReadLine());
                int lkey = i;
                //Lagerhallenbau lkey= new Lagerhallenbau(lname,lvol);

            
            }
            Console.ReadKey();
        }
    }
}
