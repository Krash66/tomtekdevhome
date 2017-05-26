using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace tomtekdevhome.Models
{
    public class ContactForm
    {
        [Required(ErrorMessage = "You must provide your name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must provide your email."), EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

        [Required(ErrorMessage ="You must include a subject.")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "You must include a message.")]
        public string Message { get; set; }

    }
}