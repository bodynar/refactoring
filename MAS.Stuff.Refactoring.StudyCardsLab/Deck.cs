namespace MAS.Stuff.Refactoring.StudyCardsLab {
    #region References
    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion
    class Deck {
        private IEnumerable<Card> Cards { get; set; }

        private Deck() {
            throw new InvalidOperationException("Constructor without params isn't allowed");
        }

        private Deck(IEnumerable<Card> cards, bool t = false) {
            if (!t)
                throw new InvalidOperationException("Constructor without params isn't allowed");

            Cards = cards;
        }

        private static Deck Default;

        public static Deck GetDeck(IEnumerable<Card> cards)
            => Default ?? (Default = new Deck(cards, true));

        public IEnumerable<Card> GetCards() {
            foreach (Card card in Cards)
                yield return card;
        }

        public Card GetCard(int index)
            => Cards.ElementAt(index);

        public void Shuffle(IShuffleProvider<Card> shuffleProvider)
            => Cards = shuffleProvider.Shuffle(Cards);
    }

}