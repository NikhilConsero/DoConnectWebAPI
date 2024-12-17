using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoConnectEntity
{
    public class Questions
    {
        [Key]
        public int Qid {  get; set; }
        public string topicname {  get; set; }
        public string question {  get; set; }
        public string username {  get; set; }
        [ForeignKey("UserID")]
        public int UserId { get; set; }
        public string approved { get; set; }   
        public Users ? user { get; set; }
    }
}
