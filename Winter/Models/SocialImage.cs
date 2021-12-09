using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Winter.Models
{
    public class SocialImage
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string SocialsImage { get; set; }
        [NotMapped]
        public IFormFile SocialsImageFile { get; set; }
        [ForeignKey("Social")]
        public int SocialId { get; set; }
        public Social Social { get; set; }

    }
}
