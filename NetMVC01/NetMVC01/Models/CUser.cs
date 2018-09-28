using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NetMVC01.Models
{
    public class CUser
    {
        public int theUniqueID { get; set; }

        [Required(ErrorMessage="아이디를 입력하세요")]
        public string theID { get; set; }//@Override 와 [] 비슷한ㄱ ㅣ능..>?

        [Required(ErrorMessage = "암호를 입력하세요")]
        public string thePW { get; set; }
        
        [Required(ErrorMessage = "이름을 입력하세요")]
        public string theName { get; set; }
        
        [Required(ErrorMessage = "이메일을 입력하세요")]
        [RegularExpression(".\\@.+\\..+", ErrorMessage="정확한 이메일 주소를 입력하세유")]
        public string theEMail { get; set; }
        
        public bool bSubscription { get; set; }

        public DateTime theDate { get; set; }
    }
}