using FamilyTree.Models;
using Microsoft.AspNetCore.Mvc;

namespace FamilyTree.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RelationController : ControllerBase
    {
        private readonly ILogger<RelationController> _logger;

        public RelationController(ILogger<RelationController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetRelations")]
        public IEnumerable<Relation> Get()
        {
            return [];
        }
    }
}
