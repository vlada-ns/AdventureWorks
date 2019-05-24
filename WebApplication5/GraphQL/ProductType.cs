using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Models;

namespace WebApplication5.GraphQL
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(x => x.ProductId);
            Field(x => x.Name);
            Field(x => x.ProductNumber);
            Field(x => x.Color);
        }
    }
}
