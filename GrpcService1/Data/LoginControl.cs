using GrpcService1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcService1.Data
{
    public class LoginControl
    {
        private  NorthwindEntities _context;

        public LoginControl()
        {
        }

        public LoginControl(NorthwindEntities context)
        {
            _context = context;
        }

        //public async Task<bool> isUserOk(string userName,string passWord)
        //{
        //    NorthwindEntities northwindEntities = new NorthwindEntities();
        //    _context = northwindEntities;
        //    var usr = await (from u in _context.Kullanicilar
        //              where u.UserName == userName &&
        //              u.Password == passWord
        //              && u.isActive == true
        //              select u).FirstOrDefaultAsync();


        //    return usr != null;

        //    //return true;
        //}





    }
}
