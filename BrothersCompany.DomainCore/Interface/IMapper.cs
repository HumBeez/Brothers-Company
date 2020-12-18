using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCompany.DomainCore.Interface
{
    public interface IMapper<TSource, TTarget>
    where TSource : class
    where TTarget : class, new()
    {
        /// <summary>
        /// Maps from source to target
        /// </summary>
        /// <param name="source">The source to map from</param>
        /// <returns>The resulting target instance</returns>
        void Map(TSource source, TTarget target);

        /// <summary>
        /// Maps from source to target
        /// </summary>
        /// <param name="source">The source to map from</param>
        /// <param name="target">The target to map to</param>
        void Map(TSource source, IEnumerable<TTarget> target);

        void Map(IEnumerable<TSource> sourceSequence, ICollection<TTarget> targetCollection, params Action<TSource, TTarget>[] mappingFunctions);
    }
}
