using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Bentcode.Learning.Flashcards;

namespace Flashcards.Tests
{
  public class DeckTest
  {
    [Fact]
    public void TestConstructor()
    {
      // Arrange
      string name = "CSharp";
      string infoSource = "C# 7 and .Net Core 2.0";
      string infoSourceLocation = "Chapter 4";

      string nameWSource = $"{name} - {infoSource}";
      string nameWSourceLocation = $"{name} - {infoSource} - {infoSourceLocation}";

      Deck deck = new Deck(name);
      Deck deckWSource = new Deck(name, infoSource);
      Deck deckWSourceLocation = new Deck(name, infoSource, infoSourceLocation);

      // Act
      string returnedFullName = deck.FullName;
      string returnedFullNameWSource = deckWSource.FullName;
      string returnedFullNameWLocation = deckWSourceLocation.FullName;

      // Assert
      Assert.Equal(name, returnedFullName);
      Assert.Equal(nameWSource, returnedFullNameWSource);
      Assert.Equal(nameWSourceLocation, returnedFullNameWLocation);
    }


    [Fact]
    public void TestIndexer()
    {
      // Arrange
      string question = "How do you define an indexer?";

      Deck deck = CreateAPopulatedDeck();

      // Act
      string qtext = deck[1].QuestionText;

      // Assert
      Assert.Equal(question, qtext);
    }

    private Deck CreateAPopulatedDeck()
    {
      string name = "CSharp";
      string infoSource = "C# 7 and .Net Core 2.0";
      string infoSourceLocation = "Chapter 4";
      Deck deck = new Deck(name, infoSource, infoSourceLocation);

      deck.Cards.Add( new QACFlashcard("What is a 'Field'?", "A data member of the class. \n\nIn general they should not be public… only private or protected."));
      deck.Cards.Add( new QACFlashcard("How do you define an indexer?", "You must user the 'this' followed by square brackets"));
      deck.Cards.Add( new QACFlashcard("What is a class 'Event'?", "Class members that allow an object to notify subscribers whenever something noteworthy happens.\n\nExamples of an event is a field or property change."));

      return deck;
    }
  }
}
