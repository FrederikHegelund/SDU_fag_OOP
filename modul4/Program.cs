Console.WriteLine("Hello, World!");

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