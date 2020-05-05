using System;
using System.Linq;
using System.Collections;

public class SolutionSixtytwo
{
    public static string reverse_remove_parentheses(string str)
    {
        int lid = str.LastIndexOf('(');
        if (lid == -1)
        {
            return str;
        }
        else
        {
            int rid = str.IndexOf(')', lid);

            return reverse_remove_parentheses(
                  str.Substring(0, lid)
                + new string(str.Substring(lid + 1, rid - lid - 1).Reverse().ToArray())
                + str.Substring(rid + 1)
            );
        }
    }

    public static void Main()
    {
        Console.WriteLine(reverse_remove_parentheses("p(rq)st"));
        Console.WriteLine(reverse_remove_parentheses("(p(rq)st)"));
        Console.WriteLine(reverse_remove_parentheses("ab(cd(ef)gh)ij"));
    }
}