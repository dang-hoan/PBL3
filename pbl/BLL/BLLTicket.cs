using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pbl.DTO;

namespace pbl.BLL
{
    internal class BLLTicket
    {
        private static BLLTicket _instance;
        public static BLLTicket instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLLTicket();
                }
                return _instance;
            }

            private set { }
        }
        private BLLTicket()
        {
        }
        PBL3 db = new PBL3();
        public void delticket(string ticketid)
        {
            TICKET s = db.TICKETs.Find(ticketid);
            db.TICKETs.ToList().Remove(s);
            db.SaveChanges();
        }
        public TICKET Getticketbyticketid(string ticketid)
        {
            return db.TICKETs.Find(ticketid);

        }
    }
}
