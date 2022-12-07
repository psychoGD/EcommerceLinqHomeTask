using ECommerce.DataAccess.SqlServer;
using ECommerce.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Services
{
    public class AdminService
    {
        private IRepository<Admin> _adminRepo;
        public AdminService()
        {
            _adminRepo = new AdminRepository();
        }
        public Admin GetAdminByUsername(string username)
        {
            var admin = _adminRepo.GetAllData().FirstOrDefault(x => x.Username == username);
            return admin;
        }
    }
}
