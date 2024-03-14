using Welcome.Model;
using WelcomeExtended.Data;

namespace WelcomeExtended.Helpers
{
    public static class UserHelper
    {
        public static string ToStringExtension(this User user)
        {
            return $"Id: {user.Id}, Name: {user.Names}, Role: {user.Role}, Expires: {user.Expires?.ToString("yyyy-MM-dd") ?? "N/A"}";
        }

        public static void ValidateCredentials(this UserData userData, string name, string password)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The name cannot be empty");

            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("The password cannot be empty");


             var isValid = userData.ValidateUser(name, password);
             if (!isValid) { throw new Exception("Validation failed."); }
        }

        public static User GetUserExtension(this UserData userData, string name, string password)
        {
            return userData.GetUser(name, password);
        }
    }
}
