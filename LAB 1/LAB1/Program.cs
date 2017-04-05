using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            float dist;
            float hours, mins, secs;
            float timeH, timeM, timeS, mps, kph, mph;

            Console.WriteLine("Please enter a distance (in meters)");
            dist = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Please enter the time Taken:");

            Console.WriteLine("Hours: ");
            hours = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Minutes: ");
            mins = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Seconds: ");
            secs = Convert.ToSingle(Console.ReadLine());

            

            timeH = hours + (mins / 60) + ((secs / 60) / 60);
            timeM = (hours * 60) + mins + (secs / 60);
            timeS = (hours * 360) + (mins * 60) + secs;

            //Console.WriteLine(dist);
            //Console.WriteLine(hours + ":" + mins + ":" + secs);
            //
            //Console.WriteLine(timeH + " Hours, OR " + timeM + " Minutes, OR " + timeS + " Seconds");

            mps = dist / timeS;

            kph = (dist / 1000) / timeH;

            mph = (dist / 1609) / timeH;

            Console.WriteLine("Meters per Second: " + mps);
            Console.WriteLine("Kilometers per Hour: " + kph);
            Console.WriteLine("Miles per Hour: " + mph);

            Console.ReadKey();

        }
    }
}
