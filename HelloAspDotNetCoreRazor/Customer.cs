using System.ComponentModel.DataAnnotations;

namespace HelloAspDotNetCoreRazor
{
    public class Customer
    {
        public int Id { get; set; }

        [Required, StringLength(64)]
        public string Name { get; set; }
    }
}
