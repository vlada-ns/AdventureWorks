using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Repository;

using System.Security.Claims;
using GraphQL;


namespace WebApplication5.GraphQL
{
    public class WebApplication5Query : ObjectGraphType
    {
        public WebApplication5Query(ProductRepository productRepository)
        {
            /*Version: 1 get all*/
            Field<ListGraphType<ProductType>>("products",
                resolve: context => productRepository.GetAll());

            // /*Version: 2 filtering*/
            //Field<ListGraphType<ProductType>>("products",
            //    arguments: new QueryArguments(new List<QueryArgument>
            //    {
            //        new QueryArgument<IdGraphType>
            //        {
            //            Name = "productId"
            //        },
            //        new QueryArgument<DateGraphType>
            //        {
            //            Name = "name"
            //        },
            //        new QueryArgument<DateGraphType>
            //        {
            //            Name = "productNumber"
            //        },
            //        new QueryArgument<BooleanGraphType>
            //        {
            //            Name = "color"
            //        }//,
            //        //new QueryArgument<RoomStatusType>
            //        //{
            //        //    Name = "roomStatus"
            //        //}
            //    }),
            //    resolve: context =>
            //    {
            //        var query = productRepository.GetAll();

            //        //var reservationId = context.GetArgument<int?>("id");
            //        //if (reservationId.HasValue)
            //        //{
            //        //    return productRepository.GetQuery().Where(r => r.Id == reservationId.Value);
            //        //}

            //        //var checkinDate = context.GetArgument<DateTime?>("checkinDate");
            //        //if (checkinDate.HasValue)
            //        //{
            //        //    return productRepository.GetQuery()
            //        //        .Where(r => r.CheckinDate.Date == checkinDate.Value.Date);
            //        //}

            //        //var checkoutDate = context.GetArgument<DateTime?>("checkoutDate");
            //        //if (checkoutDate.HasValue)
            //        //{
            //        //    return productRepository.GetQuery()
            //        //        .Where(r => r.CheckoutDate.Date >= checkoutDate.Value.Date);
            //        //}

            //        //var allowedSmoking = context.GetArgument<bool?>("roomAllowedSmoking");
            //        //if (allowedSmoking.HasValue)
            //        //{
            //        //    return productRepository.GetQuery()
            //        //        .Where(r => r.Room.AllowedSmoking == allowedSmoking.Value);
            //        //}

            //        //var roomStatus = context.GetArgument<RoomStatus?>("roomStatus");
            //        //if (roomStatus.HasValue)
            //        //{
            //        //    return productRepository.GetQuery().Where(r => r.Room.Status == roomStatus.Value);
            //        //}

            //        return query.ToList();
            //    }
            //);

        }
    }
}
