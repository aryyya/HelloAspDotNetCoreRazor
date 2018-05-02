using System.ComponentModel.DataAnnotations;

namespace HelloAspDotNetCoreRazor
{
    public class Customer
    {
        public int Id { get; set; }

        [Required, StringLength(64)]
        public string Name { get; set; }

        [Required, StringLength(64)]
        public string Email { get; set; }

        [Required]
        public int BirthYear { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Email: {Email}, BirthYear: {BirthYear}";
        }
    }
}
