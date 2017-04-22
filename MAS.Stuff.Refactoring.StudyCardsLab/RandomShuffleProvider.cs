namespace MAS.Stuff.Refactoring.StudyCardsLab {
    #region References
    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion
    class RandomShuffleProvider<T> : IShuffleProvider<T>
        where T : class {
        public IEnumerable<T> Shuffle(IEnumerable<T> items) {
            var random = new Random();
            return items.OrderBy(x => random.Next());
        }
    }
}
