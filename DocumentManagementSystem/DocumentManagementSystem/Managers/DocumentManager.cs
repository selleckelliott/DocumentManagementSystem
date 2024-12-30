using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentManagementSystem.Documents;


namespace DocumentManagementSystem.Managers
{
  public class DocumentManager
  {
    private List<Document> _documents = new List<Document>();
    public void AddDocument(Document document)
    {
      _documents.Add(document);
    }
    public Document CloneDocument(int index)
    {
      if (index < 0 || index >= _documents.Count)
        throw new IndexOutOfRangeException("Invalid document index.");

      return _documents[index].Clone();
    }
    public void DisplayAllDocuments()
    {
      for (int i = 0; i < _documents.Count; i++)
      {
        Console.WriteLine($"Document {i + 1}:");
        _documents[i].DisplayInfo();
        Console.WriteLine();
      }
    }
  }
}
