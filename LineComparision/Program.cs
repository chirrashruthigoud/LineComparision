namespace LineComparision
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Linecomparision cal = new Linecomparision(20,30,50,60);
            double length_One=cal.Calculate();
            Linecomparision cal_Two = new Linecomparision(20, 30, 50, 60);
            double length_Two = cal.Calculate();
            if (length_One.Equals(length_Two))
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not Equal");

            if (length_One.CompareTo(length_Two) == 0)
                Console.WriteLine("Both lines are equal");
            else if (length_One.CompareTo(length_Two) > 0)
                Console.WriteLine("Line one is greater than line two ");
            else
                Console.WriteLine("line two is greater than line one");
            Console.ReadKey();
        }
    }
}