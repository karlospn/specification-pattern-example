using System;
using System.Linq;
using System.Linq.Expressions;
using Specification.Base.Library;
using Specification.Logic.Library.Models;

namespace Specification.Logic.Library
{
    public class PlaneHasOpenSeatsSpecification : Specification<Airplane>
    {
        public override Expression<Func<Airplane, bool>> Expression()
        {
            return airplane => airplane.Seats.Any(x => x.Available == Availability.Open);
        }
    }
}
