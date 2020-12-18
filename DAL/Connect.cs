using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connect
    {
        dbQLKhachSanDataContext db;

        public dbQLKhachSanDataContext connection()
        {

            string connection1 = @"Data Source=.\SQLEXPRESS;Initial Catalog=KhachSan;Integrated Security=True";
            string connection2 = @"Data Source=.;Initial Catalog=KhachSan;Integrated Security=True";
            bool ck = false;
            try
            {
                db = new dbQLKhachSanDataContext(connection1);
                db.Connection.Open();
                ck = true;
                return db;
            }
            catch (Exception)
            {

                ck = false;
            }

            if (ck == false)
            {
                try
                {
                    db = new dbQLKhachSanDataContext(connection2);
                    db.Connection.Open();
                    ck = true;
                    return db;
                }
                catch (Exception)
                {

                    ck = false;
                }
            }
            return db;
        }
    }
}
