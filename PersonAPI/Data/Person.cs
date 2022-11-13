using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PersonAPI.Models;

namespace PersonAPI.Data 
{
    public class Person: PersonBase
    {
        public Person() 
        {
            this.Roles = new HashSet<Role>();
            this.Acknowledgements = new HashSet<Acknowledgement>();
        }

        public bool Gender { get; set; } = false;
    }

    public class PersonBase
    {  
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } = new Guid();
        public string FirstNames { get; set; } = "";
        public string LastName { get; set; } = "";
        public DateTime? DateOfBirth { get; set; } = new DateTime(1900, 1, 1);
        public DateTime? DateOfDeath { get; set; } = null;        
        public virtual ICollection<Role>? Roles { get; set; }
        public virtual ICollection<Acknowledgement>? Acknowledgements { get; set; }
        public string? PlaceOfBirth { get; set; }
        public string? Nationality { get; set; }
        public Guid? PlaceOfBirthId { get; set; }
        public Guid? NationalityId { get; set; }

    }
}
