using HubspotApi.Models.Contacts;

namespace HubSpotAuth.Repositories
{
    public interface IContactRepository
    {
        Task<IEnumerable<Contact>> GetAll();
        Task AddRange(IEnumerable<Contact> contacts);
        Task GetContactByIdAsync(int id);
        Task UpdateContactAsync(Contact contact);
        Task DeleteContactAsync(object contact);
    }
}
