# Lab3LinneaOchAndreas
Lab3 in database. Adding a UI to books-database.

Lab3 av Linnéa Netzell och Andreas Nilsson 2021

Först, Kör SQL-scriptet Lab2_sql_v12AndreasLinnea.sql i valfri databashanterare, men om annan databasserver än (localdb)\MSSQLLocalDB används så MÅSTE detta justeras
i connectionString i appsettings.json.

För att lägga till ny bok; gör följande:
1) Lägg till en eller flera böcker. (Manage Books)
2) Lägg till en eller flera författare. (Manage Authors)
3) Koppla ihop bok med författare, en i taget om flera författare skrivit samma bok. (Connect Authors and books).

För att ändra information på bok resp författare, så görs detta i Manage Books samt Manage Authors.
Klicka på den bok/författare som ska ändras, ändra den information som ska uppdaters och klicka sedan på 'Save update'.

I lagersaldo, Stock Balance, hanteras antalet böcker varje bokaffär har på hyllorna.
För en ny bok i en butik, välj Bookstore och Book, och fyll i antalet böcker (Number of items). Klicka sedan på 'Add new'.

För att ändra lagersaldot, välj Bookstore och Book, fyll sedan i det saldo som affären ska ha. Klicka sedan på 'Update'.

För att radera data i Stock Balance och Connect Author and Books, fyll i önskad data och klicka på Remove. 
Konfirmera i följande dialogruta.

OBS!!!
Istället för att ha en delete-funktion på vissa ställen så använder vi oss av en Active-bock.
Avbockad författare eller bok = inaktiv/borttagen

Allt enligt en överenskommelse med läraren.
OBS!!!
