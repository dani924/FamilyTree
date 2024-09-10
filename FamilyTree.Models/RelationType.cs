using FamilyTree.Models.Enums;

namespace FamilyTree.Models
{
    public class RelationType
    {
        public int Id { get; set; }

        public ERelationType Code { get; set; }

        public string Description { get; set; }
    }
}
