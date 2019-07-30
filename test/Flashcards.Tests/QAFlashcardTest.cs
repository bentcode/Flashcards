using System;
using Xunit;
using Bentcode.Learning.Flashcards;

namespace Flashcards.Tests
{
  public class QAFlashcardTest
  {
    [Fact]
    public void TestConstructor()
    {
      // Typical test are broken into 3 sections (triple A)
      // Arrange Section
      string QText = "What are the 3 sections of a unit test?";
      string AText = "Arrange, Act, Assert";
      QAFlashcard qaCard = new QAFlashcard( QText, AText);

      // Act Section
      var actualQ = qaCard.QuestionText;
      var actualA = qaCard.AnwserText;

      // Assert section
      Assert.NotNull(actualQ);
      Assert.True(actualQ.Length > 0);
      Assert.Equal(QText, actualQ);

      Assert.NotNull(actualA);
      Assert.True(actualA.Length > 0);
      Assert.Equal(AText, actualA);
    }
  }
}
