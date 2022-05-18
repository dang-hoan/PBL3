using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbl.DTO;

namespace pbl.BLL
{
    internal class BLLpeople
    {
        private static BLLpeople _instance;
        public static BLLpeople instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLLpeople();
                }
                return _instance;
            }

            private set { }
        }
        private BLLpeople()
            {
            }
        PBL3 db = new PBL3();
        public bool check(string username)
        {
            foreach (PEOPLE i in db.PEOPLE)
            {
                if (i.Username == username) return true;
            }
            return false;
        }
        public void Execute(PEOPLE s)
        {
            if (!check(s.Username))
            {
                db.PEOPLE.Add(s);
                db.SaveChanges();
            }
            else
            {
                PEOPLE temp = db.PEOPLE.Find(s.Username);
                temp.Name = s.Name;
                temp.Gender = s.Gender;
                temp.BirthDay = s.BirthDay;
                temp.Phone = s.Phone;
                temp.Address = s.Address;
                temp.IDCard = s.IDCard;
                temp.Email = s.Email;
                temp.PositionID = "124";
                db.SaveChanges();
            }

        }
        public void Execute2(LOGIN s)
        {
            if (!check(s.Username))
            {
                db.LOGINs.Add(s);
                db.SaveChanges();
            }  
            else
            {
                LOGIN dn = new LOGIN();
                dn = db.LOGINs.Where(p => p.Username != s.Username).Single(); 
               
                dn.Username = s.Username;
                dn.PassWord = s.PassWord;
            }    
        }
        public List<CBBItem> GetCBBs(string txt)
        {
        List<CBBItem> data = new List<CBBItem>();
        foreach (PEOPLE i in db.PEOPLE)
        {
            if (i.PositionID == "124")
            {
                if (i.Name.Contains(txt))
                    data.Add(new CBBItem
                    {
                        Value = i.Username,
                        Text = i.Name

                    });
            }
        }
        return data;
        }
        public List<PEOPLE_View> getppbylist(string username)
        {
            List<PEOPLE_View> data = new List<PEOPLE_View>();
            foreach(PEOPLE i in GetPPByUsername(username))
            {

                data.Add(new PEOPLE_View
                {
                    IDCard = i.IDCard,
                    Name = i.Name,
                    Username = i.Username,
                    Gender = ((bool)i.Gender) ? "Nam" : "Nữ",
                    BirthDay = i.BirthDay.Value,
                    Address = i.Address,
                    Email = i.Email,
                    Phone = i.Phone,
                    Position = i.PositionID,
                }) ;
            }
                return data;
        }
        public List<PEOPLE> GetPPByUsername(string username)
        {
            List<PEOPLE> data = new List<PEOPLE>();
            if (username == "")
            {
                data = db.PEOPLE.Where(p => (p.PositionID=="124")).Select(p => p).ToList();
            }
            else
            {
                data = db.PEOPLE.Where(p => (p.Username== username)&&(p.PositionID=="124")).Select(p => p).ToList();
            }
            return data;
        }
        public void delperson(string username)
        {
            
            MessageBox.Show(username);
            PEOPLE s = db.PEOPLE.Find(username);
            LOGIN dn = new LOGIN();
                dn = db.LOGINs.Where(p => p.Username == username).Single();
           
            db.LOGINs.Remove(dn);
            db.PEOPLE.Remove(s);
            db.SaveChanges();
        }
        public List<PEOPLE> searchP(string text)
        {
            var result = from p in db.PEOPLE where  p.Name.Contains(text)  && p.PositionID == "222"  select p;
            return result.ToList();
        }
        public List<PEOPLE> searchem(string text)
        {
            var result = from p in db.PEOPLE where p.Name.Contains(text) && p.PositionID == "333" select p;
            return result.ToList();
        }
        public PEOPLE GetuserByusername(string username )
        {
            return db.PEOPLE.Find(username);

        }
        public List<employeeview> getallnv(string PositionId)
        {
            List<employeeview> list = new List<employeeview>();
            var l2 = from PEOPLE p in db.PEOPLE.ToList()
                     join POSITION pos in db.POSITIONs on p.PositionID equals pos.PositionID
                     where p.PositionID == PositionId
                     select new employeeview
                     {
                         Name = p.Name,
                         Gender=p.Gender.ToString(),
                         BirthDay=p.BirthDay.Value,
                         Address=p.Address,
                         Email=p.Email,
                            Phone=p.Phone,
                            IDCard=p.IDCard,
                            Position=pos.Position
                     };
          /*  list = db.PEOPLE.Where(p => p.PositionID == PositionId).Select(p => p).ToList();*/

            return l2.ToList();
        }
        public List<PEOPLE> sort()
        {
            List<PEOPLE> list = new List<PEOPLE>();
             
                var result = from p in db.PEOPLE where p.PositionID == "222" orderby p.Name  select p;
                list = result.ToList();                        
            return list;
        }
    }
}
