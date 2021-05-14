# Lab3LinneaOchAndreas
Lab3 in database. Adding a UI to books-database.

Lab3 av Linnéa Netzell och Andreas Nilsson 2021

URL till uppgiften: https://github.com/Bebben86/Lab3LinneaOchAndreas.git

Bifogat i uppgiften på ITHS Distans finns ett SQL-script vid namn Lab2_sql_v13AndreasLinnea.sql.
Den är för SQL v13.
Kör scriptet i valfri databashanterare, men om annan databas än (localdb)\MSSQLLocalDB så MÅSTE detta justeras
i connectionString i appsettings.json.

Flödet är att:
1) Lägg till en eller flera böcker. (Manage Books)
2) Lägg till en eller flera författare. (Manage Authors)
3) Koppla ihop bok med författare, en i taget om flera författare skrivit samma bok. (Connect Authors and books).


OBS!!!
Istället för att ha en delete-funktion så anvädner vi oss av Active-bock.
Avbockad författare eller bok = inaktiv/borttagen

Allt enligt en överenskommelse med Claes. :)
OBS!!!
