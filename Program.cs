namespace Module4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 6, 9, 1, 2, 3, 4 };
            int temp;
            
            for (int k = 0; k < array.Length - 1; k++)
            {
                for (int i = k + 1; i < array.Length; i++)
                {
                    if (array[k] > array[i])
                    {
                        temp = array[k];
                        array[k] = array[i];
                        array[i] = temp;
                    }
                }
            }
            foreach (var arr in array)
            {
                Console.Write(arr + " ");
            }
            

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