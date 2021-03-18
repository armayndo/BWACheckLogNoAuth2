using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BWACheckLogNoAuth.Shared.Models
{
    public class UserResponse
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Guid { get; set; }
        public string UserName { get; set; }
        public DateTime DateSubmit { get; set; }
        public string ResponseType { get; set; }

        public ICollection<ResponseDetail> ResponseDetails{ get; set; }

    }
}
