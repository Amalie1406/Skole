namespace H1GPDag1_oveOpgave
{
    class MyConverter
    {
        public static void Main(string[] args)
        {

            double fahrenheit;

            double celsius = 36;
            Console.WriteLine("Konverter celsius til fahrenheit");
            Console.WriteLine("Indtast din temperatur:");
            celsius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Celsius: " + celsius);

            fahrenheit = (celsius * 9) / 5 + 32;
            //Console.WriteLine("Fahrenheit: " + fahrenheit);
            Console.WriteLine($"Fahrenheit: " + fahrenheit);

            Console.Read();

        }
    }
}


