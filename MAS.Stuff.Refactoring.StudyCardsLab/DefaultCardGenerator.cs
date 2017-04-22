namespace MAS.Stuff.Refactoring.StudyCardsLab {
    #region References
    using System;
    using System.Collections.Generic;
    using System.Linq;
    #endregion
    class DefaultCardGenerator : ICardGenerator {
        public IEnumerable<Card> GenerateCards() {

            string[] suits = Enum.GetNames(typeof(Suit));

            foreach (var suit in suits)
            {
                IEnumerable<int> numbers = Enumerable.Range(2, 13);

                foreach (var number in numbers)
                    yield return new Card((Suit)Enum.Parse(typeof(Suit), suit), number);
            }
        }
    }
}
