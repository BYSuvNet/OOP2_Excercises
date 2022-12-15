internal class Program
{
    private static void Main(string[] args)
    {
        {
            // 1. Två listor/arrayer med begränsat/litet innehåll
            // Skapa två listor med enkelt innehåll, ex strängar eller ints
            // LINQ: where, distinct, union, intersect / except
            string[] ingredienser1 = { "mjöl", "ost", "salt", "peppar", "tomatpure", "lök", "salt" };
            string[] ingredienser2 = { "lax", "ströbröd", "smör", "peppar", "tomatpure", "lök", "lök", "lök" };

            IEnumerable<string> resultat = ingredienser1.Union(ingredienser2)
                                                        .Where(x => x.Length > 4);

            // foreach (string item in resultat)
            // {
            //     Console.WriteLine(item);
            // }
        }

        // 2. Två listor med mycket innehåll. Faker.Net
        // Skapa först klass för User
        // Skapa funktionalitet för att skapa listor med x antal user-objekt

        List<User> users = User.GetRandomListOfUsers();

        // users.Where(usr => usr.Country == "Sweden")
        //      .ToList()
        //      .ForEach(usr => Console.WriteLine(usr.FirstName + " " + usr.LastName));


        var usersByCountry = users.GroupBy(usr => usr.Country);

        foreach (var group in usersByCountry)
        {
            Console.WriteLine(group.Key.ToUpper()); //Skriver ut Country
            foreach (var user in group)
            {
                Console.WriteLine(user.FullName);
            }
        }

        //Hur kan länderna ordnas i bokstavsordning?

        //Skriv ut bara antalet användare per land

        //Ordna dom i ordningen flest i samma land överst

        //Hur kan du ta reda på vilket land som har användare mest högst totala DataStored?
        //Alltså, räkna ihop den totala DataStored per land och skriv ut det land som ligger högst.
        //Använd dig av så mkt LINQ som möjligt, ex Sum() och Max()














        // 3. Använda LINQ på ännu större datakällor
        // Läsa in en textfil
        // Förbereda textfilen för analys med LINQ
        // string text = File.ReadAllText("pg46.txt");
        // var words = text.Split(new char[] { ' ', '?', '.' }, StringSplitOptions.RemoveEmptyEntries);

        // Hur många ord totalt innehåller texten?

        // Hur många unika ord innehåller texten?`

        // Hur många gånger förekommer ordet "christmas" i texten?

        // Vilket är det vanligaste ordet i texten?
    }
}
