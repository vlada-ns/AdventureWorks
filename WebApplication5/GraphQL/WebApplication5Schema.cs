using GraphQL.Types;
using GraphQL;

namespace WebApplication5.GraphQL
{
    public class WebApplication5Schema : Schema
    {
        public WebApplication5Schema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<WebApplication5Query>();
        }
    }

    //public class WebApplication5Schema : Schema
    //{
    //    public WebApplication5Schema(WebApplication5Query query, IDependencyResolver resolver)
    //    {
    //        Query = query;
    //        DependencyResolver = resolver;
    //    }
    //}
}
