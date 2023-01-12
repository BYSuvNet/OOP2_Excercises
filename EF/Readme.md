# Entity Framework
## Mål
Se till så att applikationen kan spara samtliga klasser till en SQLite-databas. Använd EF för att skapa tabeller för Authors, Blogs, BlogPosts och Comments. Börja med Author och sedan BlogPost om du vill ta det i steg. 

## Start
* Lägg till Entity Framework:
    * dotnet add package Microsoft.EntityFrameworkCore
    * dotnet add package Microsoft.EntityFrameworkCore.Sqlite
    * dotnet add package Microsoft.EntityFrameworkCore.InMemory
    * dotnet add package Microsoft.EntityFrameworkCore.Design
* Skapa DBContext-klassen
* Lägg till DBSet<T> för alla entiteter
* Se till att alla entiteter som skall ligga i databasen har en Id-property
* När DBContext är klar kan databas-filen skapas:
    * dotnet ef migrations add InitialCreate
    * dotnet ef database update

## Tips
* Gör saker steg för steg och se till så att saker funkar, försök inte lägga in alla tabeller samtidigt.
* Använd InMemory-databas först för att verifiera att koden kompilerar i tidigt skede
* Det är ganska troligt att alla klasser inte är helt anpassade för att användas med EF ännu. Exempelvis Blog.cs behöver troligen skrivas om en del. 
* 

