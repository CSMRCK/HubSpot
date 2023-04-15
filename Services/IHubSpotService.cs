using HubSpotAuth.Models;

namespace HubSpotAuth.Services
{
    public interface IHubSpotService
    {
        Task<List<HubSpotContact>> GetAllContactsAsync();
        Task<HubSpotContact> GetContactByIdAsync(string contactId);
        Task<HubSpotContact> CreateContactAsync(HubSpotContact contact);
        Task<HubSpotContact> UpdateContactAsync(string contactId, HubSpotContact contact);
        Task DeleteContactAsync(string contactId);
    }

}
