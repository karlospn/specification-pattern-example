using System;
using System.Linq;
using System.Linq.Expressions;
using Specification.Base.Library;
using Specification.Logic.Library.Models;

namespace Specification.Logic.Library
{
    public class PassengerIsAChildLivingInBcnSpecification : Specification<Passenger>
    {
        public override Expression<Func<Passenger, bool>> Expression()
        {
            var spec = new AndSpecification<Passenger>(pax => pax.Age < 10, pax => pax.City == "Barcelona");
            return spec.Expression();
        }
    }
}
