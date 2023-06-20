using CustomerProject.View;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProject.Model
{
    public class ClassGetMethods : IGetMethods
    {
        private readonly ClassDbConfig clsDbConfig = new ClassDbConfig();

        public (DataTable dt, string err) GetCustomer()
        {
            var dtRes = new DataTable();
            var errRes = string.Empty;
            var query = "SBNK_PRL.PKG_CUSTOMERS_E01.GET_CUSTOMERS_E01";
            try
            {
                var V_RES = new OracleParameter
                {
                    ParameterName = "V_RES",
                    OracleDbType = OracleDbType.RefCursor,
                    Direction = ParameterDirection.ReturnValue
                };

                (dtRes, errRes) = clsDbConfig.FillDT(query, new OracleParameter[] { V_RES });
                if (!string.IsNullOrWhiteSpace(errRes))
                    return (dtRes, errRes);
            }
            catch (Exception ex)
            {
                errRes = ex.Message;
            }
            return (dtRes, errRes);
        }

        public (DataTable dt, string err) GetCustomer(ClassControls cls)
        {
            var dtRes = new DataTable();
            var errRes = string.Empty;
            var query = "SELECT * FROM SBNK_PRL.VIEW_CUSTOMERS_E01 T WHERE";
            try
            {
                if (cls.custIdn != 0)
                    query += $" T.IDN={cls.custIdn}";
                if (!string.IsNullOrWhiteSpace(cls.name))
                    query += query.Contains("T.") ? $" AND LOWER(T.NAME) like LOWER('%{cls.name}%')" : $" LOWER(T.NAME) like LOWER('%{cls.name}%')";
                if (!string.IsNullOrWhiteSpace(cls.surname))
                    query += query.Contains("T.") ? $" AND LOWER(T.SURNAME) like LOWER('%{cls.surname}%')" : $" LOWER(T.SURNAME) like LOWER('%{cls.surname}%')";
                if (!string.IsNullOrWhiteSpace(cls.birthPlace))
                    query += query.Contains("T.") ? $" AND LOWER(T.BIRTH_PLACE) like LOWER('%{cls.birthPlace}%')" : $" LOWER(T.BIRTH_PLACE) like LOWER('%{cls.birthPlace}%')";
                if (cls.birthDate != "  .  .")
                    query += query.Contains("T.") ? $" AND T.BIRTH_DATE=TO_DATE('{cls.birthDate:dd.MM.yyyy}','DD.MM.YYYY')" : $" T.BIRTH_DATE=TO_DATE('{cls.birthDate:dd.MM.yyyy}','DD.MM.YYYY')";
                if (cls.gender != -1)
                    query += query.Contains("T.") ? $" AND T.GENDER={cls.gender}" : $" T.GENDER={cls.gender}";
                if (!string.IsNullOrWhiteSpace(cls.docNo))
                    query += query.Contains("T.") ? $" AND LOWER(T.DOC_NO) like LOWER('%{cls.docNo}%')" : $" LOWER(T.DOC_NO) like LOWER('%{cls.docNo}%')";
                if (!string.IsNullOrWhiteSpace(cls.finCode))
                    query += query.Contains("T.") ? $" AND LOWER(T.FIN_CODE) like LOWER('%{cls.finCode}%')" : $" LOWER(T.FIN_CODE) like LOWER('%{cls.finCode}%')";
                if (!string.IsNullOrWhiteSpace(cls.phoneNumber))
                    query += query.Contains("T.") ? $" AND LOWER(T.PHONE_NUMBER) like LOWER('%{cls.phoneNumber}%')" : $" LOWER(T.PHONE_NUMBER) like LOWER('%{cls.phoneNumber}%')";
                if (!string.IsNullOrWhiteSpace(cls.email))
                    query += query.Contains("T.") ? $" AND LOWER(T.EMAIL) like LOWER('%{cls.email}%')" : $" LOWER(T.EMAIL) like LOWER('%{cls.email}%')";

                (dtRes, errRes) = clsDbConfig.FillDT(query);
                if (!string.IsNullOrWhiteSpace(errRes))
                    return (dtRes, errRes);
            }
            catch (Exception ex)
            {
                errRes = ex.Message;
            }
            return (dtRes, errRes);
        }

        public (string fullName, string err) GetCustomerFullNameById(int custId)
        {
            var fullNameOut = string.Empty;
            var errRes = string.Empty;
            var query = $"SELECT SBNK_PRL.PKG_CUSTOMERS_E01.GET_CUSTOMER_FULL_NAME(P_CUST_ID => {custId})  FROM DUAL";
            try
            {
                (fullNameOut, errRes) = clsDbConfig.FillValue(query);
                if (!string.IsNullOrWhiteSpace(errRes))
                    return (fullNameOut, errRes);
            }
            catch (Exception ex)
            {
                errRes = ex.Message;
            }

            return (fullNameOut, errRes);
        }

        public (DataTable dt, string err) GetGender()
        {
            var dtOut = new DataTable();
            var errOut = string.Empty;
            var query = "SBNK_PRL.PKG_CUSTOMERS_E01.GET_GENDER";
            try
            {
                var V_RES = new OracleParameter
                {
                    ParameterName = "V_RES",
                    OracleDbType = OracleDbType.RefCursor,
                    Direction = ParameterDirection.ReturnValue
                };

                (dtOut, errOut) = clsDbConfig.FillDT(query, new OracleParameter[] { V_RES });
                if (!string.IsNullOrWhiteSpace(errOut))
                    return (dtOut, errOut);
            }
            catch (Exception ex)
            {
                errOut = ex.Message;
            }

            return (dtOut, errOut);
        }
    }
}
