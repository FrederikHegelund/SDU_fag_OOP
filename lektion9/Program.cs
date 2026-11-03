// exercise 5.19
/*
class program
{
    static void Main()
    {
        double price = 599.95;
        double budget = 1000.0;
        bool requiredReading = true;
        bool shouldBuy = price < budget && requiredReading;

    }
}
// Den starter ved SouldBuy og kigge på om opreationen er sand. Eks hvis price er større end budget er den flask og skal ikke købes. Den starter fra venstre og går mod højere
// price og budget er evalueret som double pga komma tal og requiredReading og shouldBuy er bool fordi de enten er sandt eller falsk
// double er et sæt af tal værdier (decimal). bool er sandt (1) eller falsk (0)
// shuoldBuy beskriver om det er nødtvendigt at købe
*/

// exercise 8.7
/*
class program
{
        static double discriminants(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }
        
            static double[] Roots(double a, double b, double c)
            {   
                double d = discriminants(a, b, c);

                double x1 = (-b + Math.Sqrt(d) / (2 *a));
                double x2 = (-b - Math.Sqrt(d) / (2 *a));

                return new double[] {x1, x2};
            }

        static void Main()
        {
            double[] root = Roots(1, -5, 6);

            Console.WriteLine("Roots:");

            foreach(double r in root)
                {
                    Console.WriteLine(r);
                        if(root[0] == 5.5)
                        {
                            Console.WriteLine("BIG");
                        }
                        if(root[1] == 6)
                        {
                            Console.WriteLine("Small");
                        }
                        else
                        Console.WriteLine("Fejl");
                        break;
                }
        }
}
*/