/*Console.WriteLine("Celcius to Fharenhiet");

for (double c=0.5 ; c<=10.5 ; c++) {
    double fahrenheit = 32+(9.0/5.0)*c;
    Console.WriteLine("Celcius is " + c + "Fharenhiet" + fahrenheit);
}
*/

// exercises 5.20 dice

/*
 int dice=2;

 if (dice==2){
     Console.WriteLine("winner");
 }
 else{
     Console.WriteLine("loser");
 }
 */

 int jul = 21816000;
 double pris = 599.95;
 int dag =24 * 60 * 60;
 int måned = 30 * dag;
 int sekunder_jul = 12* måned;
 if (jul >= sekunder_jul) {
 Console.WriteLine(jul + "TV 50'' " + (599.95/30) + "pris" + pris);
 }
 else {
 Console.WriteLine("gg_kidd");
 }