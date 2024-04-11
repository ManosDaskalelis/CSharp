using InterfacesApp.Service;

namespace InterfacesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMovable movable = new Point2D()
            {
                X = 10,
                Y = 20
            };

            movable.Move10();
            Console.WriteLine(movable);

            IMovable p2 = new Point2D()
            {
                X = 4,
                Y = 6
            };

            MovingSpace m2 = new(p2);

            m2.MakeMove5();
        }
    }
}
