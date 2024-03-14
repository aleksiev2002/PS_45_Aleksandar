using Welcome.Model;
using Welcome.Others;
using WelcomeExtended.Data;
using WelcomeExtended.Others;

try
{
    UserData userData = new UserData();

    userData.AddUser(new User("Alex Alexiev", "password123", UserRolesEnum.STUDENT));
    userData.AddUser(new User("Student2", "123", UserRolesEnum.STUDENT));
    userData.AddUser(new User("Teacher", "1234", UserRolesEnum.PROFESSOR));
    userData.AddUser(new User("Admin", "12345", UserRolesEnum.ADMIN));

    // Подкана за вход
    Console.WriteLine("Please enter your name:");
    string name = Console.ReadLine();
    Console.WriteLine("Please enter your password:");
    string password = Console.ReadLine();

    // Валидация на потребителя
    bool isValid = userData.ValidateUser(name, password);
    if (isValid)
    {
        // Получаване на потребителя
        User user = userData.GetUser(name, password);

        // Визуализация на потребителските данни
        if (user != null)
        {
            
            Console.WriteLine(user.ToString()); 
        }
        else
        {
            Console.WriteLine("Потребителят не е намерен");
        }
    }
    else
    {
        Console.WriteLine("Потребителят не е намерен");
    }
}
catch (Exception e)
{
    var log = new ActionOnError(Delegates.Log);
    log(e.Message);
}
finally
{
    Console.WriteLine("Executed in any case");
}

