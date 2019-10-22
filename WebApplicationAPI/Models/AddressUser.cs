using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationAPI.Models
{
    public class AddressUser
    {
        public long Id { get; set; }

        public long AddressId { get; set; }

        public long UserId { get; set; }
    }
}
