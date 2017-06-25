using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM25DbAcces.Model
{
    public partial class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public float AverageDocumentLength { get; set; }
        public virtual ICollection<Word> Words { get; set; }
       
    }
}
