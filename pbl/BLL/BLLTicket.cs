using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pbl.DTO;

namespace pbl.BLL
{
    public class BLLTicket
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
        public List<TICKET> getticketbylist(int tranid, string ma)
        {
            PBL3 db = new PBL3();
            var s = ( from t in db.TICKETs.ToList()
                      where ((t.TrainID==tranid)&&(t.SeatNo.IndexOf(ma)!=-1))
                      select t).ToList();
            return s;
        }
     
       
    }
}
