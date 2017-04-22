namespace MAS.Stuff.Refactoring.StudyCardsLab {
    #region References
    using System;

    #endregion
    class Card {
        public Suit Suit { get; set; }

        private int number;
        public string Number {
            get {
                switch (number)
                {
                    case 11:
                        return "Валет";
                    case 12:
                        return "Дама";
                    case 13:
                        return "Король";
                    case 14:
                        return "Туз";
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        return number.ToString();
                    default:
                        throw new ArgumentException();
                }
            }
        }

        public Card(Suit Suit, int Number) {
            this.Suit = Suit;
            number = Number;
        }

        public override string ToString()
            => string.Format("{0} {1}", Number, Suit);
    }
}
