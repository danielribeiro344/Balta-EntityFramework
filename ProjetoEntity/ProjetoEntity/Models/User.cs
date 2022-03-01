using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEntity.Models
{
    public class User
    {
        public int Id { get; set;}
        public String Name { get; set; }
        public String Email { get; set; }
        public String MyProperty { get; set; }
        public String PasswordHash { get; set; }
        public String Bio { get; set; }
        public String Image { get; set; }
        public String Slug { get; set; }

    }
}
