# Flashcard Learning Tool
A "flashcard-style" term reviewing application.  

It will uses a time based spaced interval review strategy to improve user retention.

---

### Project Terminology
**Deck** - One or more Cards.  
* Provides a way of grouping mulitple cards into a concept(s).  
* Cards can be referenced in multiple decks.

**Card** - All the parts of reviewable concept;
* Question (Implemented **CardSide**)
* Answer (Implemented in **CardSide**)
* Source (Implemented in **CardProperty**)
* Review History (Implemented in **CardProperty**)
* Next Scheduled Review (Implemented in **CardProperty**)

**CardSide** - Those properties that make up a single side of a review card.
* Text
* Image
* Audio
* layout

**CardProperties** - Properties around studing the review card
* Source
* Review History
* Next Scheduled Review
