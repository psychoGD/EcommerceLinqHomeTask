using ECommerce.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.SqlServer
{
    public class AdminRepository : IAdminRepository
    {
        private ECommerceDataClassesDataContext _datacontext;

        public AdminRepository()
        {
            _datacontext= new ECommerceDataClassesDataContext();
        }

        public void AddData(Admin data)
        {
            _datacontext.Admins.InsertOnSubmit(data);
            _datacontext.SubmitChanges();

        }

        public void DeleteData(Admin data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Admin> GetAllData()
        {
            var admins = from c in _datacontext.Admins
                            select c;
            return new ObservableCollection<Admin>(admins);
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
