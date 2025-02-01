using System.ComponentModel.DataAnnotations.Schema;

namespace BeeFacts.Models
{
    [Table("BeeFact")]
    public class BeeFact
    {
        public int BeeFactId { get; set; } = 0;
        public string Fact { get; set; } = "If you see this fact, something went wrong.";
    }
}
