using HubSpotAuth.Models;

namespace HubSpotAuth.Services
{
    public class HubSpotService : IHubSpotService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public HubSpotService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        Task<List<HubSpotContact>> IHubSpotService.GetAllContactsAsync()
        {
            throw new NotImplementedException();
        }

        Task<HubSpotContact> IHubSpotService.GetContactByIdAsync(string contactId)
        {
            throw new NotImplementedException();
        }

        public Task<HubSpotContact> CreateContactAsync(HubSpotContact contact)
        {
            throw new NotImplementedException();
        }

        public Task<HubSpotContact> UpdateContactAsync(string contactId, HubSpotContact contact)
        {
            throw new NotImplementedException();
        }

        public Task DeleteContactAsync(string contactId)
        {
            throw new NotImplementedException();
        }
    }

}
