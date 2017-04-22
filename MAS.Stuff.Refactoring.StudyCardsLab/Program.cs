namespace MAS.Stuff.Refactoring.StudyCardsLab {
    #region References
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    #endregion
    class Program {
        static void Main(string[] args) {
            var cardGeneratorFactory = new CardGeneratorFactory();

            ICardGenerator cardGenerator = cardGeneratorFactory.Product();

            IEnumerable<Card> cards = cardGenerator.GenerateCards();

            var deckFactory = new DeckFactory();

            Deck deck = deckFactory.Product(cards);

            IEnumerable<Card> cards_ = deck.GetCards();
            foreach (Card card_ in cards_)
                Console.WriteLine(card_.ToString());

            var shuffleProvider = new RandomShuffleProvider<Card>();
            deck.Shuffle(shuffleProvider);

            IEnumerable<Card> shuffeledCards = deck.GetCards();

            foreach (Card shuffeledCard in shuffeledCards)
                Console.WriteLine(shuffeledCard.ToString());

            Console.Read();
        }
    }
}
