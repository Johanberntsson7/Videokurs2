namespace Videokurs2;

class Program
{
    static void Main(string[] args)
    {
        // int[] LuckyNumbers = { 2, 5, 7, 25, 35, 23};
        // string[] friends = new string[5];
        // friends[0] = "Jim";
        // friends[1] = "Kelly";
        

        // Console.WriteLine( LuckyNumbers[1] );

        // Console.ReadLine();



            SayHi("Johan", 26, "Ulricehamn");
            SayHi("Hugo", 28, "Gothenburg");
            SayHi("Tilde", 35, "Stockholm");
            Console.ReadLine();
        }
    
         static void SayHi(string name, int age, string city)
        {
         Console.WriteLine($"Hello {name}, you are {age}, you are from {city} " );
        
         }
    
}
