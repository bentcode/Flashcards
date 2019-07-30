using System;
using System.Collections.Generic;
using System.Text;

namespace Bentcode.Learning.Flashcards
{
  public class Deck
  {
    public Deck() => Cards = new List<Flashcard> { };
    public Deck(string deckName) : this() => DeckName = deckName;  
    public Deck(string deckName, string informationSource) : this(deckName) => InformationSource = informationSource;
    public Deck(string deckName, string informationSource, string informationLocation) : this(deckName, informationSource) => InformationLocation = informationLocation;
    
  

    public Flashcard this[int index]
    {
      get => this.Cards[index];
    }

    public int Length()
    {
      return this.Cards.Count;
    }

    public string DeckName { get; set; }
    public string InformationSource { get; set; }
    public string InformationLocation { get; set; }
    public List<Flashcard> Cards { get; set; }

    public string FullName
    {
      get
      {
        if (InformationSource == null)
        {
          return $"{DeckName}";
        }
        else if (InformationLocation == null)
        {
          return $"{DeckName} - { InformationSource}";
        }

        return $"{DeckName} - { InformationSource} - { InformationLocation}";
      }
    }
  }
}
