using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_prencipal
{
    


class Program
    {
        static void Main(string[] args)
        {
            // NumberConverter converter = new NumberConverter();
            //var converter = new NumberConverter(new Logger(), new Reader());
            var converter = new NumberConverter(new TextFileLogger(), new Reader(),new Logger());

            converter.Convert();
            Console.ReadLine();

            /* Ellipse ellipse = new Ellipse();

            ellipse.SetRx(5);
            ellipse.SetRy(4);

            AreaCalculator calculator = new AreaCalculator();

            // Rx = 5; Ry = 4; Rx != Ry => IsCircle = False
            double result = calculator.Area(ellipse);

            ellipse.SetRx(5);
            ellipse.SetRy(5);

            // Rx = Ry = 5 => IsCircle = True
            result = calculator.Area(ellipse); */

        }
    }

 }




