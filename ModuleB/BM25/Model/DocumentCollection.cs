using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM25.Model
{
   public class DocumentCollection
    {
        public int ID { get; set; }
        public string Path { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
    }
}
