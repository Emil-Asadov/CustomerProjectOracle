using CustomerProject.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProject.View
{
    public interface IGetMethods
    {
        (DataTable dt, string err) GetGender();
        (DataTable dt, string err) GetCustomer();
        (DataTable dt, string err) GetCustomer(ClassControls cls);
        (string fullName, string err) GetCustomerFullNameById(int custId);
    }
}
