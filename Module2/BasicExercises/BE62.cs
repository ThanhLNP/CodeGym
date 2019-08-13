using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicExercises
{
    class BE62
    {
        static void Main()
        {
            Console.WriteLine(reverse_remove_parentheses("p(rq)st"));
            Console.WriteLine(reverse_remove_parentheses("(p(rq)st)"));
            Console.WriteLine(reverse_remove_parentheses("ab(cd(ef)gh)ij"));
        }
        public static string reverse_remove_parentheses(string str)
        {
            int lid = str.LastIndexOf('(');
            if (lid == -1) //kiem tra con dau "(" hay ko
            {
                return str;
            }
            else
            {
                int rid = str.IndexOf(')', lid); //tim dau ")" ngay sau dau "("

                return reverse_remove_parentheses(
                      str.Substring(0, lid) //giu nguyen chuoi truoc cap dau "()"
                    + new string(str.Substring(lid + 1, rid - lid - 1).Reverse().ToArray()) //dao nguoc chuoi trong cap dau "()"
                    + str.Substring(rid + 1) //giu nguyen chuoi sau cap dau "()"
                );
            }
        }
    }
}
