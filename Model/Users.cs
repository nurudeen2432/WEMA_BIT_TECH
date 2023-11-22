using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIT_TECH_NURUDEEN_DUROWADE.Model.Payments;


namespace BIT_TECH_NURUDEEN_DUROWADE.Model.Users
{
    public class User
    {
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }

        public List<Payment> Payments{ set; get; }



    }
}
