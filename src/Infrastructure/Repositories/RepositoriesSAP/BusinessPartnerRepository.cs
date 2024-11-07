
using System.Net;
using Domain.DTOs.DTOSAP;
using Domain.Entities.EntitiesSAP;
using Domain.Repositories.SAPRepositories;
using Infrastructure.Helpers;
using Newtonsoft.Json;

namespace Infrastructure.Repositories.RepositoriesSAP
{
    public class BusinessPartnerRepository(LoginHelper loginHelper) : IBusinessPartnerRepository
    {
        public Task<BusinessPartnerDTO> CreateBusinessPartnerAsync(BusinessPartner businessPartner)
        {
            throw new NotImplementedException();
        }

        public async Task<BusinessPartnerDTO> GetAllBusinessPartnerAsync()
        {
             LoginResponse loginResponse = await loginHelper.RealizarLogin();

             string url = $"https://linux-7lxj:50000/b1s/v1/BusinessPartners";
           
             HttpClientHandler clientHandler = new HttpClientHandler();
                clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; }; 

            using (var client = new HttpClient(clientHandler))
            {
                 CookieContainer cookie = new CookieContainer();              

                 client.DefaultRequestHeaders.Add("Cookie",$"B1SESSION={loginResponse.SessionId};ROUTEID=.node1");                   

                 var responseLogin = client.GetAsync(url);

                 string datasFromStore = await responseLogin.Result.Content.ReadAsStringAsync();

                 BusinessPartnerDTO? businessPartner = JsonConvert.DeserializeObject<BusinessPartnerDTO>(datasFromStore);

                 return businessPartner ?? new BusinessPartnerDTO("", null,"");
            }
        }

        public Task<bool> VerifyIfBusinessPartnerExistsAsync(string cpf)
        {
            throw new NotImplementedException();
        }
    }
}