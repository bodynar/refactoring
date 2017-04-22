namespace MAS.Stuff.Refactoring.StudyCardsLab {
    #region References
    #endregion
    class CardGeneratorFactory {
        public ICardGenerator Product()
            => new DefaultCardGenerator();
    }
}