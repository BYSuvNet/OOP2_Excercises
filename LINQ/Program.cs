internal class Program
{
    private static void Main(string[] args)
    {
        // 1. Två listor/arrayer med begränsat/litet innehåll
        // Skapa två listor med enkelt innehåll, ex strängar eller ints
        // LINQ: where, distinct, union, intersect / except
        if (true)
        {
            string[] ingredienser1 = { "mjöl", "ost", "salt", "peppar", "tomatpure", "lök", "salt" };
            string[] ingredienser2 = { "lax", "ströbröd", "smör", "peppar", "tomatpure", "lök", "lök", "lök" };

            IEnumerable<string> resultat = ingredienser1.Union(ingredienser2)
                                                        .Where(x => x.Length > 4);

            foreach (string item in resultat)
            {
                Console.WriteLine(item);
            }
        }

        // 2. Två listor med mycket innehåll. Faker.Net
        // Skapa först klass för User
        // Skapa funktionalitet för att skapa listor med x antal user-objekt
        if (false)
        {
            List<User> users = User.GetRandomListOfUsers(2000);

            users.Where(usr => usr.Country == "Sweden")
                 .ToList()
                 .ForEach(usr => Console.WriteLine(usr.FirstName + " " + usr.LastName));

            //Gruppera alla användare efter land (En ny lista med grupper skapas, där grupp.Key = landsnamnet och gruppen innehåller en lista med användare)
            var usersByCountry = users.GroupBy(usr => usr.Country)
                                      .Where(g => g.Count() <= 3) //Välj också ut bara de länder som har 3 eller färre användare
                                      .OrderBy(g => g.Count()); //Samt ordna dem i storleksordning

            //Loopa nu igenom alla våra grupper och skriv ut landsnamnet tillsammans med antalet användare
            //Skriv också ut användarnas namn
            foreach (var group in usersByCountry)
            {
                Console.WriteLine(group.Key.ToUpper() + ": " + group.Count()); //Skriver ut Country
                foreach (var user in group) Console.WriteLine("   " + user.FullName);
            }

            //Hur kan länderna ordnas i bokstavsordning?
            // usersByCountry = users.GroupBy(usr => usr.Country).OrderBy(g => g.Key);

            //Skriv ut bara antalet användare per land
            //Console.WriteLine(group.Key.ToUpper() + ": " + group.Count()); //Skriver ut Country

            //Ordna dom i ordningen flest i samma land överst
            //.OrderBy(g => g.Count());
        }

        //Hur kan du ta reda på vilket land som har användare med högst totala DataStored?
        //Alltså, räkna ihop den totala DataStored per land och skriv ut det land som ligger högst.
        //Använd dig av så mkt LINQ som möjligt, ex Sum() och Max().  (Hint: Select() behövs också...)
        if (false)
        {
            List<User> users = User.GetRandomListOfUsers(2000);

            //Gruppera alla användare efter land 
            var result = users.GroupBy(usr => usr.Country)
                              .Select(g => new { Country = g.Key, TotalDataStored = g.Sum(u => u.DataStored) })
                              .Where(g => g.TotalDataStored > 90000000);
            //   .Max(g => g.TotalDataStored);

            foreach (var item in result)
            {
                Console.WriteLine("Country: " + item.Country + " - " + item.TotalDataStored);
            }
        }

        // 3. Använda LINQ på ännu större datakällor
        // Läsa in en textfil
        // Förbereda textfilen för analys med LINQ
        if (false)
        {
            string text = File.ReadAllText("pg46.txt");
            var words = text.Split(new char[] { ' ', '?', '.', '!' }, StringSplitOptions.RemoveEmptyEntries);

            //Loopa igenom vart tionde ord i 'words'

            // Hur många ord totalt innehåller texten?
            Console.WriteLine("Totalt antal ord: " + words.Length);
            Console.WriteLine("Totalt antal korta ord: " + words.Count(w => w.Length <= 2));

            // Hur många unika ord innehåller texten?`
            Console.WriteLine("Totalt antal unika ord: " + words.Distinct().Count());

            // Hur många gånger förekommer ordet "christmas" i texten?
            Console.WriteLine("Antal christmas: " + words.Count(w => w.ToLower() == "christmas"));

            // Vilket är det vanligaste ordet i texten?
        }
    }
}
