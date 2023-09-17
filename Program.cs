using OOP1;
class Program
{
    static void Main()
    {
        Address address = new Address();
        address.Index = "12345";
        address.Country = "Україна";
        address.City = "Київ";
        address.Street = "вул. Сержа Лифаря";
        address.House = "3б";
        address.Apartment = "83";

        Console.WriteLine("Поштова адреса:");
        Console.WriteLine("Iндекс: " + address.Index);
        Console.WriteLine("Країна: " + address.Country);
        Console.WriteLine("Мiсто: " + address.City);
        Console.WriteLine("Вулиця: " + address.Street);
        Console.WriteLine("Будинок: " + address.House);
        Console.WriteLine("Квартира: " + address.Apartment);

        Converter converter = new Converter(27.5, 33.0, 7.2);

        double amountInUAH = 1000.0;
        double amountInUSD = converter.ConvertToUSD(amountInUAH);
        double amountInEUR = converter.ConvertToEUR(amountInUAH);
        double amountInPLN = converter.ConvertToPLN(amountInUAH);

        Console.WriteLine("1000 гривень в еквiвалентi:");
        Console.WriteLine("У USD: " + amountInUSD);
        Console.WriteLine("У EUR: " + amountInEUR);
        Console.WriteLine("У PLN: " + amountInPLN);

        Employee employee = new Employee("Пiголенко", "Максим");
        employee.SetPosition("Менеджер");
        employee.SetExperience(5);

        double salary = employee.CalculateSalary();
        double tax = employee.CalculateTax();

        Console.WriteLine("Спiвробiтник:");
        Console.WriteLine("Прiзвище: " + employee.LastName);
        Console.WriteLine("Iм'я: " + employee.FirstName);
        Console.WriteLine("Посада: " + employee.Position);
        Console.WriteLine("Оклад: " + salary);
        Console.WriteLine("Податковий збiр: " + tax);

        User user = new User("MaksymPiholenko2-13", "Максим", "Пiголенко", 18);
        user.DisplayUserInfo();

        Console.ReadLine();
    }
}
