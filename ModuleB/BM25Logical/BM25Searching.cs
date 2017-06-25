using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BM25DbAcces;
using BM25DbAcces.DbModel;
using BM25DbAcces.Model;

namespace BM25Logical
{
    public class Bm25Searching
    {
        private const double K = 2.0;
        private const double B = 0.75;
        private DirectoryInfo Catalog { get; set; }
        private string Request { get; set; }

        public Bm25Searching(string startPath, string request)
        {
             Catalog = new DirectoryInfo(startPath);
            Request = request;
        }

        private void DbInitialisation()
        {
            

        }

        private int WordCatalogCount ()
        {
            var count = 0;
            var result = new List<Document>();
            foreach (var file in Catalog.GetFiles(searchPattern: ".txt"))
            {
                using (var streamReader = File.OpenText(file.Name))
                {
                    string content = streamReader.ReadToEnd();
                    var a = content.Split();
                    count += a.Count();
                }
            }
            return count;
        }

        private DocumentCollection CreateDocCollection()
        {
            
               return new DocumentCollection()
                {
                    Path = Catalog.FullName,
                    AllWordCount = WordCatalogCount()
                };            
        }
        
   }
}

