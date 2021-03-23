using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BWACheckLogNoAuth.Shared.Models
{
    public class ResponseDetail
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Guid UserResponseGuid { get; set; }
        public DateTime ResponseTime { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

        public UserResponse UserResponse { get; set; }
    }
}
