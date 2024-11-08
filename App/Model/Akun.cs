using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bismillah.App.Model
{
    internal class Akun
    {
        public Akun(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public int user_id {  get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
