namespace Module4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Анкетирование пользователя
            
            (string firstName, string lastName, string login, int loginLenght, bool hasPet, double age, string[] favColors) User;
            
            Console.WriteLine("Введите имя: ");
            User.firstName = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            User.lastName = Console.ReadLine();
            Console.WriteLine("Введите логин :");
            User.login = Console.ReadLine();

            User.loginLenght = User.login.Length;

            Console.WriteLine("Есть ли у вас животные? Да или Нет? ");
            if(Console.ReadLine() == "Да")
                User.hasPet = true;
            else
                User.hasPet = false;

            Console.WriteLine("Введите возраст пользователя: ");
            User.age = double.Parse(Console.ReadLine());

            User.favColors = new string [3];
            Console.WriteLine("Введите три любимых цвета пользователя");
            for(int i = 0; i < User.favColors.Length; i++) 
            {
                Console.Write("{0} любимый цвет: ", i + 1);
                User.favColors[i] = Console.ReadLine() + "\n";
            }
        }
    }
}