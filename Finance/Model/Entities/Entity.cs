using System.ComponentModel.DataAnnotations;

namespace Finance_Project.Model.Entities
{
    public abstract class Entity
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
