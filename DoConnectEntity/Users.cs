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
        string username {  get; set; }
        string name {  get; set; }
        string password {  get; set; }
        string email {  get; set; }
        long phone {  get; set; }
    }
}
