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
    class Greeting
    {
        public static void TheOpener()
        {
            Kapitalverwalter Kasse01 = new Kapitalverwalter ();
            decimal meinkapital = Kasse01.startkapital;
            int meinehallen = 0;



            Console.WriteLine("Hello World!");
            Console.WriteLine("Gute Idee, erst einmal guten Tage zu sagen, nicht wahr, Teresa?");
            Console.WriteLine("Zur Lagerung des Gases benötigen wir ein paar Lagerhallen.");
            Console.WriteLine("Wieviele Hallen sollen wir bauen?" + Environment.NewLine +
            "Wir haben derzeit noch ein Kapital von {0} EUR." + Environment.NewLine + 
            "Der wahnsinnige Professor hat uns ein Grundstück von 10.000 ha geschenkt." + Environment.NewLine + 
            "Hallenpreis ist derzeit 20,- EUR pro Kubikmeter. Bankzinsen sind derzeit 7 %." + Environment.NewLine + 
            "Mach was draus. Wieviele Hallen und wie groß ist jede?", meinkapital);

            
        }
    }
}
