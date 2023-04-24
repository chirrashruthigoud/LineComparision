using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    public class Linecomparision
    {
        int x_One, x_Three,y_One, y_Two;
        //constructor
        public Linecomparision(int x_One,int x_Two,int y_One,int y_Two)
        { 
            this.x_One = x_One;
            x_Three = x_Two;
            this.y_One = y_One;
            this.y_Two = y_Two;
        
        }
        //method
       /* public void Calculate()
        {
            double length=Math.Sqrt(Math.Pow((x_Three-x_One),2)+Math.Pow((y_Two-y_One),2));
            Console.WriteLine($"Length of line : { length}");

        }*/
       //return type
        public double Calculate()
        {
            double length = Math.Sqrt(Math.Pow((x_Three - x_One), 2) + Math.Pow((y_Two - y_One), 2));
            Console.WriteLine($"Length of line : {length}");
            return length;
        }
    }
}
