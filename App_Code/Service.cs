using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent();

       
    }
    

    // By. Irfan_NA_0074
    [WebMethod]
    public int ODP(int jumlah_ODP)
    {
        return jumlah_ODP;
    }

    [WebMethod]
    public int PDP_Positif(int jumlahPDP_Positif)
    {
        return jumlahPDP_Positif;
    }

    [WebMethod]
    public int PDP_Sembuh(int jumlahPDP_Sembuh)
    {
        return jumlahPDP_Sembuh;
    }

    [WebMethod]
    public int PDP_Meninggal(int jumlahPDP_Meninggal)
    {
        return jumlahPDP_Meninggal;
    }
    
}