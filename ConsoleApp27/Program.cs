namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            User user = new User();

            Console.WriteLine("Isdifadeci adini daxil edin");
            user.Username = Console.ReadLine();
            Console.WriteLine("Yasnizi yazin");
            user.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sifre yaz");
            user.Password = Console.ReadLine();

            Console.WriteLine($"Isfadeci Adi:  {user.Username} Yas:    {user.Age} Sifre:  {user.Password}");
        }
    }
}
