using System;
using System.Data;

namespace SEMR.Business.DataTables
{
	public class AuthenticateCredentialDataTable:DataTable
	{
		public AuthenticateCredentialDataTable ()
		{
			this.TableName = "AuthenticateCredential";
			DataColumn LoginIDCol = new DataColumn ("LoginID", typeof(string));
			this.Columns.Add (LoginIDCol);
			DataColumn LoginPasswordCol = new DataColumn ("LoginPassword", typeof(string));
			this.Columns.Add (LoginPasswordCol);
			DataColumn CredentialDetailCol = new DataColumn ("LoadCredentialDetail", typeof(bool));
			this.Columns.Add (CredentialDetailCol);
		}
		public void AddRow(string loginID,string key, bool loadCredentialDetail=true)
		{
			this.Rows.Add (loginID, key, loadCredentialDetail);

		}
	}
	
}

