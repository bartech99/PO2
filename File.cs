using System;
using System.Collections.Generic;
using System.Text;
using CarsData;

namespace Handling
{
    class File
    {
        public bool Read(string title)
        {
            title = CheckTitle(title);
            Console.WriteLine(title);
            //
            return true;
        }

        public bool Save(string title)
        {
            title = CheckTitle(title);
            Console.WriteLine(title);
            //
            return true;
        }

        private string CheckTitle(string title)
        {
            string end;
            try { end = title.Substring(title.Length - 4); }
            catch { return title + ".txt"; }
            if (end.Equals(".txt", StringComparison.OrdinalIgnoreCase)) { return title; }
            else { return title + ".txt"; }
        }
    }
}
