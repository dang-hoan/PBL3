using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                db.SaveChanges();
            }

        }
        public List<CBBItem> GetCBBs()
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach (PEOPLE i in db.PEOPLE)
            {
                data.Add(new CBBItem
                {
                    Value = int.Parse(i.Username.ToString()),
                    Text = i.Name

                });

            }
            return data;
        }
        public void delperson(string username)
        {
            PEOPLE s = db.PEOPLE.Find(username);
            db.PEOPLE.Remove(s);
            db.SaveChanges();
        }
        public PEOPLE GetuserByusername(string username )
        {
            return db.PEOPLE.Find(username);

        }

    }
}
