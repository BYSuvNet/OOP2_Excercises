# Bookstore

En övning på temat Delegater

## Instruktioner

* 1: Läs och förstå koden. 
* 2: Förstår du hur delegater används i denna kod?
* 3: Vilka SOLID-principer följs genom att lägga upp kod på detta sätt?
* 4: Lägg till en ny klass i stil med PriceTotaller som heter BookFilter. Den klassen skall i sin konstruktor ta emot en siffra för sid-antal. Den skall ha en metod som heter FilterByPageCount som tar emot ett Book objekt. Använd sedan denna klass i Main-metoden för att filtrera ut alla böcker som har fler än 200 sidor (Använd metoden FilterByPageCount med hjälp av ProcessBook-metoden). Skriv ut dessa böcker till konsolen.
* 5: Hur skulle du kunna göra en filtermetod som inte är hårdkodad för var den filtrerar på? Hint: Du behöver använda en predicata delegat någon stans.