using SignalRWebUI.Dtos.Contacts.Create;
using SignalRWebUI.Dtos.Contacts.Model;
using SignalRWebUI.Dtos.Contacts.Update;

namespace SignalRWebUI.Controllers
{
    public class ContactController : GenericController<GetContactDto, CreateContactDto, UpdateContactDto>
    {
        public ContactController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }
    }
}
