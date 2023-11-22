using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BIT_TECH_NURUDEEN_DUROWADE.Model.Users;



namespace BIT_TECH_NURUDEEN_DUROWADE.Model.Payments
{

    public class Payment
    {
        public int Id { set; get; }
        public int User_id { set; get; }
        public double Paymount_Amount { set; get; }

        public User users { set; get; }

    };

}
