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
        public bool check(string username)
        {
            PBL3 db = new PBL3();
            foreach (PEOPLE i in db.PEOPLE)
            {
                if (i.Username.ToUpper().Equals(username.ToUpper())) return true;
            }
            return false;
        }
        public bool check2(string username)
        {
            PBL3 db = new PBL3();
            foreach (LOGIN i in db.LOGINs)
            {
                if (i.Username.ToUpper() == username.ToUpper()) return true;
            }
            return false;
        }
        public void Getnvbyuser(string username)
        {
            PBL3 db = new PBL3();
            PEOPLE pb = db.PEOPLE.Find(username);
            //POSITION posi =db.POSITIONs.Where(  p => p.PositionID == pb.PositionID);


            MessageBox.Show("HỌ VÀ TÊN : " + pb.Name + "\n"
                + "ĐỊA CHỈ : " + pb.Address + "\n"
                + "EMAIL : " + pb.Email + "\n"
                + "SĐT : " + pb.Phone + "\n"
                + "IDCARD : " + pb.IDCard + "\n",
                // + "POSITION : " + posi.Position + "\n",
                "Thông tin nguười dùng ");
        }
        public List<tkten_view> searchtennv(string ten)
        {
            PBL3 db = new PBL3();
            List<tkten_view> list = new List<tkten_view>();
            int id = Getpidnv();
            int id1 = Getpidkh();
            var result = from p in db.PEOPLE.ToList()
                         where p.Name.Contains(ten) && (p.PositionID == id || p.PositionID == id1)
                         select new tkten_view
                         {
                             Username = p.Username,
                             Name = p.Name
                         };

            return result.ToList();
        }
        public int Getpidnv()
        {
            PBL3 db = new PBL3();
            var p = (from pos in db.POSITIONs
                     where pos.Position == "Nhân viên"
                     select pos.PositionID).FirstOrDefault();
            return p;
        }
        public int Getpidkh()
        {
            PBL3 db = new PBL3();
            var p = (from pos in db.POSITIONs
                     where pos.Position == "Khách hàng"
                     select pos.PositionID).FirstOrDefault();
            return p;
        }
        public void Execute(PEOPLE s)
        {
            PBL3 db = new PBL3();
            s.PositionID = (from pos in db.POSITIONs
                            where pos.Position.Equals("Khách hàng")
                            select pos.PositionID).FirstOrDefault();
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
                temp.PositionID = s.PositionID;
                db.SaveChanges();
            }

        }
        public void UpdateNoLogin(PEOPLE s)
        {
            PBL3 db = new PBL3();
            PEOPLE temp = db.PEOPLE.Find(s.Username);
            temp.Username = s.IDCard;
            temp.Name = s.Name;
            temp.Gender = s.Gender;
            temp.BirthDay = s.BirthDay;
            temp.Phone = s.Phone;
            temp.Address = s.Address;
            temp.IDCard = s.IDCard;
            temp.Email = s.Email;
            db.SaveChanges();
        }
        public void UpdatePeo(PEOPLE s, string IDCard)
        {
            PBL3 db = new PBL3();
            PEOPLE temp = db.PEOPLE.Find(IDCard);
            temp.Username = s.Username;
            temp.Name = s.Name;
            temp.Gender = s.Gender;
            temp.BirthDay = s.BirthDay;
            temp.Phone = s.Phone;
            temp.Address = s.Address;
            temp.IDCard = s.IDCard;
            temp.Email = s.Email;
            db.SaveChanges();
        }
        public void AddLogin(LOGIN log)
        {
            PBL3 db = new PBL3();
            db.LOGINs.Add(log);
        }
        public void Executenv(PEOPLE s)
        {
            PBL3 db = new PBL3();
            s.PositionID = (from POSITION pos in db.POSITIONs
                            where pos.Position.Equals("Nhân viên")
                            select pos.PositionID).FirstOrDefault();
            if (!check(s.Username))
            {
                db.PEOPLE.Add(s);
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
                temp.PositionID = s.PositionID;
                
            }
            db.SaveChanges();

        }
        public void Execute2(LOGIN s)
        {
            PBL3 db = new PBL3();
            if (!check2(s.Username))
            {
                db.LOGINs.Add(s);
                db.SaveChanges();
            }
            else
            {
                LOGIN j = db.LOGINs.Where(p => p.Username == s.Username).Select(p => p).FirstOrDefault();
                j.PassWord = s.PassWord;
                db.SaveChanges();
            }    

        }

        public LOGIN Getloginbyusername(string username)
        {
            PBL3 db = new PBL3();
            return db.LOGINs.Where(p => p.Username == username).Select(p => p).FirstOrDefault();
        }

        public List<CBBpeople> GetCBBs(string txt)
        {
            PBL3 db = new PBL3();
            int positi = (from POSITION pos in db.POSITIONs
                          where pos.Position.Equals("Khách hàng")
                          select pos.PositionID).FirstOrDefault(); ;
        List<CBBpeople> data = new List<CBBpeople>();
        foreach (PEOPLE i in db.PEOPLE)
        {
            if (i.PositionID == positi)
            {
                if (i.Name.Contains(txt))
                    data.Add(new CBBpeople
                    {
                        Value = i.Username,
                        Text = i.Name

                    });
            }
        }
        return data;
        }
        public List<CBBpeople> GetCBBname()
        {
            PBL3 db = new PBL3();
            List<CBBpeople> data = new List<CBBpeople>();
            foreach (PEOPLE i in db.PEOPLE)
            {

                data.Add(new CBBpeople
                {
                    Value = i.Username,
                    Text = i.Name

                });
            }
            return data;
        }
        public List<PEOPLE_View> getppbylist(string username,int s)
        {
            PBL3 db = new PBL3();
            List<PEOPLE_View> data = new List<PEOPLE_View>();
            if (s == 1)//tim kiem theo ten dang nhap
            {
                foreach (PEOPLE_View i in GetPPByUsername(username))
                {
                    
                    data.Add(new PEOPLE_View
                    {
                        IDCard = i.IDCard,
                        Name = i.Name,
                        Username = i.Username,
                        Gender = i.Gender,
                        BirthDay = i.BirthDay,
                        Address = i.Address,
                        Email = i.Email,
                        Phone = i.Phone,
                        Position = i.Position,
                    });
                }
            }
            else
            if (s == 2)//tim kiem theo id
            {
                foreach (PEOPLE_View i in GetPPByid(username))
                {

                    data.Add(new PEOPLE_View
                    {
                        IDCard = i.IDCard,
                        Name = i.Name,
                        Username = i.Username,
                        Gender = i.Gender,
                        BirthDay = i.BirthDay,
                        Address = i.Address,
                        Email = i.Email,
                        Phone = i.Phone,
                        Position = i.Position,
                    });
                }
            }
            else
            if (s == 3)//tim kiem theo ten 
            {
                foreach (PEOPLE_View i in GetPPByname(username))
                {

                    data.Add(new PEOPLE_View
                    {
                        IDCard = i.IDCard,
                        Name = i.Name,
                        Username = i.Username,
                        Gender = i.Gender,
                        BirthDay = i.BirthDay,
                        Address = i.Address,
                        Email = i.Email,
                        Phone = i.Phone,
                        Position = i.Position,
                    });
                }
            }
            return data;
        }

        public List<PEOPLE_View> GetPPByUsername(string username)//tim kiem theo ten dang nhap
        {
            PBL3 db = new PBL3();
            int PositionID = (from pos in db.POSITIONs
                              where pos.Position == "Khách hàng"
                              select pos.PositionID).FirstOrDefault();
            List<PEOPLE_View> data = new List<PEOPLE_View>();
            if (username == "")
            {

                data = (from peo in db.PEOPLE
                       join pos in db.POSITIONs on peo.PositionID equals pos.PositionID
                       where pos.PositionID == PositionID
                       orderby peo.Username
                        select new PEOPLE_View
                       {
                           Username = peo.Username,
                           Name = peo.Name,
                           Gender = ((bool)peo.Gender)?"Nam":"Nữ",
                           BirthDay = (DateTime)peo.BirthDay,
                           Address = peo.Address,
                           IDCard = peo.IDCard,
                           Email = peo.Email,
                           Phone = peo.Phone,
                           Position = pos.Position
                       }).ToList();
            }
            else
            {
                data = (from peo in db.PEOPLE
                        join pos in db.POSITIONs on peo.PositionID equals pos.PositionID
                        where (peo.Username == username) && pos.PositionID == PositionID
                        orderby peo.Username 
                        select new PEOPLE_View
                        {
                            Username = peo.Username,
                            Name = peo.Name,
                            Gender = ((bool)peo.Gender) ? "Nam" : "Nữ",
                            BirthDay = peo.BirthDay,
                            Address = peo.Address,
                            IDCard = peo.IDCard,
                            Email = peo.Email,
                            Phone = peo.Phone,
                            Position = pos.Position
                        }).ToList();
            }
            return data;
        }
        public List<PEOPLE_View> GetPPByname(string name)//theo ten
        {
            PBL3 db = new PBL3();
            int PositionID = (from pos in db.POSITIONs
                              where pos.Position == "Khách hàng"
                              select pos.PositionID).FirstOrDefault();
            List<PEOPLE_View> data = new List<PEOPLE_View>();
         
            
                data = (from peo in db.PEOPLE
                        join pos in db.POSITIONs on peo.PositionID equals pos.PositionID
                        where (peo.Name.IndexOf(name)!= -1)&& pos.PositionID == PositionID
                        orderby peo.Name
                        select new PEOPLE_View
                        {
                            Username = peo.Username,
                            Name = peo.Name,
                            Gender = ((bool)peo.Gender) ? "Nam" : "Nữ",
                            BirthDay = peo.BirthDay,
                            Address = peo.Address,
                            IDCard = peo.IDCard,
                            Email = peo.Email,
                            Phone = peo.Phone,
                            Position = pos.Position
                        }).ToList();
            
            return data;
        }
        public List<PEOPLE_View> GetPPByid(string id)//theo id
        {
            PBL3 db = new PBL3();
            int PositionID = (from pos in db.POSITIONs
                              where pos.Position == "Khách hàng"
                              select pos.PositionID).FirstOrDefault();
            List<PEOPLE_View> data = new List<PEOPLE_View>();


            data = (from peo in db.PEOPLE
                    join pos in db.POSITIONs on peo.PositionID equals pos.PositionID
                    where (peo.IDCard == id) && pos.PositionID == PositionID
                    orderby peo.IDCard
                    select new PEOPLE_View
                    {
                        Username = peo.Username,
                        Name = peo.Name,
                        Gender = ((bool)peo.Gender) ? "Nam" : "Nữ",
                        BirthDay = peo.BirthDay,
                        Address = peo.Address,
                        IDCard = peo.IDCard,
                        Email = peo.Email,
                        Phone = peo.Phone,
                        Position = pos.Position
                    }).ToList();

            return data;
        }
        public void delperson(string username)
        {
            PBL3 db = new PBL3();
            PEOPLE s = db.PEOPLE.Find(username);
            LOGIN dn =  db.LOGINs.Where(p => p.Username == username).FirstOrDefault();
            List<int> list = (from tic in db.TICKETs
                                where tic.CustomerUN.Equals(username)
                                select tic.TicketID).ToList();
            BLLTRAIN.Instance.SetTicket(list, "", false);
            if(dn != null) db.LOGINs.Remove(dn);
            db.PEOPLE.Remove(s);
            db.SaveChanges();
        }
        
        public void delnv(string user)
        {
            PBL3 db = new PBL3();
            PEOPLE s = db.PEOPLE.Find(user);
            LOGIN dn = db.LOGINs.Where(p => p.Username == user).FirstOrDefault();
            if(dn != null) db.LOGINs.Remove(dn);
           
            db.PEOPLE.Remove(s);
            db.SaveChanges();
        }
        public List<employeeview> searchP(string text)
        {
            PBL3 db = new PBL3();
            int id = Getpidnv();
            List<employeeview> list = new List<employeeview>();
            var result = from PEOPLE p in db.PEOPLE.ToList()
                         join POSITION pos in db.POSITIONs on p.PositionID equals pos.PositionID
                         where p.Name.Contains(text) && p.PositionID == id

                         select new employeeview
                         {
                             Username = p.Username,
                             Name = p.Name,
                             Gender = ((bool)p.Gender) ? "Nam" : "Nu",
                             BirthDay = p.BirthDay,
                             Address = p.Address,
                             Email = p.Email,
                             Phone = p.Phone,
                             IDCard = p.IDCard,

                         };
            return result.ToList();
        }
        public List<PEOPLE> searchem(string text)
        {
            PBL3 db = new PBL3();
            if (text == "")
            {
                 MessageBox.Show("Vui lòng nhập tên khách hàng cần tìm !", "Thông báo");
                return null;
            }
            else
            {
                int id = Getpidkh();
                var result = from p in db.PEOPLE where p.Name.Contains(text) && p.PositionID == id select p;
                if(result.Count() == 0 )
                {
                    MessageBox.Show("Không có khách hàng có tên bạn muốn tìm trong hệ thống !", "Thông báo");
                    
                }
               
                 return result.ToList();
              
               
            }
           
        }
        public List<PEOPLE> searchnv(string text)
        {
            PBL3 db = new PBL3();
            if (text == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên cần tìm !", "Thông báo");
                return null;
            }
            else
            {
                int id = Getpidnv();
                var result = from p in db.PEOPLE where p.Name.Contains(text) && p.PositionID == id select p;
                if (result.Count() == 0)
                {
                    MessageBox.Show("Không có nhân viên có tên bạn muốn tìm trong hệ thống !", "Thông báo");

                }

                return result.ToList();


            }

        }
        public LOGIN Getloginbyloginid(string username)
        {
            PBL3 db = new PBL3();
            LOGIN dn = new LOGIN();
            dn = db.LOGINs.Where(p => p.Username == username).FirstOrDefault();
            return dn;

        }
        public PEOPLE GetuserByusername(string username )
        {
            PBL3 db = new PBL3();
            return db.PEOPLE.Find(username);

        }
      
        public List<PEOPLE_View> getallnv(int PositionId)
        {
            PBL3 db = new PBL3();
            List<PEOPLE_View> list = new List<PEOPLE_View>();
            var l2 = from PEOPLE p in db.PEOPLE.ToList()
                     join POSITION pos in db.POSITIONs on p.PositionID equals pos.PositionID
                     where p.PositionID == PositionId
                     select new PEOPLE_View
                     {   
                         Username = p.Username,
                         Name = p.Name,
                         Gender = ((bool)p.Gender) ?  "Nam" : "Nu",
                         BirthDay = p.BirthDay,
                         Address = p.Address,
                         Email = p.Email,
                         Phone = p.Phone,
                         IDCard = p.IDCard,
                         Position = pos.Position
                     };
            /*  list = db.PEOPLE.Where(p => p.PositionID == PositionId).Select(p => p).ToList();*/

            return l2.ToList();
        }
        public List<Nhanvien_view> getallnsv(int PositionId)
        {
            PBL3 db = new PBL3();
            List<Nhanvien_view> list = new List<Nhanvien_view>();
            var l2 = from PEOPLE p in db.PEOPLE.ToList()
                     join POSITION pos in db.POSITIONs on p.PositionID equals pos.PositionID
                     where p.PositionID == PositionId
                     select new Nhanvien_view
                     {
                         Username = p.Username,
                         Name = p.Name,
                         Gender = ((bool)p.Gender) ? "Nam" : "Nu",
                         BirthDay = p.BirthDay.Value.ToString("dd/MM/yyyy"),
                         Address = p.Address,
                         Email = p.Email,
                         Phone = p.Phone,
                         IDCard = p.IDCard,
                         //Position = pos.Position
                     };
            /*  list = db.PEOPLE.Where(p => p.PositionID == PositionId).Select(p => p).ToList();*/

            return l2.ToList();
        }
        public List<PEOPLE> sort()
        {
            PBL3 db = new PBL3();
            List<PEOPLE> list = new List<PEOPLE>();
            int id = Getpidnv();
            var result = from p in db.PEOPLE where p.PositionID == id orderby p.Name  select p;
                list = result.ToList();                        
            return list;
        }
    }
}
