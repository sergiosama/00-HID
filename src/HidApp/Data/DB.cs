using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DB
    {
        private static HIDContext _ctx;

        static DB()
        {
            _ctx = new HIDContext();
        }

        public static HIDContext Context
        {
            get { return _ctx; }
        }

        private DB()
        {

        }
    }

}
