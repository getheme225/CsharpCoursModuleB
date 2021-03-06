﻿using System.Collections.Generic;


namespace BM25DbAcces.Model
{
   public  class Request
    {
        public int Id { get; set; }
        public string RequestString { get; set; }
        public virtual ICollection<Word> Words { get; set; }
        public virtual ICollection<Document> DocumentsResult { get; set; }
    }
}
