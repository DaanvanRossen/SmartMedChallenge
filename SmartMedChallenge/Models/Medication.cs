using System.ComponentModel.DataAnnotations;

namespace SmartMedChallenge.Models
{
    public class Medication
    {
        public Medication(string name, int quantity, DateTime creationDate)
        {
            Name = name;
            Quantity = quantity;
            CreationDate = creationDate;
        }

        public int id { get; set; }

        public string Name { get; set; }

        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
