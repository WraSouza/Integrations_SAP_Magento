using System.Net;
using System.Net.Http.Headers;
using Domain.Entities.EntitiesMagento;
using Domain.Entities.EntitiesSAP;
using Domain.Repositories.MagentoRepositories;
using Infrastructure.Helpers;
using Newtonsoft.Json;

namespace Infrastructure.Repositories.RepositoriesMagento
{
    public class OrdersRepository() : IOrdersRepository
    {
        readonly string url = "https://www.lojatiaraju.com.br/rest/all/V1/orders?searchCriteria[currentPage]=1";
        public async Task<List<Item>> GetAllOrdersAsync()
        { 
           List<Item> orders = [];

          var content = File.ReadAllLines(@"C:\Users\wladimir.souza\Downloads\token_loja.txt");

           HttpClientHandler clientHandler = new HttpClientHandler();
                clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };     

            using (var client = new HttpClient(clientHandler))
            {
                CookieContainer cookie = new CookieContainer();              

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", content[0]);

                var response = client.GetAsync(url);

                string datasFromStore = await response.Result.Content.ReadAsStringAsync();

                RootMagento? allOrders = JsonConvert.DeserializeObject<RootMagento>(datasFromStore);

               if (allOrders is not null)  
               {
                 for(int i = 0; i < allOrders.total_count; i++)
                 {
                    if(allOrders.items is not null)
                    {
                        if(allOrders.items[i].status == "processing")
                        {                        
                           orders.Add(allOrders.items[i]);
                        }  
                    }
                    
                 }
               }                

                return orders ?? throw new Exception("");
            }            
        }
    }
}