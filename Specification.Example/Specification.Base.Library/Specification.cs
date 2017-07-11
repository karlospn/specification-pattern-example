using System;
using System.Linq.Expressions;

namespace Specification.Base.Library
{
    public abstract class Specification<T>
    {
        public bool IsSatisfiedBy(T candidate)
        {
            var func = Expression().Compile();
            return func.Invoke(candidate);
        }

        public abstract Expression<Func<T, bool>> Expression();

    }
}
