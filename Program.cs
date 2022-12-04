namespace Module4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Заполнение анкеты плользователя в кортеж
            (string name, int age) anketa;

            Console.Write("Введите ваше имя: ");
            anketa.name = (Console.ReadLine());
            Console.Write("Введите ваш возраст: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваше имя: {0}\nВаш возраст: {1}", anketa.name, anketa.age);

            //int t = 0;
            //do
            //{
            //    Console.WriteLine(t++);

            //    Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            //    var color = Console.ReadLine();

            //    switch (color)
            //    {
            //        case "red":
            //            Console.BackgroundColor = ConsoleColor.Red;
            //            Console.ForegroundColor = ConsoleColor.Black;
            //            Console.WriteLine("Your color is {0}", color);
            //            break;
            //        case "green":
            //            Console.BackgroundColor = ConsoleColor.Green;
            //            Console.ForegroundColor = ConsoleColor.Black;
            //            Console.WriteLine("Your color is {0}", color);
            //            break;
            //        case "cyan":
            //            Console.BackgroundColor = ConsoleColor.Cyan;
            //            Console.ForegroundColor = ConsoleColor.Black;
            //            Console.WriteLine("Your color is {0}", color);
            //            break;
            //        default:
            //            Console.BackgroundColor = ConsoleColor.Yellow;
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.WriteLine("Your color is yellow");
            //            break;
            //    }
            //} while(t < 3);
        }
    }
}