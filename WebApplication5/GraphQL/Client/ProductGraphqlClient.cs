using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//using GraphQL.Client;
//using GraphQL.Common.Request;
//using WebApplication5.Models;

//namespace WebApplication5.GraphQL.Client
//{
//    /*This class is created to use GraphQl.Client library*/
//    public class ProductGraphqlClient
//    {
//        private readonly GraphQLClient _client;

//        public ProductGraphqlClient(GraphQLClient client)
//        {
//            _client = client;
//        }

//        public async Task<List<Product>> GetReservationsAsync()
//        {
//            var query = new GraphQLRequest
//            {
//                Query = @"
//                    query product {
//                      products {
//                        name
//                      }
//                    }
//                    "
//            };

//            var response = await _client.PostAsync(query);
//            if (response.Errors != null && response.Errors.Any())
//            {
//                throw new ApplicationException(response.Errors[0].Message);
//            }

//            var products = response.GetDataFieldAs<List<Product>>("products");
//            return products;
//        }
//    }
//}
