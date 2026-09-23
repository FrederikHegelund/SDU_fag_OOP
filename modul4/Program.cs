
/*
int [] nummer = {1, 2, 3, 4, 5};
int stor = nummer[0];
int index = 0;

for (int i = 1; i < nummer.Length; i++) {
    if (nummer[i] > stor){
        stor = nummer[i];
        index = 1;
    }
}
Console.WriteLine($"Stor: {stor}");
Console.WriteLine($"index: {index}");
*/
// exercise 7.15
/*
class person {
public int age;
public int højde;
public double vægt;
}

class program 
{
    static void Main()
        {
            person f = new person{ age = 21 , højde = 192 , vægt = 84.6};
        Console.WriteLine("person f er " + f.age);
        Console.WriteLine("person f er " + f.højde);
        Console.WriteLine("person f er " + f.vægt);
        }
}
*/

// Exercise 7.3: Array Type
// typen af Arrays, er declaret ved at putte typen af data for an eks. Int[] (integer Arrays)

// Exercise 7.5: Size of Array Allocation
// for at bestemme, hvor mange elementer der er. Gøres ved at sige hvilken slags Array det er, derefter skrive inde i []
// skrives som int [] = new Int[10]

// Exercise 7.7: Sudoku Puzzle
// How would you represent a Sūdoku1 puzzle in C#? 
// via. et 2D Array, og definere størelsen på den
// How is this data structure laid out in memory?
// Da, det er 2D Array, ligger det kompakt i hukommelsen

/*
int [] måned = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12];
int [] leap = [20, 30, 40, 50, 60, 70, 80, 90, 100, 110];

int J = 1;



if (J ==3){
Console.WriteLine(måned[J]);
}
else{
Console.WriteLine(leap[J]);
}
*/

// Exercise 7.16: Direction
/*
enum vej {
øst,
west,
north,
south,
}
*/
/*
int [] cirkel = [1, 3, 5,];
int D = 0;
int E = 1;
int R = 2;
double P = 3.14;

Console.WriteLine(cirkel[D]* cirkel[D] * P);
Console.WriteLine(cirkel[E]* cirkel[E] * P);
Console.WriteLine(cirkel[R] * cirkel[R] * P);
*/
// jeg har valgt at udfører denne opgave ved undersøge det største negative nummer i et Array, derefter ændre række følgende, som det ligger først i mit Array
/*
int [] numbers = {1, 2, 3, -4, 5, 6,};
int i = numbers[3];

for (i=0; i < numbers.Length ; i++)
{
    if (numbers[i] > numbers[0])
    {
        i = numbers[0];
    }
}
Console.WriteLine("lageste negativ number is " + numbers[0]);
*/