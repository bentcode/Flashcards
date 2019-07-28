using System;
using System.Collections.Generic;
using System.Text;
using Bentcode.Learning.Flashcards;

namespace Bentcode.Learning.Flashcards
{
  /// <summary>
  /// Two-sided flashcard with a 3rd card ('C') that contains "common information" that should be displayed regardless
  /// of which side is being used as the question. 
  /// </summary>
  public class QACFlashcard : Flashcard
  {
    public QACFlashcard(string SideA, string SideB) : base(SideA, SideB)
    {
    }
  }
}
