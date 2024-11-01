using System.Threading.Channels;

namespace task_custom
{
        internal class Program
        {
            static void Main(string[] args)
            {
                string customTrim = Console.ReadLine(); 
                string trimmedResult = CustomTrim(customTrim); 
                Console.WriteLine(trimmedResult);
            }

            static string CustomTrim(string trim)
            {
                int start = 0; 
                int end = trim.Length - 1; 

                
                while (start < trim.Length && char.IsWhiteSpace(trim[start]))
                {
                    start++;
                }

                
                while (end >= start && char.IsWhiteSpace(trim[end]))
                {
                    end--;
                }

                
                if (start > end)
                {
                    return "";
                }

                string result = ""; 

               
                for (int i = start; i <= end; i++)
                {
                    result += trim[i];
                }

                return result;
            }
        }
 }

