using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoConnectEntity
{
    public class Users
    {
        [Key]
        public int id { get; set; }
        public string ? FirstName {  get; set; }
        public string ? LastName { get; set; }
        public string? username {  get; set; }
        public string email {  get; set; }
        public string password {  get; set; }
        public long ? phone {  get; set; }
    }
}
