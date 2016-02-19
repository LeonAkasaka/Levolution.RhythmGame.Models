using System.Collections.Generic;

namespace Levolution.RhythmGame.Models
{
    /// <summary>
    /// 
    /// </summary>
    public interface IMusicalScore<TTarget>
    {
        /// <summary>
        /// 
        /// </summary>
        IEnumerable<INote<TTarget>> Notes { get; }
    }
}
