using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonAPI.Data 
{
    public class HonoraryTitle: HonoraryTitleBase
    {

    }

    public class HonoraryTitleBase
    {  
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } = new Guid();
        public string Name { get; set; } = "";
    }
}
