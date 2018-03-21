using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Factory Example");
            Console.WriteLine();

            Document[] documents = new Document[2];

            documents[0] = new ResumeDocument();
            documents[1] = new ReportDocument();

            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }

            Console.WriteLine();
            Console.WriteLine("End");
            Console.ReadLine();                
        }
    }
}
