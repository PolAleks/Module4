namespace Module4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Анкетирование пользователя
            
            (string firstName, string lastName, string login, int loginLenght, bool hasPet, int age, string[] favColors) User;
            
            Console.WriteLine("Введите имя: ");
            User.firstName = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            User.lastName = Console.ReadLine();
            Console.WriteLine("Введите логин :");
            User.login = Console.ReadLine();
                                   
        }
    }
}