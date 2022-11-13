using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PersonAPI.Models;

namespace PersonAPI.Data 
{
    public class Role: RoleBase
    {  
        public Role() 
        {
            this.Persons = new HashSet<Person>();
        }
        public virtual ICollection<Person>? Persons { get; set; }
    }

    public class RoleBase
    {  
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } = new Guid();
        public string Name { get; set; } = "";
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public string? Team { get; set; }
        public Guid? TeamId { get; set; }
    }
}
