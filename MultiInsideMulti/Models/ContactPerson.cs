using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiInsideMulti.Models
{
    public class ContactPerson
    {
        public List<Mobile> Mobiles { get; set; }

        public List<Telephone> Telephones { get; set; }

        public List<Email> Emails { get; set; }

    }
}