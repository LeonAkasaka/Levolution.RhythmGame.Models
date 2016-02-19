using System;
using System.Collections.Generic;
using System.Text;

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
