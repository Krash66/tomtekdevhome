using System.ComponentModel.DataAnnotations;

namespace tomtekdevhome.Models
{
    public class ContactFormModels
    {
        [Required(ErrorMessage = "<h3 style='color:red'>You must provide your Name.</h3>")]
        public string Name { get; set; }

        [Required(ErrorMessage = "<h3 style='color:red'>You must provide your email.</h3>"), EmailAddress]
        [DisplayFormat]
        public string Email { get; set; }

        [Phone]
        [DisplayFormat]
        public string Phone { get; set; }

        [Required(ErrorMessage = "<h3 style='color:red'>You must include a subject.</h3>")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "<h3 style='color:red'>You must include a message.</h3>")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }

    }
}