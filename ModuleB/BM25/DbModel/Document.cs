using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM25DbAcces.DbModel
{
    public partial class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float AverageDocumentLength { get; set; }
        public DocumentCollection Catalog { get; set; }
        public virtual ICollection<Word> Words { get; set; }
       
    }
}
