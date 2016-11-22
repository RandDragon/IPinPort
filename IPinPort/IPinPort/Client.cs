using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPinPort
{
    class Client
    {
        private string Fullname;
        private int port;
        private String ip;
        private String Switch;

        public Client(String _Fullname, int _port, String _ip, String _Switch)
        {
            Fullname = _Fullname;
            port = _port;
            ip = _ip;
            Switch = _Switch + ".vs.bcitelecom.ru";
        }

        public override String ToString()
        {
            String str = Switch1;
            return str; 
        }

        public int Port
        {
            get
            {
                return port;
            }

            set
            {
                port = value;
            }
        }

        public string Fullname1
        {
            get
            {
                return Fullname;
            }

            set
            {
                Fullname = value;
            }
        }

        public String Ip
        {
            get{ return ip;}

            set
            {
                ip = value;
            }
        }

        public string Switch1
        {
            get
            {
                return Switch;
            }

            set
            {
                Switch = value;
            }
        }
    }
}
