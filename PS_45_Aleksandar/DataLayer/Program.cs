using DataLayer.DataBase;
using DataLayer.Model;
using Welcome.Others;

using (var context = new DatabaseContext())
{
    context.Database.EnsureCreated();
    context.Add(new DatabaseUser
    {
        Names = "user",
        Password = "password",
        Expires = DateTime.Now,
        Role = UserRolesEnum.STUDENT
    });
    context.SaveChanges();

    var users = context.Users.ToList();
    foreach (var user in users)
    {
        Console.WriteLine($"User: {user.Names}, Role: {user.Role}");
    }

    Console.WriteLine("Enter username:");
    var username = Console.ReadLine();
    Console.WriteLine("Enter password:");
    var password = Console.ReadLine();

    var loggedInUser = context.Users
        .FirstOrDefault(u => u.Names == username && u.Password == password);

    if (loggedInUser != null)
    {
        Console.WriteLine("Valid user");
    }
    else
    {
        Console.WriteLine("Invalid user or password");
    }
} 

Console.ReadKey();
   