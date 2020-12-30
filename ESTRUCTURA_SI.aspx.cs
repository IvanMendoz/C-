using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ESTRUCTURA_SI : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int valor1=0, valor2=0;
        valor1 = Convert.ToInt32(Label1.Text);
        valor2 = Convert.ToInt32(Label2.Text);


        if (valor1>valor2)
        {
            Label3.Text = Convert.ToString("El numero mayor es: "+valor1);
        }
        else
        {
            Label3.Text = Convert.ToString("El numero mayor es: " + valor2);
        }
    }
}