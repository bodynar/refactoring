namespace MAS.Stuff.Refactoring.StudyCardsLab {
    #region References
    using System.Collections.Generic;
    #endregion
    class DeckFactory {
        public Deck Product(IEnumerable<Card> cards)
            => Deck.GetDeck(cards);
    }

}