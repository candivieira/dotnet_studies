using Persistence;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext _context; // " _ " is a .NET name convention, used for private fields
        public ActivitiesController(DataContext context)
        {
            _context = context;
        }

        
    }
}