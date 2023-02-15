using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comoon.DTOs
{
    
    public  class UserDTO
    {
        public string UserName { get; set; }    
        public string UserFamilyName { get; set; }  
        public string UserId { get; set; }
        public DateTime UserBirthday { get; set; }
        public string HMO { get; set; }
        public string  Gender { get; set; }
        public List<ChildDTO> ChildrenOfParent { get; set; }


    }
}
