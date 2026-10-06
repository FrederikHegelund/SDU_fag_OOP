//Exercise 5.1: Temperature
/*
int[] array = {1, 2, 3, 4, 5, 10};

for(int i = 0 ; i<array.Length ; i++){
 if (array[i] == 10)
    {
        Console.WriteLine(array[5] + " is HOT");
    }
        if (array[i] == 5)
        {
            Console.WriteLine(array[4] + " is COLD");
        }
}
*/

// Exercise 5.2: Month
/*
int[] month = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
string[] name = {"januar",  "februar",  "marts",  "april"    "maj","juni",   "juli",   "august", "september", "oktober","november","december"};

for (int i = 0 ; i<month.Length ; i++){
        Console.Write(month[i] + name[i]);
}
*/

//Exercise 5.3: Limits of Integers
/*
int i =2147483647;
Console.Write(i +1 + " ");

int o = -2147483648;
Console.Write(o + -1);
*/
// Exercise 5.15: Average Age
/*
int ada_lovelace = 36; // https://en.wikipedia.org/wiki/Ada_Lovelace
int dennis_ritchie = 70; // https://en.wikipedia.org/wiki/Dennis_Ritchie
int grace_hopper = 85; // https://en.wikipedia.org/wiki/Grace_Hopper
int hedy_lamarr = 85; // https://en.wikipedia.org/wiki/Hedy_Lamarr
int edsger_dijkstra = 72; // https://en.wikipedia.org/wiki/Edsger_W._Dijkstra
int douglas_engelbart = 88; // https://en.wikipedia.org/wiki/Douglas_Engelbart
float male_avg = (float)(dennis_ritchie + edsger_dijkstra + douglas_engelbart) / 3;
float female_avg = (float)(ada_lovelace + grace_hopper + hedy_lamarr) / 3;
float avg = (male_avg + female_avg) / 2;
float diff = male_avg - female_avg;
Console.Write("Average lifespan of a male computer scientist: ");
Console.WriteLine(male_avg);
Console.Write("Average lifespan of a female computer scientist: ");
Console.WriteLine(female_avg);
Console.Write("Average lifespan of a computer scientist: ");
Console.WriteLine(avg);
Console.Write("Males live this much longer than females: ");
Console.WriteLine(diff);

// der startes med at aklærer forskellige værdier (int), der tilhører nogle forskellige variabler
// derefter aklæres der nogle forskellige float værdier der repræsenter avg_male og avg_female, og der er en kombination af alle drenge i den ene og alle ptger i den ande
// så bliver der lavet en med flaot værdi der undersøger diif og avg for alle 
// der efter printes det i tekst og nummer  

*/

// Exercise 12.1: Customers
/* 
class program
{
static void Main()
{
    costumer acostumer = new costumer("Frederik", 1);
   
    acostumer.deposit(1000);
   acostumer.withdraw(400);
   Console.WriteLine(acostumer.getbalance()); 
    }
}
*/