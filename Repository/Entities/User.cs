using Comoon.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
  
    public  class User
    {
        public int Id { get; set; } 
        public string UserName { get; set; }
        public string UserFamilyName { get; set; }
        public string UserId { get; set; }
        public DateTime UserBirthday { get; set; }
        public string HMO { get; set; }
        public string  Gender { get; set; }
        public List<Child> ChildrenOfParent { get; set; }

    }
}
