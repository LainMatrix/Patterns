using Patterns.CreationalPatterns;

namespace Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Singleton
            Logger logger1 = Logger.Instance;
            Logger logger2 = Logger.Instance;

            logger1.Log("Программа запущена.");
            logger2.Log("Выполняется операция...");

            // Проверка, что оба экземпляра — один и тот же объект
            Console.WriteLine(object.ReferenceEquals(logger1, logger2)); // True

            //Prototype
            Circle original = new Circle { X = 10, Y = 20, Radius = 5 };
            Circle copy = (Circle)original.Clone();

            Console.WriteLine($"Original: X={original.X}, Y={original.Y}, Radius={original.Radius}");
            Console.WriteLine($"Copy:     X={copy.X}, Y={copy.Y}, Radius={copy.Radius}");

            // Проверка, что это разные объекты
            Console.WriteLine(object.ReferenceEquals(original, copy)); // False
        }
    }
}
