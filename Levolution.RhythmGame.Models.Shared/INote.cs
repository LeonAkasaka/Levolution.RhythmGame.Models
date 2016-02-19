using System;

namespace Levolution.RhythmGame.Models
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TNote"></typeparam>
    /// <typeparam name="TOrientation"></typeparam>
    public interface INote<TTarget>
    {
        /// <summary>
        /// 
        /// </summary>
        TimeSpan StartTime { get; }

        /// <summary>
        /// 
        /// </summary>
        TimeSpan? EndTime { get; }

        /// <summary>
        /// 
        /// </summary>
        TTarget Target { get; }
    }
}
