using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbl.BLL;
using pbl.DTO;
using COMExcel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Drawing;
using Bunifu.Framework.UI;

namespace pbl.BLL
{
    public class BLLTRAIN
    {
        private static BLLTRAIN _Instance;
        public static BLLTRAIN Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLLTRAIN();
                }
                return _Instance;
            }
            private set { }
        }
        private BLLTRAIN()
        {

        }
        private char[] carriage = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        //Đọc ghi file
        private string Edit(string s, int total)
        {
            int x = (total - s.Length) / 2;
            string result = "", temp = "";
            for (int i = 0; i < x; i++) temp += ' ';
            result += temp + s + temp;
            if ((total - s.Length) % 2 == 1) result += ' ';
            return result;
        }
        public void AddListTicket(TRIP trip)
        {
            PBL3 db = new PBL3();
            int NumberOfCarriages = (from tra in db.TRAINs
                                     where tra.TrainID == trip.TrainID
                                     select tra.NumberOfCarriages).FirstOrDefault();
            for (int i = 0; i < NumberOfCarriages; i++)
            {
                for (int j = 1; j <= 30; j++)
                {
                    db.TICKETs.Add(new TICKET
                    {
                        ScheduleID = trip.ScheduleID,
                        TrainID = trip.TrainID,
                        SeatNo = carriage[i].ToString().ToUpper() + j.ToString(),
                        TicketPrice = (decimal)(Convert.ToDouble(trip.BasicPrice) * (0.1 * i + 1)),
                        Booked = false
                    });
                }
            }
            db.SaveChanges();
        }
        public void Print(DataGridView dataGridView1, int[] numberChar,string header)
        {
            string path = null;
            OpenFileDialog o = new OpenFileDialog();
            o.InitialDirectory = "c:\\";
            //o.Multiselect = true;
            o.Filter = "Doc files|*.docx|Text files(*.txt)|*.txt|Excel files|*.xls|Excel files|*.xlsx|All files(*.*)|*.*";
            o.FilterIndex = 5;

            DialogResult dialog = o.ShowDialog();
            if (dialog == DialogResult.Cancel) return;
            path = o.FileName;
            switch (Path.GetExtension(o.FileName))
            {
                case ".docx":
                    {
                        break;
                    }
                case ".txt":
                    {
                        int sum = 0;
                        foreach (int i in numberChar) sum += i;

                        using (StreamWriter sw = new StreamWriter(path))
                        {
                            for (int k = 0; k < sum + dataGridView1.Columns.Count + 1; k++) sw.Write('-');
                            sw.WriteLine();
                            for (int i = 0; i < dataGridView1.Columns.Count; i++) sw.Write("|" + Edit(dataGridView1.Columns[i].HeaderText, numberChar[i]));
                            sw.Write("|\n");
                            foreach (DataGridViewRow dr in dataGridView1.Rows)
                            {
                                for (int k = 0; k < sum + dataGridView1.Columns.Count + 1; k++) sw.Write('-');
                                sw.WriteLine();
                                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                                {
                                    sw.Write("|" + Edit(dr.Cells[i].Value.ToString(), numberChar[i]));
                                }
                                sw.Write("|\n");
                            }
                            for (int k = 0; k < sum + dataGridView1.Columns.Count + 1; k++) sw.Write('-');
                            MessageBox.Show("Đã xuất dữ liệu ra file bạn chọn!");
                        }
                        break;
                    }
                case ".xls":
                case ".xlsx":
                    {
                        //Đóng file excel có path đang mở
                        //COMExcel.Application App = new COMExcel.Application();
                        //Workbook Book = App.Workbooks.Add(path);
                        //Book.Save();
                        //Book.Close(true);
                        //App.Quit();
                        //System.Runtime.InteropServices.Marshal.ReleaseComObject(App);

                        // Khởi động chtr Excell
                        COMExcel.Application exApp = new COMExcel.Application();

                        //// Thêm file temp xls
                        //Workbook exBook = exApp.Workbooks.Add(
                        //          COMExcel.XlWBATemplate.xlWBATWorksheet);

                        // Mở 1 file temp xlsx
                        object misValue = System.Reflection.Missing.Value;
                        Workbook exBook = exApp.Workbooks.Add(misValue);
                        // Lấy sheet 1.
                        Worksheet exSheet = (Worksheet)exBook.Worksheets[1];
                        exSheet.Activate();
                        exSheet.Name = header.Replace(' ', '_');

                        //Ghi dữ liệu
                        //Ghi tiêu đề
                        Range r_Header = exSheet.get_Range("A1", carriage[dataGridView1.Columns.Count].ToString() + "1");
                        r_Header.Merge();
                        r_Header.Font.Size = 18;
                        r_Header.Font.Name = "Times New Roman";
                        r_Header.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        r_Header.Value2 = header;
                        //Tô màu cho tiêu đề
                        r_Header.Interior.Color = ColorTranslator.ToOle(System.Drawing.ColorTranslator.FromHtml("#548235"));
                        r_Header.Font.Bold = true;
                        r_Header.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);

                        //Tạo các tên cột
                        //Tạo Ô Số Thứ Tự (STT)
                        Range r_STT = exSheet.Cells[2, 1];//Cột A dòng 2
                        r_STT.Font.Size = 14;
                        r_STT.Font.Bold = true;
                        r_STT.Font.Name = "Times New Roman";
                        r_STT.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        r_STT.Value2 = "STT";
                        //Tô màu
                        r_STT.Interior.Color = ColorTranslator.ToOle(System.Drawing.ColorTranslator.FromHtml("#A9D08E"));
                        //Tạo các tên cột còn lại theo bảng DataGridView
                        List <dynamic> arrColumn = new List<dynamic>();
                        foreach (DataGridViewColumn dc in dataGridView1.Columns)
                        {
                            arrColumn.Add(dc.HeaderText.ToString());
                        }
                        Range column = exSheet.get_Range("B2", carriage[dataGridView1.Columns.Count].ToString() + "2");
                        column.Font.Size = 14;
                        column.Font.Bold = true;
                        column.Font.Name = "Times New Roman";
                        column.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        column.Value2 = arrColumn.ToArray();
                        column.ColumnWidth = 25;
                        column.Interior.Color = ColorTranslator.ToOle(System.Drawing.ColorTranslator.FromHtml("#A9D08E"));

                        //Ghi dữ liệu
                        int stt = 0;
                        int row = 2;
                        foreach (DataGridViewRow dr in dataGridView1.Rows)
                        {
                            stt++;
                            row++;
                            List<dynamic> arr = new List<dynamic>();
                            arr.Add(stt);
                            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                            {
                                arr.Add(dr.Cells[i].Value.ToString());
                            }
                            Range rowData = exSheet.get_Range("A" + row, carriage[dataGridView1.Columns.Count].ToString() + row);//Lấy dòng thứ row ra để đổ dữ liệu
                            rowData.Font.Size = 12;
                            rowData.Font.Name = "Times New Roman";
                            rowData.Value2 = arr.ToArray();
                            rowData.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                            rowData.Interior.Color = ColorTranslator.ToOle(System.Drawing.ColorTranslator.FromHtml("#E2EFDA"));
                        }

                        //Thêm đường viền
                        //Trái, phải, dọc, ngang
                        Range range = exSheet.get_Range("a1", carriage[dataGridView1.Columns.Count].ToString() + row);
                        range.Borders.get_Item(COMExcel.XlBordersIndex.xlEdgeLeft).LineStyle = COMExcel.XlLineStyle.xlContinuous;
                        range.Borders.get_Item(COMExcel.XlBordersIndex.xlEdgeRight).LineStyle = COMExcel.XlLineStyle.xlContinuous;
                        range.Borders.get_Item(COMExcel.XlBordersIndex.xlEdgeTop).LineStyle = COMExcel.XlLineStyle.xlContinuous;
                        range.Borders.get_Item(COMExcel.XlBordersIndex.xlEdgeBottom).LineStyle = COMExcel.XlLineStyle.xlContinuous;
                        range.Borders.get_Item(COMExcel.XlBordersIndex.xlInsideHorizontal).LineStyle = COMExcel.XlLineStyle.xlContinuous;
                        range.Borders.get_Item(COMExcel.XlBordersIndex.xlInsideVertical).LineStyle = COMExcel.XlLineStyle.xlContinuous;

                        //// Hiển thị chương trình excel
                        //exApp.Visible = true;

                        ////Ghi ra 1 khối
                        //COMExcel.Range r = (COMExcel.Range)exSheet.get_Range("A1", "A4");
                        //r.Value2 = "my value";
                        //r.Columns.AutoFit();

                        // Ẩn chương trình
                        //exApp.Visible = false;

                        try
                        {
                            // Save file
                            exBook.SaveAs(path);

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Chúng tôi không thể lưu vào file bạn chọn vì nó đang được mở!");
                            return;
                        }

                        // Đóng chương trình
                        exBook.Close(true, misValue, misValue);
                        // Thoát và thu hồi bộ nhớ cho COM
                        exApp.Quit();
                        releaseObject(exSheet);
                        releaseObject(exBook);
                        releaseObject(exApp);
                        break;
                    }
            }
        }

        //Hàm thu hồi bộ nhớ cho COM Excel
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                obj = null;
            }
            finally
            { GC.Collect(); }
        }
        //Chung
        public bool check(string username)
        {
            PBL3 db = new PBL3();
            foreach (PEOPLE i in db.PEOPLE)
            {
                if (i.Username.ToUpper() == username.ToUpper()) return true;
            }
            return false;
        }
        public bool checkseat(int scheduleid, string maghe, int trainid)
        {   //idlcih
            //idtau
            //mave
            PBL3 db = new PBL3();
            var result = (from tic in db.TICKETs                          
                          where tic.TRIP.SCHEDULE.ScheduleID == scheduleid && tic.TRIP.TRAIN.TrainID == trainid && tic.SeatNo == maghe
                          select tic).FirstOrDefault();
            if (result != null) return true;
            else return false;
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
        public bool CheckTrip(int ScheduleID, int TrainID)
        {
            PBL3 db = new PBL3();
            var data = (from tri in db.TRIPs
                        where tri.ScheduleID == ScheduleID && tri.TrainID == TrainID
                        select tri).FirstOrDefault();
            if (data != null) return true;
            return false;
        }
        public bool CheckSchedule(SCHEDULE s)
        {
            PBL3 db = new PBL3();
            var data = (from sch in db.SCHEDULEs.ToList()
                        where sch.DepartureID == s.DepartureID && sch.ArrivalID == s.ArrivalID
                        && sch.DepartureTime.ToString("dd/MM/yyyy HH:mm").CompareTo(s.DepartureTime.ToString("dd/MM/yyyy HH:mm")) == 0 
                        && sch.ArrivalTime.ToString("dd/MM/yyyy HH:mm").CompareTo(s.ArrivalTime.ToString("dd/MM/yyyy HH:mm")) == 0
                        select sch).FirstOrDefault();
            if (data != null) return true;
            return false;
        }
        public PEOPLE CheckIDCard(string IDCard)
        {
            PBL3 db = new PBL3();
            return (from peo in db.PEOPLE
                    where peo.IDCard.Equals(IDCard)
                    select peo).FirstOrDefault();
        }
        public bool CheckIDCard2(string userName, string IDCard)
        {
            bool user;
            if (userName == "") user = true;
            else user = false;
            PBL3 db = new PBL3();
            var data = (from peo in db.PEOPLE
                        where peo.IDCard.Equals(IDCard) && (user || !peo.Username.ToUpper().Equals(userName.ToUpper()))
                        select peo).FirstOrDefault();
            if (data != null) return true;
            return false;
        }
        public bool CheckPhone(string userName, string Phone)
        {
            bool user;
            if (userName == "") user = true;
            else user = false;
            PBL3 db = new PBL3();
            var data = (from peo in db.PEOPLE
                        where peo.Phone.Equals(Phone) && (user || !peo.Username.ToUpper().Equals(userName.ToUpper()))
                        select peo).FirstOrDefault();
            if (data != null) return true;
            return false;
        }
        public bool CheckEmail(string userName, string Email)
        {
            bool user;
            if (userName == "") user = true;
            else user = false;
            PBL3 db = new PBL3();
            var data = (from peo in db.PEOPLE
                       where peo.Email.Equals(Email) && (user || !peo.Username.ToUpper().Equals(userName.ToUpper()))
                        select peo).FirstOrDefault();
            if (data != null) return true;
            return false;
        }
        public void AddPassenger(PEOPLE s)
        {
            PBL3 db = new PBL3();
            s.PositionID = (from pos in db.POSITIONs
                     where pos.Position == "Khách hàng"
                     select pos.PositionID).FirstOrDefault();
            db.PEOPLE.Add(s);
            db.SaveChanges();
        }

        public void AddLogin(LOGIN s)
        {
            PBL3 db = new PBL3();
            db.LOGINs.Add(s);
            db.SaveChanges();
        }
        public void Execute(SCHEDULE s)
        {
            PBL3 db = new PBL3();
            if (s.ScheduleID == -1)
            {
                db.SCHEDULEs.Add(s);
                db.SaveChanges();
            }
            else
            {
                SCHEDULE tep = db.SCHEDULEs.Find(s.ScheduleID);
                tep.DepartureID = s.DepartureID;
                tep.ArrivalID = s.ArrivalID;
                tep.DepartureTime = s.DepartureTime;
                tep.ArrivalTime = s.ArrivalTime;
                db.SaveChanges();
            }

        }    
        public void AddNotice(NOTICE notice)
        {
            PBL3 db = new PBL3();
            db.NOTICEs.Add(notice);
            db.SaveChanges();
        }
        public void Executep(SCHEDULE s)
        {
            PBL3 db = new PBL3();

            db.SCHEDULEs.Add(s);
            db.SaveChanges();

        }

        public PEOPLE GetuserByusername(string username)
        {
            PBL3 db = new PBL3();
            return db.PEOPLE.Find(username);

        }
        public string CheckAccount(string Username, string Password)
        {
            PBL3 db = new PBL3();
            var result = (from log in db.LOGINs
                         join pos in db.POSITIONs on log.Person.PositionID equals pos.PositionID
                         where log.Username.Equals(Username) && log.PassWord.Equals(Password)
                         select pos.Position).FirstOrDefault();
            if (result != null) return result;
            return "Không tồn tại";
        }
        public void UpdatePEOPLE(PEOPLE p)
        {
            PBL3 db = new PBL3();
            PEOPLE peo = db.PEOPLE.Find(p.Username);
            peo.Name = p.Name;
            peo.Gender = p.Gender;
            peo.BirthDay = p.BirthDay;
            peo.Address = p.Address;
            peo.IDCard = p.IDCard;
            peo.Email = p.Email;
            peo.Phone = p.Phone;
            db.SaveChanges();
        }
        public bool UpdatePass(string userName, string oldPassword, string newPassword)
        {
            PBL3 db = new PBL3();
            LOGIN l = (from log in db.LOGINs
                       where log.Username.Equals(userName) && log.PassWord.Equals(oldPassword)
                       select log).FirstOrDefault();
            if (l == null) return false;
            else
            {
                l.PassWord = newPassword;
                db.SaveChanges();
                return true;
            }
        }
        public void UpdatePassByForget(string userName, string newPassword)
        {
            PBL3 db = new PBL3();
            LOGIN l = (from log in db.LOGINs
                       where log.Username.Equals(userName)
                       select log).FirstOrDefault();
            if (l == null) MessageBox.Show("Null");
            l.PassWord = newPassword;
            db.SaveChanges();
        }
        public bool CheckSecurity(string userName, string question, string answer)
        {
            PBL3 db = new PBL3();
            SECURITY s = (from sec in db.SECURITies
                          where sec.OwnUN.Equals(userName) && sec.Question.Equals(question) && sec.Answer.Equals(answer)
                          select sec).FirstOrDefault();
            if (s == null) return false;
            return true;
        }
        public List<SECURITY> GetQuestionSecurity(string userName)
        {
            PBL3 db = new PBL3();
            var result = from sec in db.SECURITies
                         where sec.OwnUN.Equals(userName)
                         select sec;
            return result.ToList();
        }
        public List<string> GetQuestionSecurity2(string userName)
        {
            PBL3 db = new PBL3();
            var result = from sec in db.SECURITies
                         where sec.OwnUN.Equals(userName)
                         select sec.Question;
            return result.ToList().Distinct().ToList();
        }
        public string GetAnswerSecurity(string userName, int secID)
        {
            PBL3 db = new PBL3();
            var result = from sec in db.SECURITies
                         where sec.OwnUN.Equals(userName) && sec.SecurityID == secID
                         select sec.Answer;
            return result.ToList().FirstOrDefault();
        }

        public void AddSecurity(List<SECURITY> list)
        {
            PBL3 db = new PBL3();
            db.SECURITies.AddRange(list.ToArray());
            db.SaveChanges();
        }
        public void DelSecurity(int SecurityID)
        {
            PBL3 db = new PBL3();
            SECURITY s = db.SECURITies.Find(SecurityID);
            db.SECURITies.Remove(s);
            db.SaveChanges();
        }
        public void UpdateSecurity(string userName, int secID, string newAnswer)
        {
            PBL3 db = new PBL3();
            SECURITY s = (from sec in db.SECURITies
                          where sec.OwnUN.Equals(userName) && sec.SecurityID == secID
                          select sec).FirstOrDefault();
            s.Answer = newAnswer;
            db.SaveChanges();
        }
        public void DeleteSchedule(int ScheduleID)
        {
            PBL3 db = new PBL3();
            var data = from tic in db.TICKETs
                       where tic.ScheduleID == ScheduleID
                       select tic;
            db.TICKETs.RemoveRange(data);
            var data2 = from t in db.TRIPs
                        where t.ScheduleID == ScheduleID
                        select t;
            db.TRIPs.RemoveRange(data2);
            db.SCHEDULEs.Remove(db.SCHEDULEs.Find(ScheduleID));
            db.SaveChanges();
        }
        public void DeleteTrip(int ScheduleID, int TrainID)
        {
            PBL3 db = new PBL3();
            var data = from tic in db.TICKETs
                       where tic.ScheduleID == ScheduleID && tic.TrainID == TrainID
                       select tic;
            db.TICKETs.RemoveRange(data);
            db.TRIPs.Remove(db.TRIPs.Find(ScheduleID, TrainID));
            db.SaveChanges();
        }
        public List<SCHEDULE_View> GetSchedulead(string DepartureTime, string ArrivalTime, string Dep, string Des)
        {
            PBL3 db = new PBL3();

            var result = from sch in db.SCHEDULEs.ToList()
                         where
                               DepartureTime.Contains(sch.DepartureTime.ToString("d/M/yyyy"))
                               && ArrivalTime.Contains(sch.ArrivalTime.ToString("d/M/yyyy"))
                               && sch.STATION1.StationName == Dep && sch.STATION.StationName == Des

                         select new SCHEDULE_View
                         {
                             ScheduleID = sch.ScheduleID,
                             Departure = sch.STATION1.StationName,
                             Destination = sch.STATION.StationName,
                             DepartureTime = sch.DepartureTime.ToString(),
                             ArrivalTime = sch.ArrivalTime.ToString()
                         };
            return result.ToList();
        }
        public List<TICKET_User_View> Sort(List<TICKET_User_View> list, int column, bool order)
        {
            switch (column)
            {
                case 0:
                    {
                        if(order) return list.OrderBy(u => u.ScheduleID).ToList();
                        else return list.OrderByDescending(u => u.ScheduleID).ToList();
                    }

                case 1:
                    {
                        if (order) return list.OrderBy(u => u.TrainID).ToList();
                        else return list.OrderByDescending(u => u.TrainID).ToList();
                    }
                case 2:
                    {
                        if (order) return list.OrderBy(u => u.TrainName).ToList();
                        else return list.OrderByDescending(u => u.TrainName).ToList();
                    }
                case 3:
                    {
                        if (order) return list.OrderBy(u => u.TicketID).ToList();
                        else return list.OrderByDescending(u => u.TicketID).ToList();
                    }
                case 4:
                    {
                        if (order) return list.OrderBy(u => u.SeatNo).ToList();
                        else return list.OrderByDescending(u => u.SeatNo).ToList();
                    }
                case 5:
                    {
                        if (order) return list.OrderBy(u => u.TicketPrice).ToList();
                        else return list.OrderByDescending(u => u.TicketPrice).ToList();
                    }
                case 6:
                    {
                        if (order) return list.OrderBy(u => u.Departure).ToList();
                        else return list.OrderByDescending(u => u.Departure).ToList();
                    }
                case 7:
                    {
                        if (order) return list.OrderBy(u => u.Destination).ToList();
                        else return list.OrderByDescending(u => u.Destination).ToList();
                    }
                case 8:
                    {
                        if (order) return list.OrderBy(u => u.DepartureTime).ToList();
                        else return list.OrderByDescending(u => u.DepartureTime).ToList();
                    }
                case 9:
                    {
                        if (order) return list.OrderBy(u => u.ArrivalTime).ToList();
                        else return list.OrderByDescending(u => u.ArrivalTime).ToList();
                    }
            }
            return null;
        }

        public List<TICKET_View> GetAllTICKETView()
        {
            PBL3 db = new PBL3();
            var result = from tic in db.TICKETs
                         join peo in db.PEOPLE on tic.CustomerUN equals peo.Username into TIC_PEO_Group
                         from ticpeo in TIC_PEO_Group.DefaultIfEmpty()
                         select new TICKET_View
                         {
                             ScheduleID = tic.TRIP.ScheduleID,
                             TrainID = tic.TRIP.TrainID,
                             TrainName = tic.TRIP.TRAIN.TrainName,
                             TicketID = tic.TicketID,
                             SeatNo = tic.SeatNo,
                             TicketPrice = (double)tic.TicketPrice,
                             Departure = tic.TRIP.SCHEDULE.STATION1.StationName,
                             Destination = tic.TRIP.SCHEDULE.STATION.StationName,
                             DepartureTime = tic.TRIP.SCHEDULE.DepartureTime,
                             ArrivalTime = tic.TRIP.SCHEDULE.ArrivalTime,
                             Booked = (bool)tic.Booked ? "đã đặt" : "chưa đặt",
                             OwnUsername = (ticpeo == null) ? "" : tic.CustomerUN,
                             OwnName = (ticpeo == null) ? "" : ticpeo.Name
                         };
            return result.ToList();
        }
        public List<PEOPLE_View> GetAllPEOPLEView()
        {
            PBL3 db = new PBL3();
            var result = from peo in db.PEOPLE
                         select new PEOPLE_View
                         {
                             Username = peo.Username,
                             Name = peo.Name,
                             Gender = ((bool)peo.Gender) ? "Nam" : "Nữ",
                             BirthDay = (peo.BirthDay == null) ? DateTime.Now : peo.BirthDay,
                             Address = peo.Address,
                             IDCard = peo.IDCard,
                             Email = peo.Email,
                             Phone = peo.Phone,
                             Position = peo.POSITION.Position
                         };
            return result.ToList();
        }
        public List<PEOPLE_View> GetPEOPLEViewByUsername(string Username)
        {
            PBL3 db = new PBL3();
            List<PEOPLE_View> data = new List<PEOPLE_View>();
            if (Username == "")
            {
                data = BLLTRAIN.Instance.GetAllPEOPLEView();
            }
            else
            {
                foreach (PEOPLE_View i in BLLTRAIN.Instance.GetAllPEOPLEView())
                {
                    if (i.Username.ToUpper().Equals(Username.ToUpper()))
                    {
                        data.Add(i);
                        break;
                    }
                }
            }
            return data;
        }
        public List<CBBSchedule> Getstation()
        {
            PBL3 db = new PBL3();
            var result = (from sta in db.STATIONs.ToList()
                         select new CBBSchedule{
                             Value = sta.StationID,
                             Text = sta.StationName }).ToList();
            return result;
        }
        public void GetStation(ref List<CBBSchedule> cbbDep, ref List<CBBSchedule> cbbDes)
        {
            PBL3 db = new PBL3();
            cbbDep = (from sch in db.SCHEDULEs.ToList()
                      select new CBBSchedule
                      {
                          Value = sch.DepartureID,
                          Text = sch.STATION1.StationName
                      }).GroupBy(x => x.Value).Select(y => y.FirstOrDefault()).ToList();
            cbbDes = (from sch in db.SCHEDULEs.ToList()
                      select new CBBSchedule
                      {
                          Value = sch.ArrivalID,
                          Text = sch.STATION.StationName
                      }).GroupBy(x => x.Value).Select(y => y.FirstOrDefault()).ToList();
        }
        //Đặt tiêu đề cho DataGridView
        private string[] TicketView = { "Mã lịch trình", "Mã tàu", "Tên tàu", "Mã vé", "Số ghế", "Giá vé"
                , "Ga đi", "Ga đến", "Thời gian đi", "Thời gian đến", "Trạng thái", "Tên đăng nhập chủ", "Tên chủ"};
        private string[] PeopleView = { "Tên đăng nhập", "Họ và tên", "Giới tính", "Ngày sinh", "Địa chỉ", "Số CCCD"
                , "Email", "Số điện thoại", "Vị trí"};
        private string[] ScheduleView = { "Mã lịch trình", "Ga đi", "Ga đến", "Thời gian đi", "Thời gian đến" };
        private string[] TurnOverView = { "Mã tàu", "Tên tàu", "Ga đi", "Ga đến", "Thời gian đi","Thời gian đến",
                "Tổng số vé đã bán", "Tổng tiền thu được"};
        private string[] TrainView = { "Mã lịch trình", "Mã tàu", "Tên tàu","Số toa", "Tên đăng nhập lái tàu", "Giá cơ bản", "Trạng thái" };
        public void SetTicketUserView(DataGridView d)
        {
            for(int i = 0; i < TicketView.Length - 3; i++) d.Columns[i].HeaderText = TicketView[i];
        }
        public void SetTicketView(DataGridView d)
        {
            for(int i = 0; i < TicketView.Length; i++) d.Columns[i].HeaderText = TicketView[i];
        }
        public void SetPeopleView(DataGridView d)
        {
            for(int i = 0; i < PeopleView.Length; i++) d.Columns[i].HeaderText = PeopleView[i];
        }
        public void SetScheduleView(DataGridView d)
        {
            for(int i = 0; i < ScheduleView.Length; i++) d.Columns[i].HeaderText = ScheduleView[i];
        }
        public void SetTurnOverView(DataGridView d)
        {
            for(int i = 0; i < TurnOverView.Length; i++) d.Columns[i].HeaderText = TurnOverView[i];
        }
        public void SetTrainView(DataGridView d)
        {
            for(int i = 0; i < TrainView.Length; i++) d.Columns[i].HeaderText = TrainView[i];
        }


        //Passenger
        public string GetName(string Username)
        {
            PBL3 db = new PBL3();
            var result = from peo in db.PEOPLE
                         where peo.Username.Equals(Username)
                         select peo.Name;
            return result.FirstOrDefault();
        }
        public List<TICKET_User_View> GetTicket(string userName)
        {
            PBL3 db = new PBL3();
            var result = from tic in db.TICKETs
                         where tic.CustomerUN == userName
                         select new TICKET_User_View
                         {
                             ScheduleID = tic.TRIP.SCHEDULE.ScheduleID,
                             TrainID = tic.TRIP.TRAIN.TrainID,
                             TrainName = tic.TRIP.TRAIN.TrainName,
                             TicketID = tic.TicketID,
                             SeatNo = tic.SeatNo,
                             TicketPrice = (double)tic.TicketPrice,
                             Departure = tic.TRIP.SCHEDULE.STATION1.StationName,
                             Destination = tic.TRIP.SCHEDULE.STATION.StationName,
                             DepartureTime = tic.TRIP.SCHEDULE.DepartureTime,
                             ArrivalTime = tic.TRIP.SCHEDULE.ArrivalTime
                         };
            return result.ToList();
        }
        public List<doanhthu_view> dthu(int month,int year)
        {
            PBL3 db = new PBL3();
            int numberTicket = 0; double Totalmoney = 0;
            List<doanhthu_view> list = new List<doanhthu_view>();
            foreach(SCHEDULE s in db.SCHEDULEs)
            {
                if(s.DepartureTime.ToString("dd/MM/yyyy HH:mm:ss").Contains(month + "/" + year))
                {
                    foreach(TRIP tri in s.TRIPs)
                    {
                        numberTicket = 0;
                        Totalmoney = 0;
                        foreach (TICKET ti in db.TICKETs)
                        {
                            if (ti.TrainID == tri.TRAIN.TrainID)
                            {
                                if (ti.Booked == true)
                                {
                                    numberTicket++;
                                    Totalmoney += Convert.ToDouble(ti.TicketPrice);

                                }

                            }
                        }
                        list.Add(new doanhthu_view
                        {
                            ScheduleID = tri.ScheduleID,
                            TrainID = tri.TrainID,
                            TrainName = tri.TRAIN.TrainName,
                            Depature = s.STATION1.StationName,
                            Destination = s.STATION.StationName,
                            DepartureTime = s.DepartureTime,
                            ArrivalTime = s.ArrivalTime,
                            TotalTickets = numberTicket,
                            Totalmoney = Totalmoney
                        });
                    }
                }
                
            }
            return list;
        }
        public List<TICKET_User_View> GetTicket(SCHEDULE_View schedule, string userName, string TrainName)
        {
            PBL3 db = new PBL3();
            bool Dep = false, Des = false, Train = false;
            if (schedule.Departure == "") Dep = true;
            if (TrainName == "") Train = true;
            var result = from tic in db.TICKETs
                         where (Dep || tic.TRIP.SCHEDULE.STATION1.StationName.Equals(schedule.Departure)) && (Des || tic.TRIP.SCHEDULE.STATION.StationName.Equals(schedule.Destination))
                               && tic.TRIP.SCHEDULE.DepartureTime.ToString("dd/MM/yyyy H:m:s").Contains(schedule.DepartureTime)
                               && tic.TRIP.SCHEDULE.ArrivalTime.ToString("dd/MM/yyyy H:m:s").Contains(schedule.ArrivalTime)
                               && (Train || tic.TRIP.TRAIN.TrainName.Equals(TrainName)) && tic.CustomerUN == userName
                         select new TICKET_User_View
                         {
                             ScheduleID = tic.TRIP.ScheduleID,
                             TrainID = tic.TRIP.TrainID,
                             TrainName = tic.TRIP.TRAIN.TrainName,
                             TicketID = tic.TicketID,
                             SeatNo = tic.SeatNo,
                             TicketPrice = (double)tic.TicketPrice,
                             Departure = tic.TRIP.SCHEDULE.STATION1.StationName,
                             Destination = tic.TRIP.SCHEDULE.STATION.StationName,
                             DepartureTime = tic.TRIP.SCHEDULE.DepartureTime,
                             ArrivalTime = tic.TRIP.SCHEDULE.ArrivalTime
                         };
            return result.ToList();
        }
        public List<TICKET_User_View> GetTicket(string userName, string TrainName)
        {
            PBL3 db = new PBL3();
            bool Train = false;
            if (TrainName == "") Train = true;
            var result = from tic in db.TICKETs
                         where (Train || tic.TRIP.TRAIN.TrainName.Equals(TrainName)) && tic.CustomerUN == userName
                         select new TICKET_User_View
                         {
                             ScheduleID = tic.TRIP.ScheduleID,
                             TrainID = tic.TRIP.TrainID,
                             TrainName = tic.TRIP.TRAIN.TrainName,
                             TicketID = tic.TicketID,
                             SeatNo = tic.SeatNo,
                             TicketPrice = (double)tic.TicketPrice,
                             Departure = tic.TRIP.SCHEDULE.STATION1.StationName,
                             Destination = tic.TRIP.SCHEDULE.STATION.StationName,
                             DepartureTime = tic.TRIP.SCHEDULE.DepartureTime,
                             ArrivalTime = tic.TRIP.SCHEDULE.ArrivalTime
                         };
            return result.ToList();
        }
        public List<TICKET_User_View> GetTicket(SCHEDULE_User_BLL schedule, string userName, string TrainName)
        {
            schedule.FromDepartureTime = schedule.FromDepartureTime.AddSeconds(-schedule.FromDepartureTime.Second);
            schedule.ToDepartureTime = schedule.ToDepartureTime.AddSeconds(-schedule.FromDepartureTime.Second + 59);
            schedule.FromArrivalTime = schedule.FromArrivalTime.AddSeconds(-schedule.FromArrivalTime.Second);
            schedule.ToArrivalTime = schedule.ToArrivalTime.AddSeconds(-schedule.ToArrivalTime.Second + 59);
            PBL3 db = new PBL3();
            bool Dep = false, Des = false, Train = false;
            if (schedule.DepartureID == -1) Dep = true;
            if (schedule.ArrivalID == -1) Des = true;
            if (TrainName == "") Train = true;
            var result = from tic in db.TICKETs
                         where ((Dep || tic.TRIP.SCHEDULE.DepartureID == schedule.DepartureID) && (Des || tic.TRIP.SCHEDULE.ArrivalID == schedule.ArrivalID))
                               && (DateTime.Compare(schedule.FromDepartureTime, tic.TRIP.SCHEDULE.DepartureTime) <= 0 && DateTime.Compare(tic.TRIP.SCHEDULE.DepartureTime, schedule.ToDepartureTime) <= 0)
                               && (DateTime.Compare(schedule.FromArrivalTime, tic.TRIP.SCHEDULE.ArrivalTime) <= 0 && DateTime.Compare(tic.TRIP.SCHEDULE.ArrivalTime, schedule.ToArrivalTime) <= 0)
                               && (Train || tic.TRIP.TRAIN.TrainName.Equals(TrainName)) && tic.CustomerUN == userName
                         select new TICKET_User_View
                         {
                             ScheduleID = tic.TRIP.ScheduleID,
                             TrainID = tic.TRIP.TrainID,
                             TrainName = tic.TRIP.TRAIN.TrainName,
                             TicketID = tic.TicketID,
                             SeatNo = tic.SeatNo,
                             TicketPrice = (double)tic.TicketPrice,
                             Departure = tic.TRIP.SCHEDULE.STATION1.StationName,
                             Destination = tic.TRIP.SCHEDULE.STATION.StationName,
                             DepartureTime = tic.TRIP.SCHEDULE.DepartureTime,
                             ArrivalTime = tic.TRIP.SCHEDULE.ArrivalTime
                         };
            return result.ToList();
        }
        public List<TICKET_View> GetTicket(List<int> list)
        {
            PBL3 db = new PBL3();
            List<TICKET_View> result = new List<TICKET_View>();
            foreach (int id in list)
            {
                foreach (TICKET_View t in BLLTRAIN.Instance.GetAllTICKETView())
                {
                    if (t.ScheduleID == id) result.Add(t);
                }
            }
            return result;
        }
        //BUG 2 tàu trùng tên
        public List<TICKET_View> GetTicket(List<int> list, string TrainName, int carriage, ref int booked, ref int unbooked)
        {
            PBL3 db = new PBL3();
            bool Train = false;
            if (TrainName == "") Train = true;
            List<TICKET_View> result = new List<TICKET_View>();
            int sum = 0;
            foreach (int id in list)
            {
                foreach (TICKET_View t in BLLTRAIN.Instance.GetAllTICKETView())
                {
                    if ((t.ScheduleID == id) && (Train || t.TrainName.Equals(TrainName)))//2 tàu trùng tên
                    {
                        sum++;
                        if (t.Booked == "đã đặt") booked++;
                        if (t.SeatNo.Contains(this.carriage[carriage - 1])) result.Add(t);
                    }
                }
            }
            unbooked = sum - booked;
            return result;
        }
        public List<string> GetTrain(string userName)
        {
            PBL3 db = new PBL3();
            var result = from tic in db.TICKETs
                         where tic.CustomerUN == userName
                         select tic.TRIP.TRAIN.TrainName;
            return result.ToList().Distinct().ToList();
        }
        public List<CBBItem> GetTrain()
        {
            PBL3 db = new PBL3();
            var result = from tra in db.TRAINs
                         select new CBBItem
                         {
                             Value = tra.TrainID,
                             Text = tra.TrainName
                         };
            return result.ToList();
        }
        public List<Train_View> GetTrain2(SCHEDULE_BLL schedule)
        {
            PBL3 db = new PBL3();
            schedule.FromDepartureTime = schedule.FromDepartureTime.AddSeconds(-schedule.FromDepartureTime.Second);
            schedule.ToDepartureTime = schedule.ToDepartureTime.AddSeconds(-schedule.FromDepartureTime.Second + 59);
            schedule.FromArrivalTime = schedule.FromArrivalTime.AddSeconds(-schedule.FromArrivalTime.Second);
            schedule.ToArrivalTime = schedule.ToArrivalTime.AddSeconds(-schedule.ToArrivalTime.Second + 59);
            bool Dep = false, Des = false;
            if (schedule.Departure == "") Dep = true;
            if (schedule.Destination == "") Des = true;
            var data =  (
                         from tri in db.TRIPs
                         where (Dep || tri.SCHEDULE.STATION1.StationName.Equals(schedule.Departure)) && (Des || tri.SCHEDULE.STATION.StationName.Equals(schedule.Destination))
                               && (DateTime.Compare(schedule.FromDepartureTime, tri.SCHEDULE.DepartureTime) <= 0 && DateTime.Compare(tri.SCHEDULE.DepartureTime, schedule.ToDepartureTime) <= 0)
                               && (DateTime.Compare(schedule.FromArrivalTime, tri.SCHEDULE.ArrivalTime) <= 0 && DateTime.Compare(tri.SCHEDULE.ArrivalTime, schedule.ToArrivalTime) <= 0)
            select new Train_View
            {
                TrainID = tri.TrainID,
                TrainName = tri.TRAIN.TrainName,
                NumberOfCarriages = tri.TRAIN.NumberOfCarriages,
                DriverUN = tri.DriverUN,
                ScheduleID = tri.ScheduleID,
                BasicPrice = tri.BasicPrice
            }).ToList();
            return data;
        }
        public List<Train_View> GetTrain3(SCHEDULE_BLL schedule)
        {
            PBL3 db = new PBL3();
            var data = (from tri in db.TRIPs
                        where (tri.SCHEDULE.STATION1.StationName.Equals(schedule.Departure)) && (tri.SCHEDULE.STATION.StationName.Equals(schedule.Destination))
                        select new Train_View
                        {
                            ScheduleID = tri.ScheduleID,
                            TrainID = tri.TrainID,
                            TrainName = tri.TRAIN.TrainName,
                            NumberOfCarriages = tri.TRAIN.NumberOfCarriages,
                            DriverUN = tri.DriverUN,
                            BasicPrice = tri.BasicPrice
                        }).ToList();
            return data;
        }
        public TRIP GetTrip(int ScheduleID, int TrainID)
        {
            PBL3 db = new PBL3();
            return (from tri in db.TRIPs
                    where tri.ScheduleID == ScheduleID && tri.TrainID == TrainID
                    select tri).ToList().FirstOrDefault();
        }
        public List<CBBItem> GetTrain(int scheduleid)
        {
            PBL3 db = new PBL3();
            return (from tri in db.TRIPs
                   where tri.ScheduleID == scheduleid
                   select new CBBItem
                   {
                       Value = tri.TRAIN.TrainID,
                       Text = tri.TRAIN.TrainName
                   }).ToList();
        }
        public List<TRAIN> GettrainBytrainid(int scheduleid)
        {
            PBL3 db = new PBL3();
            List<TRAIN> data = new List<TRAIN>();
            data = (
                   from tri in db.TRIPs
                   where tri.ScheduleID == scheduleid
                   select tri.TRAIN).ToList();

            return data;
        }
        //BUG tàu trùng tên
        public List<string> GetTrain(SCHEDULE_View schedule, string userName)
        {
            PBL3 db = new PBL3();
            bool Dep = false, Des = false;
            if (schedule.Departure == "") Dep = true;
            if (schedule.Destination == "") Des = true;
            var result = from tic in db.TICKETs
                         where (Dep || tic.TRIP.SCHEDULE.STATION1.StationName.Equals(schedule.Departure)) && (Des || tic.TRIP.SCHEDULE.STATION.StationName.Equals(schedule.Destination))
                               && tic.TRIP.SCHEDULE.DepartureTime.ToString("dd/MM/yyyy H:m:s").Contains(schedule.DepartureTime)
                               && tic.TRIP.SCHEDULE.ArrivalTime.ToString("dd/MM/yyyy H:m:s").Contains(schedule.ArrivalTime)
                               && tic.CustomerUN == userName
                         select tic.TRIP.TRAIN.TrainName;
            return result.ToList().Distinct().ToList();
        }
        public List<string> GetTrain(SCHEDULE_User_BLL schedule, string userName)
        {
            schedule.FromDepartureTime = schedule.FromDepartureTime.AddSeconds(-schedule.FromDepartureTime.Second);
            schedule.ToDepartureTime = schedule.ToDepartureTime.AddSeconds(-schedule.FromDepartureTime.Second + 59);
            schedule.FromArrivalTime = schedule.FromArrivalTime.AddSeconds(-schedule.FromArrivalTime.Second);
            schedule.ToArrivalTime = schedule.ToArrivalTime.AddSeconds(-schedule.ToArrivalTime.Second + 59);
            PBL3 db = new PBL3();
            bool Dep = false, Des = false;
            if (schedule.DepartureID == -1) Dep = true;
            if (schedule.ArrivalID == -1) Des = true;
            var result = from tic in db.TICKETs
                         where (Dep || tic.TRIP.SCHEDULE.DepartureID == schedule.DepartureID) && (Des || tic.TRIP.SCHEDULE.ArrivalID == schedule.ArrivalID)
                               && (DateTime.Compare(schedule.FromDepartureTime, tic.TRIP.SCHEDULE.DepartureTime) <= 0 && DateTime.Compare(tic.TRIP.SCHEDULE.DepartureTime, schedule.ToDepartureTime) <= 0)
                               && (DateTime.Compare(schedule.FromArrivalTime, tic.TRIP.SCHEDULE.ArrivalTime) <= 0 && DateTime.Compare(tic.TRIP.SCHEDULE.ArrivalTime, schedule.ToArrivalTime) <= 0)
                               && tic.CustomerUN.ToUpper().Equals(userName.ToUpper())
                         select tic.TRIP.TRAIN.TrainName;
            return result.ToList().Distinct().ToList();
        }
        //BUG tàu trùng tên
        public List<string> GetTrain(List<int> list)
        {
            PBL3 db = new PBL3();
            List<string> result = new List<string>();
            foreach (int id in list)
            {
                foreach (SCHEDULE s in db.SCHEDULEs)
                {
                    if (s.ScheduleID == id)
                    {
                        foreach (TRIP t in s.TRIPs)
                        {
                            result.Add(t.TRAIN.TrainName);
                        }
                        break;
                    }
                }
            }
            return result.Distinct().ToList();
        }
        public void addticket(TICKET s)
        {
            PBL3 db = new PBL3();
            int ticketID =  (from tic in db.TICKETs.ToList()
                             where (tic.ScheduleID == s.ScheduleID) && (tic.TrainID == s.TrainID) && (tic.SeatNo.ToUpper() == s.SeatNo)
                             select tic.TicketID).FirstOrDefault();
            SetTicket(ticketID, s.CustomerUN, true);
        }

        public void SetTicket(int TicketID, string userName, bool booked)
        {
            PBL3 db = new PBL3();
            TICKET tic = db.TICKETs.Find(TicketID);
            if (booked)
            {
                tic.Booked = true;
                tic.CustomerUN = userName;
            }
            else
            {
                tic.Booked = false;
                tic.CustomerUN = null;
            }
            db.SaveChanges();
        }
        public void SetTicket(List<int> TicketID, string userName, bool booked)
        {
            PBL3 db = new PBL3();
            if (userName == "") userName = null;
            foreach (int t in TicketID)
            {
                foreach (TICKET tic in db.TICKETs)
                {
                    if (tic.TicketID == t)
                    {
                        tic.Booked = booked;
                        tic.CustomerUN = userName;
                        break;
                    }
                }
            }
            db.SaveChanges();
        }
        //BUG!!! (Tàu trùng tên)
        public int GetNumberOfCarriages(string TrainName)
        {
            PBL3 db = new PBL3();
            int result = 25;
            if (TrainName == "")
                return result;
            foreach (TRAIN t in db.TRAINs)
            {
                if (t.TrainName.Equals(TrainName))
                    result = t.NumberOfCarriages;
            }
            return (from tra in db.TRAINs
                   where tra.TrainName.Equals(TrainName)
                   select tra.NumberOfCarriages).FirstOrDefault();
        }
        public int GetNumberBooked(List<string> list, string TrainName)
        {
            PBL3 db = new PBL3();
            int result = 0;
            bool Train = false;
            if (TrainName == "") Train = true;
            foreach (string id in list)
            {
                foreach(SCHEDULE s in db.SCHEDULEs)
                {
                    if (s.ScheduleID.Equals(id))
                    {
                        foreach (TRIP t in s.TRIPs)
                        {
                            if (Train || t.TRAIN.TrainName.Equals(TrainName))
                            {
                                foreach(TICKET ti in t.TICKETs)
                                {
                                    if(ti.Booked == true) result++;
                                }
                            }
                        }
                        break;
                    }
                }
            }
            return result;
        }

        public void GetStation(string userName, ref List<CBBSchedule> cbbDep, ref List<CBBSchedule> cbbDes)
        {
            PBL3 db = new PBL3();
            cbbDep = (from tic in db.TICKETs
                      where tic.CustomerUN == userName
                      select new CBBSchedule
                      {
                          Value = tic.TRIP.SCHEDULE.DepartureID,
                          Text = tic.TRIP.SCHEDULE.STATION1.StationName
                      }).GroupBy(x => x.Value).Select(y => y.FirstOrDefault()).ToList();
            cbbDes = (from tic in db.TICKETs
                      where tic.CustomerUN == userName
                      select new CBBSchedule
                      {
                          Value = tic.TRIP.SCHEDULE.ArrivalID,
                          Text = tic.TRIP.SCHEDULE.STATION.StationName
                      }).GroupBy(x => x.Value).Select(y => y.FirstOrDefault()).ToList();
        }
        public List<CBBSchedule> GetDeparture(string userName, int ArrivalID)
        {
            PBL3 db = new PBL3();
            if (ArrivalID != -1)
                return (from tic in db.TICKETs
                        where tic.CustomerUN == userName && tic.TRIP.SCHEDULE.DepartureID != ArrivalID
                        select new CBBSchedule
                        {
                            Value = tic.TRIP.SCHEDULE.DepartureID,
                            Text = tic.TRIP.SCHEDULE.STATION1.StationName
                        }).GroupBy(x => x.Value).Select(y => y.FirstOrDefault()).ToList();
            else
                return (
                        from tic in db.TICKETs
                        where tic.CustomerUN == userName
                        select new CBBSchedule
                        {
                            Value = tic.TRIP.SCHEDULE.DepartureID,
                            Text = tic.TRIP.SCHEDULE.STATION1.StationName
                        }).GroupBy(x => x.Value).Select(y => y.FirstOrDefault()).ToList();
        }
        public List<CBBSchedule> GetDestination(string userName, int DepartureID)
        {
            PBL3 db = new PBL3();
            if (DepartureID != -1)
            {
                return  (from tic in db.TICKETs
                           where tic.CustomerUN == userName && tic.TRIP.SCHEDULE.ArrivalID != DepartureID
                           select new CBBSchedule
                           {
                               Value = tic.TRIP.SCHEDULE.ArrivalID,
                               Text = tic.TRIP.SCHEDULE.STATION.StationName
                           }).GroupBy(x => x.Value).Select(y => y.FirstOrDefault()).ToList();

            }
            else
            {
                return (from tic in db.TICKETs
                           where tic.CustomerUN == userName
                           select new CBBSchedule
                           {
                               Value = tic.TRIP.SCHEDULE.ArrivalID,
                               Text = tic.TRIP.SCHEDULE.STATION.StationName
                           }).GroupBy(x => x.Value).Select(y => y.FirstOrDefault()).ToList();
            }
        }
        public List<CBBpeople> GetAllCBBDriver()
        {
            PBL3 db = new PBL3();
            return (from peo in db.PEOPLE.ToList()
                    where peo.POSITION.Position == "Lái tàu"
                    select new CBBpeople
                    {
                        Value = peo.Username,
                        Text = peo.Name
                    }).ToList();

        }
        public List<CBBSchedule> GetDeparture(int ArrivalID)
        {
            PBL3 db = new PBL3();
            if (ArrivalID != -1)
                return (from tri in db.TRIPs
                        where tri.SCHEDULE.DepartureID != ArrivalID
                        select new CBBSchedule
                        {
                            Value = tri.SCHEDULE.DepartureID,
                            Text = tri.SCHEDULE.STATION1.StationName
                        }).GroupBy(x => x.Value).Select(y => y.FirstOrDefault()).ToList();
            else
                return (from tri in db.TRIPs
                        select new CBBSchedule
                        {
                            Value = tri.SCHEDULE.DepartureID,
                            Text = tri.SCHEDULE.STATION1.StationName
                        }).GroupBy(x => x.Value).Select(y => y.FirstOrDefault()).ToList();
        }
        public List<CBBSchedule> GetDeparture2(int ArrivalID)
        {
            PBL3 db = new PBL3();
            if (ArrivalID != -1)
                return (from sch in db.SCHEDULEs
                        where sch.DepartureID != ArrivalID
                        select new CBBSchedule
                        {
                            Value = sch.DepartureID,
                            Text = sch.STATION1.StationName
                        }).GroupBy(x => x.Value).Select(y => y.FirstOrDefault()).ToList();
            else
                return (from sch in db.SCHEDULEs
                        select new CBBSchedule
                        {
                            Value = sch.DepartureID,
                            Text = sch.STATION1.StationName
                        }).GroupBy(x => x.Value).Select(y => y.FirstOrDefault()).ToList();
        }
        public List<CBBSchedule> GetDestination(int DepartureID)
        {
            PBL3 db = new PBL3();
            if (DepartureID != -1)
                return (from tri in db.TRIPs
                        where tri.SCHEDULE.ArrivalID != DepartureID
                        select new CBBSchedule
                        {
                            Value = tri.SCHEDULE.ArrivalID,
                            Text = tri.SCHEDULE.STATION.StationName
                        }).GroupBy(x => x.Value).Select(y => y.FirstOrDefault()).ToList();
            else
                return (from tri in db.TRIPs
                        select new CBBSchedule
                        {
                            Value = tri.SCHEDULE.ArrivalID,
                            Text = tri.SCHEDULE.STATION.StationName
                        }).GroupBy(x => x.Value).Select(y => y.FirstOrDefault()).ToList();
        }
        public List<CBBSchedule> GetDestination2(int DepartureID)
        {
            PBL3 db = new PBL3();
            if (DepartureID != -1)
                return (from sch in db.SCHEDULEs
                        where sch.ArrivalID != DepartureID
                        select new CBBSchedule
                        {
                            Value = sch.ArrivalID,
                            Text = sch.STATION.StationName
                        }).GroupBy(x => x.Value).Select(y => y.FirstOrDefault()).ToList();
            else
                return (from sch in db.SCHEDULEs
                        select new CBBSchedule
                        {
                            Value = sch.ArrivalID,
                            Text = sch.STATION.StationName
                        }).GroupBy(x => x.Value).Select(y => y.FirstOrDefault()).ToList();
        }
    public List<string> GetDeparturep(string Destination)
    {
        PBL3 db = new PBL3();
        if (Destination != "")
            return (from sta in db.STATIONs.ToList()
                    where !sta.StationName.Equals(Destination)
                    select sta.StationName).ToList();
        else
            return (from sch in db.SCHEDULEs.ToList()
                    select sch.STATION1.StationName).ToList();
    }
    public List<string> GetDestinationp(string Departure)
    {
        PBL3 db = new PBL3();
        if (Departure != "")
            return (from sta in db.STATIONs.ToList()
                    where !sta.StationName.Equals(Departure)
                    select sta.StationName).ToList();
        else
            return (from sch in db.SCHEDULEs.ToList()
                    select sch.STATION.StationName).ToList();
    }
    //Trả về ds tất cả ga trong table STATION (ngoại trừ ga trùng vs ga được truyền vào)
    public List<CBBSchedule> GetAllStation(int StationID)
        
        {
            PBL3 db = new PBL3();
            return (from sta in db.STATIONs
                    where sta.StationID != StationID
                    select new CBBSchedule
                    {
                        Value = sta.StationID,
                        Text = sta.StationName
                    }).ToList();
        }
        public bool checksch(int scheduleid)
        {
            PBL3 db = new PBL3();
            foreach (SCHEDULE i in db.SCHEDULEs)
            {
                if (i.ScheduleID == scheduleid) return true;
            }
            return false;
        }
        public bool checktrain(int trainid)
        {
            PBL3 db = new PBL3();
            foreach (TRAIN i in db.TRAINs)
            {
                if (i.TrainID == trainid) return false;
            }
            return true;
        }
        public List<SCHEDULE_View> GetSchedule(string userName)
        {
            PBL3 db = new PBL3();
            var result = from tic in db.TICKETs.ToList()
                         where tic.Booked == true && tic.CustomerUN.ToUpper() == userName.ToUpper()
                         select new SCHEDULE_View
                         {
                             ScheduleID = tic.TRIP.ScheduleID,
                             Departure = tic.TRIP.SCHEDULE.STATION1.StationName,
                             Destination = tic.TRIP.SCHEDULE.STATION.StationName,
                             DepartureTime = tic.TRIP.SCHEDULE.DepartureTime.ToString(),
                             ArrivalTime = tic.TRIP.SCHEDULE.ArrivalTime.ToString()
                         };
            return result.ToList().GroupBy(s => s.ScheduleID).Select(g => g.FirstOrDefault()).ToList();
        }
        public string GetSchedule(string userName, string day, string month, string year)
        {
            Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("nl");
            PBL3 db = new PBL3();
            string result = "";
            string date = day + "-" + month + "-" + year;
            bool UngetSchedule = true;
            int dem = 1;
            foreach (SCHEDULE s in db.SCHEDULEs.ToList())
            {
                if (s.DepartureTime.ToString("d-M-yyyy H:m:s").Contains(date))
                {
                    foreach (TRIP t in s.TRIPs)
                    {
                        foreach (TICKET ti in t.TICKETs.ToList())
                        {
                            if (ti.Booked == true && ti.CustomerUN.ToUpper().Equals(userName.ToUpper()))
                            {
                                result += $"\n  Lịch trình {dem++}:\n";
                                result += "  Ga đi: " + s.STATION1.StationName + "\n";
                                result += "  Ga đến: " + s.STATION.StationName + "\n";
                                result += "  Thời gian khởi hành:\n  " + s.DepartureTime + "\n";
                                result += "  Thời gian đến:\n  " + s.ArrivalTime + "\n";
                                UngetSchedule = false;
                                break;
                            }
                        }
                        if (UngetSchedule == false)
                        {
                            UngetSchedule = true;
                            break;
                        }

                    }
                }
            }
            return result;
        }

        public List<SCHEDULE_View> GetSchedule(SCHEDULE_View schedule, string userName)
        {
            PBL3 db = new PBL3();
            bool Dep = false, Des = false;
            if (schedule.Departure == "") Dep = true;
            if (schedule.Destination == "") Des = true;
            var result = from tic in db.TICKETs
                         where (Dep || tic.TRIP.SCHEDULE.STATION1.StationName.Equals(schedule.Departure)) && (Des || tic.TRIP.SCHEDULE.STATION.StationName.Equals(schedule.Destination))
                               && tic.TRIP.SCHEDULE.DepartureTime.ToString("dd/MM/yyyy H:m:s").Contains(schedule.DepartureTime)
                               && tic.TRIP.SCHEDULE.ArrivalTime.ToString("dd/MM/yyyy H:m:s").Contains(schedule.ArrivalTime)
                               && tic.CustomerUN == userName
                         select new SCHEDULE_View
                         {
                             ScheduleID = tic.TRIP.ScheduleID,
                             Departure = tic.TRIP.SCHEDULE.STATION1.StationName,
                             Destination = tic.TRIP.SCHEDULE.STATION.StationName,
                             DepartureTime = tic.TRIP.SCHEDULE.DepartureTime.ToString(),
                             ArrivalTime = tic.TRIP.SCHEDULE.ArrivalTime.ToString()
                         };
            return result.ToList().GroupBy(s => s.ScheduleID).Select(g => g.FirstOrDefault()).ToList();
        }
        public List<SCHEDULE_View> GetSchedule(SCHEDULE_BLL schedule, string userName)
        {
            schedule.FromDepartureTime = schedule.FromDepartureTime.AddSeconds(-schedule.FromDepartureTime.Second);
            schedule.ToDepartureTime = schedule.ToDepartureTime.AddSeconds(-schedule.FromDepartureTime.Second + 59);
            schedule.FromArrivalTime = schedule.FromArrivalTime.AddSeconds(-schedule.FromArrivalTime.Second);
            schedule.ToArrivalTime = schedule.ToArrivalTime.AddSeconds(-schedule.ToArrivalTime.Second + 59);
            PBL3 db = new PBL3();
            bool Dep = false, Des = false;
            if (schedule.Departure == "") Dep = true;
            if (schedule.Destination == "") Des = true;
            var result = from tic in db.TICKETs.ToList()
                         where (Dep || tic.TRIP.SCHEDULE.STATION1.StationName.Equals(schedule.Departure)) && (Des || tic.TRIP.SCHEDULE.STATION.StationName.Equals(schedule.Destination))
                               && (DateTime.Compare(schedule.FromDepartureTime, tic.TRIP.SCHEDULE.DepartureTime) <= 0 && DateTime.Compare(tic.TRIP.SCHEDULE.DepartureTime, schedule.ToDepartureTime) <= 0)
                               && (DateTime.Compare(schedule.FromArrivalTime, tic.TRIP.SCHEDULE.ArrivalTime) <= 0 && DateTime.Compare(tic.TRIP.SCHEDULE.ArrivalTime, schedule.ToArrivalTime) <= 0)
                               && tic.Booked == true && tic.CustomerUN.ToUpper() == userName.ToUpper()
                         select new SCHEDULE_View
                         {
                             ScheduleID = tic.TRIP.ScheduleID,
                             Departure = tic.TRIP.SCHEDULE.STATION1.StationName,
                             Destination = tic.TRIP.SCHEDULE.STATION.StationName,
                             DepartureTime = tic.TRIP.SCHEDULE.DepartureTime.ToString(),
                             ArrivalTime = tic.TRIP.SCHEDULE.ArrivalTime.ToString()
                         };
            return result.ToList().GroupBy(s => s.ScheduleID).Select(g => g.FirstOrDefault()).ToList();
        }
        public List<SCHEDULE_View> GetSchedule()
        {
            PBL3 db = new PBL3();
            return (from tri in db.TRIPs.ToList()
                    where DateTime.Compare(tri.SCHEDULE.DepartureTime, DateTime.Now) >= 0
                    select new SCHEDULE_View
                    {
                        ScheduleID = tri.ScheduleID,
                        Departure = tri.SCHEDULE.STATION1.StationName,
                        Destination = tri.SCHEDULE.STATION.StationName,
                        DepartureTime = tri.SCHEDULE.DepartureTime.ToString(),
                        ArrivalTime = tri.SCHEDULE.ArrivalTime.ToString()
                    }).ToList().GroupBy(s => s.ScheduleID).Select(g => g.FirstOrDefault()).ToList();
        }
        public List<SCHEDULE_View> GetSchedule2()
        {
            PBL3 db = new PBL3();
            return (from sch in db.SCHEDULEs.ToList()
                    select new SCHEDULE_View
                    {
                        ScheduleID = sch.ScheduleID,
                        Departure = sch.STATION1.StationName,
                        Destination = sch.STATION.StationName,
                        DepartureTime = sch.DepartureTime.ToString(),
                        ArrivalTime = sch.ArrivalTime.ToString()
                    }).ToList();
        }
        public SCHEDULE GetScheduleid(int scheduleid)
        {
            PBL3 db = new PBL3();
            return db.SCHEDULEs.Where(p => (p.ScheduleID == scheduleid)).Select(p => p).FirstOrDefault();
        }
        public void AddTrip(TRIP s)
        {
            PBL3 db = new PBL3();
            db.TRIPs.Add(s);
            db.SaveChanges();
            AddListTicket(s);
        }
        public List<Train_View> Getalltrain()
        {
            PBL3 db = new PBL3();
            return (
                    from tri in db.TRIPs
                    select new Train_View
                    {
                        ScheduleID = tri.ScheduleID,
                        TrainID = tri.TRAIN.TrainID,
                        TrainName = tri.TRAIN.TrainName,
                        NumberOfCarriages = tri.TRAIN.NumberOfCarriages,
                        DriverUN = (tri.DriverUN != null) ? tri.DriverUN.ToString() : "Chưa có",
                        BasicPrice = tri.BasicPrice
                    }).ToList();
        }
        public List<ticket_nhanvien> Getallve()
        {
            PBL3 db = new PBL3();
            int numberTicket;
            List<ticket_nhanvien> list = new List<ticket_nhanvien>();
            foreach (TRIP tri in db.TRIPs)
            {
                numberTicket = 0;
                foreach (TICKET tic in tri.TICKETs)
                {
                    if (tic.Booked == true)
                    {
                        numberTicket++;
                    }
                }
                list.Add(new ticket_nhanvien
                {
                    Malichtrinh = tri.ScheduleID,
                    Matau = tri.TrainID,
                    Tentau = tri.TRAIN.TrainName,
                    Sotoa = tri.TRAIN.NumberOfCarriages,
                    Nguoilaitau = (tri.DriverUN != null) ? tri.DriverUN.ToString() : "Chưa có",
                    Noidi = tri.SCHEDULE.STATION1.StationName,
                    Noiden = tri.SCHEDULE.STATION.StationName,
                    thoigiandi = tri.SCHEDULE.DepartureTime.ToString(),
                    thoigianden = tri.SCHEDULE.ArrivalTime.ToString(),
                    Sovedaban = numberTicket
                });

            }
            return list;
        }
        public List<ticket_nhanvien> Getallve(SCHEDULE_BLL lt)
        {
            PBL3 db = new PBL3();
            int numberTicket;
            List<ticket_nhanvien> list = new List<ticket_nhanvien>();
            foreach (TRIP tri in db.TRIPs)
            {
                if(tri.SCHEDULE.STATION1.StationName == lt.Departure && (tri.SCHEDULE.STATION.StationName == lt.Destination))
                {
                    numberTicket = 0;
                    foreach (TICKET tic in tri.TICKETs)
                    {
                        if (tic.Booked == true)
                        {
                            numberTicket++;
                        }
                    }
                    list.Add(new ticket_nhanvien
                    {
                        Malichtrinh = tri.ScheduleID,
                        Matau = tri.TrainID,
                        Tentau = tri.TRAIN.TrainName,
                        Sotoa = tri.TRAIN.NumberOfCarriages,
                        Nguoilaitau = (tri.DriverUN != null) ? tri.DriverUN.ToString() : "Chưa có",
                        Noidi = tri.SCHEDULE.STATION1.StationName,
                        Noiden = tri.SCHEDULE.STATION.StationName,
                        thoigiandi = tri.SCHEDULE.DepartureTime.ToString(),
                        thoigianden = tri.SCHEDULE.ArrivalTime.ToString(),
                        Sovedaban = numberTicket
                    });

                }
            }
            return list;
        }
        public List<ticket_nhanvien> Getallve2(SCHEDULE_BLL lt)
        {
            PBL3 db = new PBL3();
            int numberTicket;
            List<ticket_nhanvien> list = new List<ticket_nhanvien>();
            foreach (TRIP tri in db.TRIPs)
            {
                if(tri.SCHEDULE.STATION1.StationName == lt.Departure && (tri.SCHEDULE.STATION.StationName == lt.Destination) 
                    && (DateTime.Compare(lt.FromDepartureTime, tri.SCHEDULE.DepartureTime) <= 0 && DateTime.Compare(tri.SCHEDULE.DepartureTime, lt.ToDepartureTime) <= 0)
                    && (DateTime.Compare(lt.FromArrivalTime, tri.SCHEDULE.ArrivalTime) <= 0 && DateTime.Compare(tri.SCHEDULE.ArrivalTime, lt.ToArrivalTime) <= 0))
                {
                    numberTicket = 0;
                    foreach (TICKET tic in tri.TICKETs)
                    {
                        if (tic.Booked == true)
                        {
                            numberTicket++;
                        }
                    }
                    list.Add(new ticket_nhanvien
                    {
                        Malichtrinh = tri.ScheduleID,
                        Matau = tri.TrainID,
                        Tentau = tri.TRAIN.TrainName,
                        Sotoa = tri.TRAIN.NumberOfCarriages,
                        Nguoilaitau = (tri.DriverUN != null) ? tri.DriverUN.ToString() : "Chưa có",
                        Noidi = tri.SCHEDULE.STATION1.StationName,
                        Noiden = tri.SCHEDULE.STATION.StationName,
                        thoigiandi = tri.SCHEDULE.DepartureTime.ToString(),
                        thoigianden = tri.SCHEDULE.ArrivalTime.ToString(),
                        Sovedaban = numberTicket
                    });

                }
            }
            return list;
        }

        public List<SCHEDULE_View> GetSchedule(SCHEDULE_View schedule)
        {
            PBL3 db = new PBL3();
            bool Dep = false, Des = false;
            if (schedule.Departure == "") Dep = true;
            if (schedule.Destination == "") Des = true;
            var result = from sch in db.SCHEDULEs.ToList()
                         where (Dep || sch.STATION1.StationName.Equals(schedule.Departure)) && (Des || sch.STATION.StationName.Equals(schedule.Destination))
                               && sch.DepartureTime.ToString("dd/MM/yyyy H:m:s").Contains(schedule.DepartureTime)
                               && sch.ArrivalTime.ToString("dd/MM/yyyy H:m:s").Contains(schedule.ArrivalTime)
                         select new SCHEDULE_View
                         {
                             ScheduleID = sch.ScheduleID,
                             Departure = sch.STATION1.StationName,
                             Destination = sch.STATION.StationName,
                             DepartureTime = sch.DepartureTime.ToString(),
                             ArrivalTime = sch.ArrivalTime.ToString()
                         };
            return result.ToList();
        }
        public List<SCHEDULE_View> GetSchedule(SCHEDULE_BLL schedule)
        {
            schedule.FromDepartureTime = schedule.FromDepartureTime.AddSeconds(-schedule.FromDepartureTime.Second);
            schedule.ToDepartureTime = schedule.ToDepartureTime.AddSeconds(-schedule.FromDepartureTime.Second + 59);
            schedule.FromArrivalTime = schedule.FromArrivalTime.AddSeconds(-schedule.FromArrivalTime.Second);
            schedule.ToArrivalTime = schedule.ToArrivalTime.AddSeconds(-schedule.ToArrivalTime.Second + 59);
            PBL3 db = new PBL3();
            bool Dep = false, Des = false;
            if (schedule.Departure == "") Dep = true;
            if (schedule.Destination == "") Des = true;
            var result = from tri in db.TRIPs.ToList()
                         where (Dep || tri.SCHEDULE.STATION1.StationName.Equals(schedule.Departure)) && (Des || tri.SCHEDULE.STATION.StationName.Equals(schedule.Destination))
                               && (DateTime.Compare(schedule.FromDepartureTime, tri.SCHEDULE.DepartureTime) <= 0 && DateTime.Compare(tri.SCHEDULE.DepartureTime, schedule.ToDepartureTime) <= 0)
                               && (DateTime.Compare(schedule.FromArrivalTime, tri.SCHEDULE.ArrivalTime) <= 0 && DateTime.Compare(tri.SCHEDULE.ArrivalTime, schedule.ToArrivalTime) <= 0)
                         select new SCHEDULE_View
                         {
                             ScheduleID = tri.ScheduleID,
                             Departure = tri.SCHEDULE.STATION1.StationName,
                             Destination = tri.SCHEDULE.STATION.StationName,
                             DepartureTime = tri.SCHEDULE.DepartureTime.ToString(),
                             ArrivalTime = tri.SCHEDULE.ArrivalTime.ToString()
                         };
            return result.ToList().GroupBy(s => s.ScheduleID).Select(g => g.FirstOrDefault()).ToList();
        }
        public List<SCHEDULE_View> GetSchedule2(SCHEDULE_BLL schedule)
        {
            schedule.FromDepartureTime = schedule.FromDepartureTime.AddSeconds(-schedule.FromDepartureTime.Second);
            schedule.ToDepartureTime = schedule.ToDepartureTime.AddSeconds(-schedule.FromDepartureTime.Second + 59);
            schedule.FromArrivalTime = schedule.FromArrivalTime.AddSeconds(-schedule.FromArrivalTime.Second);
            schedule.ToArrivalTime = schedule.ToArrivalTime.AddSeconds(-schedule.ToArrivalTime.Second + 59);
            PBL3 db = new PBL3();
            bool Dep = false, Des = false;
            if (schedule.Departure == "") Dep = true;
            if (schedule.Destination == "") Des = true;
            var result = from sch in db.SCHEDULEs.ToList()
                         where (Dep || sch.STATION1.StationName.Equals(schedule.Departure)) && (Des || sch.STATION.StationName.Equals(schedule.Destination))
                               && (DateTime.Compare(schedule.FromDepartureTime, sch.DepartureTime) <= 0 && DateTime.Compare(sch.DepartureTime, schedule.ToDepartureTime) <= 0)
                               && (DateTime.Compare(schedule.FromArrivalTime, sch.ArrivalTime) <= 0 && DateTime.Compare(sch.ArrivalTime, schedule.ToArrivalTime) <= 0)
                         select new SCHEDULE_View
                         {
                             ScheduleID = sch.ScheduleID,
                             Departure = sch.STATION1.StationName,
                             Destination = sch.STATION.StationName,
                             DepartureTime = sch.DepartureTime.ToString(),
                             ArrivalTime = sch.ArrivalTime.ToString()
                         };
            return result.ToList();
        }
        public List<SCHEDULE_View> GetSchedule2(SCHEDULE_View schedule)
        {
            PBL3 db = new PBL3();
            bool Dep = false, Des = false;
            if (schedule.Departure == "") Dep = true;
            if (schedule.Destination == "") Des = true;
            //var result = from sch in db.SCHEDULEs.ToList()
            //             where (Dep || sch.STATION.StationName.Equals(schedule.Departure)) || (Des || sch.STATION1.StationName.Equals(schedule.Destination))
            //                   && sch.DepartureTime.ToString("d/M/yyyy H:m:s").Contains(schedule.DepartureTime)
            var result = from sch in db.SCHEDULEs.ToList()
                         where ((Dep || sch.STATION1.StationName.Equals(schedule.Departure)) && (Des || sch.STATION.StationName.Equals(schedule.Destination)))
                         select new SCHEDULE_View
                         {
                             ScheduleID = sch.ScheduleID,
                             Departure = sch.STATION1.StationName,
                             Destination = sch.STATION.StationName,
                             DepartureTime = sch.DepartureTime.ToString(),
                             ArrivalTime = sch.ArrivalTime.ToString()
                         };
            return result.ToList();
        }
        public List<int> GetDayOfDepartureTime(string month, string year, string userName)
        {
            PBL3 db = new PBL3();
            string date = month + "-" + year;
            var result = from tic in db.TICKETs.ToList()
                         where tic.TRIP.SCHEDULE.DepartureTime.ToString("d-M-yyyy H:m:s").Contains(date) && tic.Booked == true && tic.CustomerUN.ToUpper().Equals(userName.ToUpper())
                         select tic.TRIP.SCHEDULE.DepartureTime.Day;
            return result.ToList();
        }
    }

}
