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
            Console.ReadKey();
        }
    }
}