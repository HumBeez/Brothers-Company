using BrothersCompany.DomainCore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrothersCompany.DomainCore.Abstract
{
    public abstract class BaseMapper<TSource, TTarget> : IMapper<TSource, TTarget>
        where TSource : class
        where TTarget : class, new()
    {
        public virtual void Map(TSource source, IEnumerable<TTarget> target)
        {
            target.ToList();
        }
        public abstract void Map(TSource source, TTarget target);

        public virtual void Map(IEnumerable<TSource> sourceSequence, ICollection<TTarget> targetCollection, params Action<TSource, TTarget>[] mappingFunctions)
        {

        }
    }
}
