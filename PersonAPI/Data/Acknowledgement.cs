using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonAPI.Data 
{
    public class Acknowledgement: AcknowledgementBase
    {
        public Person Person { get; set; } = default!;
    }

    public class AcknowledgementBase
    {  
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } = new Guid();
        public HonoraryTitle Title { get; set; } = default!;
        public DateTime? Date { get; set; }
    }
}
