namespace FamilyTree.Models
{
    public class Relation
    {
        public int Id { get; set; }

        public RelationType RelationType { get; set; }

        public int Person1 { get; set; }

        public int Person2 { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}
