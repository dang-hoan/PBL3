using pbl.DAL;
using pbl.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<PEOPLE> GetPEOPLEByUsername(string Username)
        {
            List<PEOPLE> data = new List<PEOPLE>();
            if (Username == "")
            {
                data = DALTRAIN.Instance.GetAllPEOPLE();
            }
            else
            {
                foreach (PEOPLE i in DALTRAIN.Instance.GetAllPEOPLE())
                {
                    if (i.Username == Username)
                    {
                        data.Add(i);
                    }
                }
            }
            return data;
        }
        public void Add()
        {

        }
        public void Update()
        {

        }
        public void Delete()
        {

        }
        public void Sort()
        {

        }
    }
}
