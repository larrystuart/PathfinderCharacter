using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PathfinderCharacter.Models
{
    public class User
    {
        public User()
        {
            UserCharacters = new List<Character>();
        }
        public Guid Id { get; set; }
        public List<Character> UserCharacters { get; set; }
        public string AuthenticationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
