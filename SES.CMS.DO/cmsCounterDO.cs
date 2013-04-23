using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SES.CMS.DO
{
    public class cmsCounterDO
    {
        private int _pk_icounterid;
        public int PK_iCounterID
        {
            get { return _pk_icounterid; }
            set { _pk_icounterid = value; }
        }
        private String _sip;
        public String sIP
        {
            get { return _sip; }
            set { _sip = value; }
        }
        private DateTime _tdate;
        public DateTime tDate
        {
            get { return _tdate; }
            set { _tdate = value; }
        }
    }
}
