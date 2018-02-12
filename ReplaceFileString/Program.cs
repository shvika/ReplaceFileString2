using System;
using System.Collections.Generic;
using System.Text;

namespace ReplaceFileString
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputfileName     = args[0];
            //string filterFileName    = args[1];
            string replaceFrom       = args[1];
            string replaceTo         = args[2];

            try
            {
                string text = System.IO.File.ReadAllText(inputfileName);

                text = text.Replace(replaceFrom, replaceTo);
                System.IO.File.WriteAllText(inputfileName, text);
            }
            catch (Exception ex)
            {

            }

        }
    }
}
