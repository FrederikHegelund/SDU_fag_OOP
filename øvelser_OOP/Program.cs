// exercise 5.4 casting:
// int har et bestemt interval af værdier og long har et andet interval af værdier
/*
int i = 127;
long l = i;

Console.WriteLine($"konvetere {l}");
*/

// ideen er at, hvis man har en int, og du ville opdatere værdien til en der ligge inde i et nyt intereval der er inde i long
/*
float g = 1.232f;
double d = g;
// ved explisisve conversion skal du skrive hvilken type den skal bliver til eks. (float)d (her er d double)
g = (float)d;

Console.WriteLine($"konventer {d}");
*/
// exercises 5.12 
/*
float i = 2f;
Console.WriteLine(i);
if (i == 2)
    {
    i += 0.5f;
    }
Console.WriteLine("nye version " + i);
// inde i if opeator skal der være et statment
        if (i == 2.5)
            {
                i += 0.5f;
            }
            Console.WriteLine("nye version " + i);

*/ 
/*
// exercises 5.19 Decision of Purchase
double price = 599.95;
double budget = 1000.0;
bool requiredReading = true;
bool shouldBuy = price < budget && requiredReading;
// den starter med at regne ud om budget og requiredReading er større ind price
// price og budget bliver vuderet via en boolean og && er også en boolean
// typen af value er double, da der er krav om decimal tal
// shouldBuy undersøger om der er mulighed for at købe. Da den kigger på om budget er større end price og om requiredReading er sand eller flask
*/

//Exercise 5.21: Manual Type Inference
/*
int b = a + 1;
*/
//nej, a er ikke en intger, da den ikke er declaret som en
// nej, da den ikke kan finde ud af at lægge to forskellige typer sammen
// ja, hvis a var en int, ville den godt kunne compile

//Exercise 7.6: Multiplication Table
/*
int size = 10;
int[] tabel = new int[size];

for (int i=0 ; i < size; i++)
{
tabel[i] = 3 * i;
}
Console.WriteLine(tabel[0]);
Console.WriteLine(tabel[1]);
Console.WriteLine(tabel[2]);
Console.WriteLine(tabel[3]);
*/
// Exercises 8.4 Sum
/*
static int Add(int a, int b)
{
    return a + b;
}
int result = Add(7 + 1, 4);
Console.WriteLine(result);
*/
// Exercise 8.3: Sūdoku Prettyprinter


 int[][] puzzle = {
new int[] {7, 3, 6, 4, 5, 2, 9, 8, 1},
new int[] {1, 9, 8, 6, 3, 7, 4, 5, 2},
new int[] {4, 2, 5, 9, 8, 1, 3, 7, 6},
new int[] {3, 6, 4, 5, 2, 8, 1, 9, 7},
new int[] {9, 5, 2, 7, 1, 4, 6, 3, 8},
new int[] {8, 1, 7, 3, 9, 6, 2, 4, 5},
new int[] {2, 8, 9, 1, 7, 3, 5, 6, 4},
new int[] {6, 7, 3, 2, 4, 5, 8, 1, 9},
new int[] {5, 4, 1, 8, 6, 9, 7, 2, 3},
};
/*
void printpuzzle(int[][] puzzle) {
for (int row = 0 ; row < puzzle.Length ; row++)
{
      Console.Write("row {0}: ", row);
        for (int col = 0 ; col <puzzle[row].Length ; col++)
        {
            Console.Write(puzzle[row][col] + " "); 
        }
        Console.WriteLine(" ");
    }
}
printpuzzle(puzzle);
/*
/*
int[] Array = {1, 2, 3, -4, 5, -6, 7, -8};
int nega = 0;
for (int i = 0 ; i < Array.Length ; i++)
{
    if(nega > Array[i])
    {
    nega = Array[i];
    }
}
Console.WriteLine("størreste negative nummer er  " + nega);
*/
/*
// Exercise 7.9: Daily Differences
double monday = 21.5;
double Tuesday = 19.6;
double wednesday = 22.5;
double friday = 25.3;
double Saturday = 21.7;
double Sunday = 18.9;

double temp(double a, double b)
{
    return a + b;
}
double result = temp(monday, wednesday);
Console.Write(result); 
*/
/*
// Exercise 8.8: Factorial function
int faction(int a)
{
    if (a ==1){
    return 1;
    }
    return a * faction(a-1);
}
Console.Write(faction(3));
*/
// Exercise 8.9: Properties of Circles

int cirkel(int c)
{
    if (c ==1){
    return 1;
    } 
    return c * cirkel(c-1);

}
Console.WriteLine(cirkel(4));
