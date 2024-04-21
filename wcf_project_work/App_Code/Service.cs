using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	cls1 ob = new cls1();
	public string balancecheck(int userid,string accno)
    {
		string sel = "select accountbalance from accounttab where userid=" + userid + "and accountno='" + accno + "'";
		SqlDataReader dr = ob.fn_reader(sel);
		string bal = "";
		while (dr.Read())
		{
			bal = dr["accountbalance"].ToString();
		}
		return bal;
	}

	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}
}
