using HubspotApi.Models.Contacts;
using HubSpotAuth.Repositories;
using HubSpotAuth.Services;
using Microsoft.AspNetCore.Mvc;

namespace HubSpotAuth.Controllers
{
    [ApiController]
[Route("[controller]")]
public class ContactController : ControllerBase
{
    private readonly IHubSpotService _hubSpotService;
    private readonly IContactRepository _contactRepository;

    public ContactController(IHubSpotService hubSpotService, IContactRepository contactRepository)
    {
        _hubSpotService = hubSpotService;
        _contactRepository = contactRepository;
    }

    [HttpGet]
    [Route("contacts")]
    public async Task<IActionResult> GetContacts()
    {
        try
        {
            var hubspotContacts = await _hubSpotService.GetAllContactsAsync();

            var contacts = hubspotContacts.Select(c => new Contact
            {
                FirstName = c.FirstName,
                LastName = c.LastName,
                Email = c.Email
            });

            await _contactRepository.AddRange(contacts);

            return Ok("Contacts inserted successfully");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}

}
