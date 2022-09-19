namespace lab1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Select an action:");

            Console.WriteLine("1 - Address");
            Console.WriteLine("2 - Converter");
            Console.WriteLine("3 - Employee");
            Console.WriteLine("4 - User");

            switch (Console.ReadLine())
            {
                case "1":
                    Address address = new("12345", "Ukraine", "Kyiv", "Khreshchatyk avenue", "17", "25");
                    address.ShowAddressInfo();
                    break;
                case "2":
                    Converter converter = new(42, 41.5, 0.25);
                    Console.WriteLine("Converted from {0} to uah: {1}", converter.Currency, converter.ConvertToUah());
                    break;
                case "3":
                    Employee employee = new("John", "Doe", "Developer", 1000, 5, 0.2);
                    employee.ShowEmployeeInfo();
                    break;
                case "4":
                    User user = new("John", "Doe", 20, "johndoe", "123456", DateTime.Now);
                    user.ShowUserInfo();
                    break;
                default:
                    Console.WriteLine("Incorrect value was entered.");
                    break;
            }
        }
    }
}
