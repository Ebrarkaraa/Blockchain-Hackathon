using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Ticaret_BlockChain.Entity
{
    public class User
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Surname { get; set; }
        [Required(ErrorMessage ="Bu alanı boş bırakamazsınız")]
        [StringLength(50)]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız")]
        [StringLength(50)]
        public string Password { get; set; }
    }
}