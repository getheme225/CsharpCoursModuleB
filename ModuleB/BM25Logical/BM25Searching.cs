using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BM25DbAcces;
namespace BM25Logical
{
    public class BM25Searching
    {
        private const double K = 2.0;
        private const double B = 0.75;
        private DirectoryInfo Catalog { get; set; }
        private string Request { get; set; }

        public BM25Searching(string StartPath, string request)
        {
             Catalog = new DirectoryInfo(StartPath);
            Request = request;
        }

        private void DbInitialisation()
        {
            using Bm25DbContext db = new Bm25DbContext()
            {
                
            }
        }
   }
}
