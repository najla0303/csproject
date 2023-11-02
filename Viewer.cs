using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movina
{
    internal class Viewer:User
    {
        private DateTime pymentDueDate;
        private bool ValidSubscription;
        public Subscribtion subscribedFor;

        public DateTime PaymentDue
        {
            get;
            private set;
        }
        public bool ValidSubs
        {
            get;
            private set;
        }
        public Subscribtion SubscribedFor
        {
            get;
            private set;
        }

        public Viewer(string userN, string email, string pass, DateTime pymentDueDate, bool ValidSubscription, Subscribtion subscribedFor):base(userN, email, pass){
            PaymentDue = pymentDueDate;
            ValidSubs = ValidSubscription;
            SubscribedFor = subscribedFor;
        }

        //public OpenWatchList()
        //public OpenToWatchList()
        //public AddMovieToWatchList()
        //public Watch()
        //public Rate()
        //public Pay()
        //public ViewMovieDelails()
        //publoc Search()
        //public ManageSubscribtion()
    }

}
