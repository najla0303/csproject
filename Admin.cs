using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movina
{
    internal class Admin : User
    {
        private int id;
        public int ID
        {
            get;
            private set;
        }

        public Admin(string userN, string email, string pass, int id):base(userN, email, pass)
        {
            ID = id;
        }

        //public FreezeAccount()
        //public TrackSubscribtions()
        //public EditMoieDetails()
        //public DeleteMovie()
        //public AddMovie()
    }
}
