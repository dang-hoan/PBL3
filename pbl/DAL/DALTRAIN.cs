using pbl.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl.DAL
{
    public class DALTRAIN
    {
        private static DALTRAIN _Instance;
        public static DALTRAIN Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DALTRAIN();
                }
                return _Instance;
            }
            private set { }
        }
        private DALTRAIN()
        {

        }
        public void AddPEOPLE(PEOPLE p)
        {
            //insert into
        }
        public void UpdatePEOPLE(PEOPLE p)
        {
            //update
        }
        public void DeletePEOPLE(string Username)
        {
            DBHelper.Instance.ExecuteDB($"delete from PEOPLE where Username = '{Username}'", null);
        }
        public List<PEOPLE> GetAllPEOPLE()
        {
            List<PEOPLE> people = new List<PEOPLE>();
            //select * from PEOPLE -> datatable -> people.Add()
            return people;
        }
    }
}
