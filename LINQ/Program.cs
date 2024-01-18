internal class Program
{
    private static void Main(string[] args)
    {
        // 1. Skapa två listor med Users. Använd User.GetRandomListOfUsers(1000) för att skapa listorna.

        // 2. Använd Where() för att sortera ut alla användare som kommer från ett visst land.

        // 3. Använd OrderByDescending() och FirstOrDefault() för att hitta den användare som har mest DataStored.

        // 4. Hur kan du ta reda på vilket land som har användare med högst totala DataStored?
        //Alltså, räkna ihop den totala DataStored per land och skriv ut det land som ligger högst.
        //Använd dig av så mkt LINQ som möjligt, ex Sum() och Max().  (Hint: Select() behövs också...)

        // 5. Använda LINQ på ännu större datakällor
        // Läs in textfilen pg46.txt
        // Hur kan du använda LINQ för att analysera den? Exempelvis:
        // - Hur många ord finns det i texten?
        // - Hur många ord börjar på bokstaven "a"?
        // - Vilket är det vanligaste ordet?
        // - Hur många ord är längre än 10 tecken?
        // - Hur många ord är unika? (Hint: Distinct() )
        // - Hur många ord förekommer mer än 10 gånger? (Hint: GroupBy() )
        // - Vilka ord förekommer endast en gång?
    }
}

class Person
{
    public string Namn { get; set; }
    public int Ålder { get; set; }
}