using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPage_T2_1920
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["SI_T2"];
            if (cookie != null)
                divAviso.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie novo = new HttpCookie("SI_T2");
            novo.Value = "Aceitou";
            novo.Expires = DateTime.Now.AddDays(365);
            Response.Cookies.Add(novo);

            divAviso.Visible = false;
        }
    }
}