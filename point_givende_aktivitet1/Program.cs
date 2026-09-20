// foreach loops if else 
/*
int [] tal = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

foreach(int nummer in tal)
{
    if (nummer == 10)
    Console.WriteLine("BIG");
    else 
    Console.WriteLine(nummer);
}
*/

//for statment, slektiv version
/*
class Program
{
    static void Main(string[] args)
    {
string[] biller = {"BMW", "FORD", "TESLA", "POLOSTAR"};

for (int i=0; i < biller.Length; i++)
        {
            if ("BMW" == biller[0])
            {
            Console.WriteLine(biller[0]);
            }
            else{
                Console.WriteLine("Kill yourself");
            }
            if ("FORD" == biller[3]){
            Console.WriteLine("ja");
            }
            else {
            Console.WriteLine("FORD er 2");
            }
        }
    }
}
*/
/*
int[] year = {12, 23, 44, 43};

int max = year[0];
int min = year[1];

for (int i=0; i< year.Length; i++)
{
    if (year[i] > max)
    max = year[i];
}
Console.Write(max);
*/

// nummer test
/*
int a = 12;
int b = 33;
double c = 4.44;

if (c * b == 146.52)
{
    Console.WriteLine("TRUE");
}

    else 
    {
        Console.WriteLine(a);
    }
*/