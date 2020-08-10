using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharpBasics
{
    public class IDisposableDemo
    {
        public static void Main()
        {
            int i;
            i = 10;
            WordCount wc = new WordCount(@"C:\Users\omprakash\Desktop\Ajnara.docx");
            int words = wc.Count;
            Console.Read();
        }
    }

    public class WordCount
    {
        private String filename = string.Empty;
        private int nWords = 0;
        private String pattern = @"\b\w+\b";

        public WordCount(string filename)
        {
            if (!File.Exists(filename))
                throw new FileNotFoundException("The file does not exist.");

            this.filename = filename;
            string txt = String.Empty;
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(filename);
                txt = sr.ReadToEnd();
            }
            finally
            {
                if (sr != null) sr.Dispose();
            }
            nWords = Regex.Matches(txt, pattern).Count;

        }

        public string FullName
        { get { return filename; } }

        public string Name
        { get { return Path.GetFileName(filename); } }

        public int Count
        { get { return nWords; } }
    }
}
