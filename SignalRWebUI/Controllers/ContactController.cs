using SignalRWebUI.Dtos.Concretes.Contacts;

namespace SignalRWebUI.Controllers
{
    public class ContactController : GenericController<ResultContactDto, CreateContactDto, UpdateContactDto>
    {
        public ContactController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }
    }
}
