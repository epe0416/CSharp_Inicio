//using System.Globalization;
partial class Program
{
    static void Linq()
    {
        List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        List<int> evenNumbers = [];

        foreach(var number in numbers)
        {
            if(number % 2 == 0)
            {
                evenNumbers.Add(number);
            }
        }

        // Sintaxis de Consulta
        var evenNumbersQuery = from num in numbers
                               where num % 2 == 0
                               select num;
        // Sintaxis de Método
        var evenNumberMethod = numbers.Where(n => n%2 == 0);
        foreach (var number in evenNumberMethod)
        {
            //WriteLine(number);
        }

        /**
         * Nueva Parte: Consultas simples utilizando LINQ
         * **/

        // Consultas simples

        List<MarvelCharacter> characters = new List<MarvelCharacter>
        {
            new MarvelCharacter { Name = "Peter Parker", Alias = "Spider-Man", Team = "Avengers" },
            new MarvelCharacter { Name = "Tony Stark", Alias = "Iron Man", Team = "Avengers" },
            new MarvelCharacter { Name = "Steve Rogers", Alias = "Captain America", Team = "Avengers" },
            new MarvelCharacter { Name = "Natasha Romanoff", Alias = "Black Widow", Team = "Avengers" },
            new MarvelCharacter { Name = "T'Challa", Alias = "Black Panther", Team = "Wakanda" },
            new MarvelCharacter { Name = "Stephen Strange", Alias = "Doctor Strange", Team = "Defenders" }
         };
        //WriteLine("Personajes de los Avengers:");
        var avengersQuery = from c in characters
                            where c.Team == "Avengers"
                            select $"{c.Alias} {c.Name}";

        var avengersMethod = characters.Where(C => C.Team == "Avengers")
                                        .Select(c => $"{c.Alias} {c.Name}");
        foreach ( var character in avengersMethod)
        {
            //WriteLine(character);
        }

        var uppercaseNamesQuery = from c in characters
                                  select c.Name?.ToUpper();

        var uppercaseNamesMethod = characters.Select(c => c.Name?.ToUpper());

        //WriteLine("Los nombre en Mayúscula: ");
        //foreach (var name in uppercaseNamesQuery)
        //{
        //    WriteLine(name);
        //}

        var sortedQuery = from c in characters
                          orderby c.Name
                          select c.Name;
        var sortedMethod = characters.OrderByDescending(c => c.Name);

        //WriteLine("Ordernar los nombre de manera descendente ");
        //foreach (var character in sortedMethod)
        //{
        //    WriteLine(character.Name);
        //}

        var firstThreeQuery = (from c in characters
                               select c).Take(3);

        var firstThreeMethod = characters.Take(3);

        WriteLine("Obteniendo los primeros 3 ");
        foreach (var character in firstThreeMethod)
        {
            WriteLine(character.Name);
        }
    }
}
class MarvelCharacter
{
    public string? Name { get; set; }
    public string? Alias { get; set; }
    public string? Team { get; set; }
}