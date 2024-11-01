using System.Diagnostics;
using System.Reflection.Metadata;

namespace task_validatepassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();
            bool validPassword = ValidatePassword(password);
            Console.WriteLine(validPassword);
        }
        static bool ValidatePassword(string password)
        {
            bool isDigit = false;
            bool isSpcChar = false;

            if (password.Length < 8)
            {
                return false;
            }
            if (!char.IsUpper(password[0]))
            {
                return false;
            }
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    isDigit=true;
                }
                if(!char.IsLetterOrDigit(c))
                {
                    isSpcChar = true;
                    break;
                }
            }
            return isDigit && isSpcChar;

        }
    }
}
