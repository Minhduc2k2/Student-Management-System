using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    public static class Globals
    {
        public static int GlobalUserId { get; set; }

        public static void SetGlobalUserId(int id)
        {
            GlobalUserId = id;
        }
    }
}
