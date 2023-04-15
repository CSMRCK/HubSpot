using HubspotApi.Models.Contacts;
using Microsoft.EntityFrameworkCore;

namespace HubSpotAuth.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly DbContext _dbContext;

        public ContactRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Contact>> GetAll()
        {
            return await _dbContext.Set<Contact>().ToListAsync();
        }

        public async Task AddRange(IEnumerable<Contact> contacts)
        {
            await _dbContext.Set<Contact>().AddRangeAsync(contacts);
            await _dbContext.SaveChangesAsync();
        }

        public Task GetContactByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateContactAsync(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Task DeleteContactAsync(object contact)
        {
            throw new NotImplementedException();
        }
    }
}
