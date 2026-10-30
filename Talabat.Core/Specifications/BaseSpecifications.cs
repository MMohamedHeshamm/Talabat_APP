using System;
using System.Collections.Generic;
using System.Text;

using Talabat.Core.Entites;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Talabat.Core.Specifications
{
    public class BaseSpecifications<T> : ISpecification<T> where T : BaseEntity
    {

        public Expression<Func<T, bool>> Criteria { get; set; }
        public List<Expression<Func<T, object>>> Includes { get; set; } = new List<Expression<Func<T, object>>>();
        public Expression<Func<T, object>> OrderBy { get; set ; }
        public Expression<Func<T, object>> OrderByDesc { get ; set; }

        public BaseSpecifications()
        {

        }

        public BaseSpecifications(Expression<Func<T, bool>> CriteriaExpression)
        {
            Criteria = CriteriaExpression;
        }

        //act as setter for the includes list
        public void AddOrderBy(Expression<Func<T, object>> OrderByExpression)
        {
            OrderBy = OrderByExpression;
        }
        //act as setter for the includes list
        public void AddOrderByDescending(Expression<Func<T, object>> OrderByDescExpression)
        {
            OrderByDesc = OrderByDescExpression;
        }


    }
}
