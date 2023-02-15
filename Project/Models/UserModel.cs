using Comoon.DTOs;
using Repositories.Entities;

namespace _1_UI.Models
{
    public class UserModel
    {
        public string UserName { get; set; }
        public string UserFamilyName { get; set; }
        public string UserId { get; set; }
        public DateTime UserBirthday { get; set; }
        public string HMO { get; set; }
        public string Gender { get; set; }
        public List<ChildDTO> ChildrenOfParent { get; set; }
    }
}
