namespace MAS.Stuff.Refactoring.StudyCardsLab {
    #region References
    using System.Collections.Generic;
    #endregion
    interface IShuffleProvider<T>
        where T : class {
        IEnumerable<T> Shuffle(IEnumerable<T> items);
    }
}
