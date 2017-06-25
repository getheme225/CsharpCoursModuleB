using System.Collections.Generic;

namespace BM25DbAcces.DbModel
{
   public partial class DocumentCollection
    {
        public int ID { get; set; }
        public string Path { get; set; }
        public int AllWordCount { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
    }
}
