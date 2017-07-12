using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Specification.Base.Library
{
    public sealed class AndSpecification<T> : Specification<T>
    {
        private readonly Expression<Func<T,bool>> _leftSpec;
        private readonly Expression<Func<T, bool>>  _rightSpec;

        public AndSpecification(Expression<Func<T, bool>> leftSpec, Expression<Func<T, bool>> rightSpec)
        {
            _leftSpec = leftSpec;
            _rightSpec = rightSpec;
        }

        public override Expression<Func<T, bool>> Expression()
        {
            ParameterExpression paramExpr = System.Linq.Expressions.Expression.Parameter(typeof(T));
            var body = System.Linq.Expressions.Expression.AndAlso(_leftSpec.Body, _rightSpec.Body);
            body = (BinaryExpression)new ParameterReplacer(paramExpr).Visit(body);
            return System.Linq.Expressions.Expression.Lambda<Func<T, bool>>(body, paramExpr);
        }
    }
}
