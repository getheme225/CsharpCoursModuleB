using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM25.Model
{
   public  class Request
    {
        public int Id { get; set; }
        public string RequestString { get; set; }
        public virtual ICollection<Word> Words { get; set; }
        public virtual ICollection<Document> DocumentsResult { get; set; }
    }
}
