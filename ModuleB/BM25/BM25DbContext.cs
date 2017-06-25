using System.Data.Entity;
using BM25DbAcces.Model;

namespace BM25DbAcces
{
  public  class Bm25DbContext:DbContext
    {
      public  DbSet<Document> Documents { get; set; }
      public DbSet<Word> Words { get; set; }
        public DbSet<DocumentCollection>  DocumentCollections {get; set; }
        public DbSet<Request> Requests { get; set; }
    }
}
