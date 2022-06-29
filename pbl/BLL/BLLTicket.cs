using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public List<TICKET> getticketbylist(int scheduleid, int trainid, string matoa)
        {
            PBL3 db = new PBL3();
            var s = ( from t in db.TICKETs.ToList()
                      where (t.ScheduleID==scheduleid && (t.TrainID==trainid)&&(t.SeatNo.ToUpper().Contains(matoa)))
                      select t).ToList();
            return s;
        }
        public TICKET GetTicket(int scheduleid, int trainid, string matoa)
        {
            PBL3 db = new PBL3();
            var s = ( from t in db.TICKETs.ToList()
                      where (t.ScheduleID==scheduleid && (t.TrainID==trainid)&&(t.SeatNo.ToUpper().Equals(matoa)))
                      select t).FirstOrDefault();
            return s;
        }
     
       
    }
}
