using System;
using System.Collections.Generic;
using System.Text;

namespace Bentcode.Learning.Flashcards
{
  public class Deck
  {
    public string DeckName { get; set; }
    public string InformationSource { get; set; }
    public string InformationLocation { get; set; }
    public List<Flashcard> Cards { get; set; }

    public string FullName
    {
      get => $"{ InformationSource} { InformationLocation}";
      set => FullName = $"{ InformationSource} { InformationLocation}";
    }
  }
}
