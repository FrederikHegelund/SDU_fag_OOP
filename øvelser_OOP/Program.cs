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