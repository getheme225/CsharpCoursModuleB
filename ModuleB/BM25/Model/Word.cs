﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BM25DbAcces.Model;

namespace BM25DbAcces.Model
{
   public partial class Word
    {
        public int Id { get; set; }
        public string WordString { get; set; } 
        public float TF { get; set; }
        public float IDF { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        
    }
}
