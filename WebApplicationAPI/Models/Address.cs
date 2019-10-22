using System.ComponentModel.DataAnnotations;

namespace WebApplicationAPI.Models
{
    public class Address
    {
        #region MaxLength
        public const int MaxMediumLength = 128;
        public const int MaxSmallLength = 32;
        public const int MaxTextLength = 62;
        #endregion

        public long Id { get; set; }

        [StringLength(MaxMediumLength)]
        public string Street { get; set; }

        [StringLength(MaxSmallLength)]
        public string Number { get; set; }

        [StringLength(MaxTextLength)]
        public string Neighborhood { get; set; }

        [StringLength(MaxTextLength)]
        public string City { get; set; }

        [StringLength(MaxTextLength)]
        public string Country { get; set; }

        [StringLength(MaxSmallLength)]
        public string ZipCode { get; set; }
    }
}
