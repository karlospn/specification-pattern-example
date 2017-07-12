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

    public abstract class Specification<T1, T2>
    {
        public bool IsSatisfiedBy(T1 candidate1, T2 candidate2)
        {
            var func = Expression().Compile();
            return func.Invoke(candidate1, candidate2);
        }

        public abstract Expression<Func<T1, T2, bool>> Expression();

    }


}
