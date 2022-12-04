namespace Module4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Анкетирование пользователя
            
            (string firstName, string lastName, string login, int loginLenght, bool availablePet, int age, string[] favColor) User;

           
            Console.WriteLine("Имя вашего питомца: {0}\n" +
                              "Тип питомца: {1}\n" +
                              "Возраст питомца: {2}\n" +
                              "Длинна имени питомца: {3}", Pet.Name, Pet.Type, Pet.Age, Pet.NameCount);

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