using System;
using SEMR.Business;
using SEMR.Business.DataTables;
using SEMR.Business.Security;
using System.Data;
using SEMR.Business.Proxy;

namespace SEMR.Business.Facade
{
	public class SecurityFacade
	{
		public SecurityFacade ()
		{


		}

		public static bool AuthenticateUser(string UserName, string Password)
		{
			BusinessObject bo = null;
			BusinessContext context = null;
			AuthenticateCredentialDataTable paramSet = null;
			bool isValid = false;
			try
			{
				paramSet=new AuthenticateCredentialDataTable();
				paramSet.AddRow(UserName,SymmetricEncryption.SymmetricEncrypt(Password,"medinno"),true);
				bo=new BusinessObject();
				bo.Parameter=new DataSet();
				bo.Parameter.Tables.Add(paramSet);
				context=ServiceProxy.NewBusinessContext("BizSvr.SEC.0100010001");
				ServiceProxy.ExecuteBusinessService(ref bo,context);
				if(bo.Data!=null)
				{
					isValid=true;
				}
				return isValid;
			}
			catch(Exception ex) {
				throw ex;
			}
		
		}
	}
}

