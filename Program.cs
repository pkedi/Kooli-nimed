namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var schools = new Dictionary<string, string>();

            schools.Add("1", "Tallinna Kunstigümnaasium");
            schools.Add("2", "Tallinna Tööstushariduskeskus");
            schools.Add("3", "Tallinna Mustamäe Gümnaasium");

            foreach (var school in schools)
            {
                Console.WriteLine($"{school.Key} - {school.Value}");
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine(schools["1"]);
            Console.WriteLine(schools["2"]);
            if (schools.ContainsKey("Tallinna Tööstushariduskeskus"))
            {
                Console.WriteLine(schools["2"]);
            }
            else
            {
                Console.WriteLine("Rohkem ei ole koole nimega Tallinna Tööstushariduskeskus");
            }
        }
    }
}
