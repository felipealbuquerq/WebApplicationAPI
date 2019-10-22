using System.ComponentModel.DataAnnotations;

namespace WebApplicationAPI.Models
{
    public class User
    {
        public const int MaxMediumLength = 128;

        [StringLength(MaxMediumLength)]
        public long Id { get; set; }

        [StringLength(MaxMediumLength)]
        public string Name { get; set; }

        [StringLength(MaxMediumLength)]
        public string UserName { get; set; }

        [StringLength(MaxMediumLength)]
        public string Passowrd { get; set; }
    }
}
