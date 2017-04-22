namespace MAS.Stuff.Refactoring.StudyCardsLab {
    #region References
    using System.Collections.Generic;
    #endregion
    interface ICardGenerator {
        IEnumerable<Card> GenerateCards();
    }
}
