using ECommerce.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.SqlServer
{
    public class AdminRepository : IAdminRepository
    {
        public ECommerceDataClassesDataContext datacontext;
        public void AddData(Admin data)
        {
            datacontext.Admins.InsertOnSubmit(data);
            datacontext.SubmitChanges();

        }

        public void DeleteData(Admin data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Admin> GetAllData()
        {
            throw new NotImplementedException();
        }

        public Admin GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Admin data)
        {
            throw new NotImplementedException();
        }
    }
}
