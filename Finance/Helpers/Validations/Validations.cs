using System.Text.RegularExpressions;

namespace Finance.Helpers.Validations
{
    public static class Validations
    {
        public static bool EmailIsValid(string email)
        {
            string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        public static bool PasswordIsValid(string email)
        {
            string pattern = @"^(?=.*[!@#$%^&*])(.{8,})$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

    }
}
