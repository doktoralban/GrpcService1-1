using GrpcService1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcService1.Controllers
{
    public class UserController : Controller
    {
        private readonly NorthwindEntities _context;

        public UserController(NorthwindEntities context)
        {
            _context = context;
        }


        public async Task<bool> isUserOk(string userName, string passWord)
        {
            //NorthwindEntities northwindEntities = new NorthwindEntities();
            //_context = northwindEntities;
            var usr = await (from u in _context.Kullanicilar
                             where u.UserName == userName &&
                             u.Password == passWord
                             && u.isActive == true
                             select u).FirstOrDefaultAsync();


            //return usr != null;

            return true;
        }


    }
}
