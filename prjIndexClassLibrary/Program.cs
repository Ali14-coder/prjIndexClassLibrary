using prjIndexesICE;

namespace prjIndexClassLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Planet p1 = new Planet("Venus", "Terrestrial", 3.285, "Yellow-brown", false);
            Planet p2 = new Planet("Earth", "Terrestrial", 3.585, "Blue-green", false);
            Planet p3 = new Planet("Jupiter", "Gas giant", 8.6, "Brown", false);

            Console.WriteLine($"{p1[0]}\n{p2[0]}\n{p3[0]}");
        }
    }
}
