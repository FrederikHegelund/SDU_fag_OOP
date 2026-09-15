
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