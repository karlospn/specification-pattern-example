using System;
using System.Linq;
using System.Linq.Expressions;
using Specification.Base.Library;
using Specification.Logic.Library.Models;

namespace Specification.Logic.Library
{
    public class PassengerIsAChildSpecification : Specification<Passenger>
    {
        public override Expression<Func<Passenger, bool>> Expression()
        {
            return pax => pax.Age < 10;
        }
    }
}
