using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoConnectEntity
{
    public class Answers
    {
        [Key]
        public int Aid { get; set; }
        public string answer { get; set; }
        public string Username {  get; set; }
        [ForeignKey("Question")]
        public int Qid {  get; set; }
        public Questions ? questions { get; set; }
        [ForeignKey("Users")]
        public int UserID { get; set; }
        public Users ? User { get; set; }
    }
}
