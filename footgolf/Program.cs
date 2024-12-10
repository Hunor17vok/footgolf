namespace footgolf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Sportolo> Sportolok = new();
            foreach (var sor in File.ReadAllLines("fob2016.txt"))
            {
                Sportolok.Add(new Sportolo(sor));
            }
            Console.WriteLine($"3.Feladat:A sportolok száma:{Sportolok.Count()}");

            int C = 0;
            foreach (var i in Sportolok)
            {
                if (i.Kategoria == "nok")
                {
                    C += 1;
                }
                
            }
            Console.WriteLine($"4.Feladat:A női versenyzök atánya:{Sportolok.Count() / C:0.0.0}%");
        }
    }
}
