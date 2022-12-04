namespace Module4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Сортировка массива внутри одной строки

            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int temp;

            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < arr.GetUpperBound(1) + 1; j++)
                {
                    for (int k = j + 1; k < arr.GetUpperBound(1) + 1; k++)
                    {
                        if (arr[i,j] > arr[i,k])
                        {
                            temp = arr[i,j];
                            arr[i,j] = arr[i,k];
                            arr[i,k] = temp;
                        }
                    }
                }
            }
            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < arr.GetUpperBound(1) + 1; j++)
                    Console.Write(arr[i, j] + " ");
                Console.WriteLine();
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