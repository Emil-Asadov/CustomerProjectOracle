﻿using CustomerProject.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProject.View
{
    public interface IPostMethods
    {
        (string res, string err) FileDelete(int custId);
        (string res,string custIdn, string err) FileOper(ClassControls cls);
    }
}
