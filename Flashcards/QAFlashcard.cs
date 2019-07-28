using System;
using System.Collections.Generic;
using System.Text;
using Bentcode.Learning.Flashcards;

namespace Bentcode.Learning.Flashcards
{
  /// <summary>
  /// Two sided flashcard where one side is always the question.
  /// </summary>
  public class QAFlashcard : Flashcard
  {
    public QAFlashcard(string SideQ, string SideA) : base(SideQ, SideA)
    {
    }
  }
}
