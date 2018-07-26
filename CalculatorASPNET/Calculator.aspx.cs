using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorASPNET
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {

          //  ViewState["total"] = "";
            //TODO:  If this is a postback, don't set it to 0.

            if (!IsPostBack)
            {
                ResultBox.Text = "0";
            }

          //  ResultBox.Text = ViewState["total"].ToString();


        }


        protected void Button1_Click(object sender, EventArgs e)
        {

            if (ViewState["total"] != null)
            {
                ResultBox.Text = ViewState["total"].ToString();
            }



            double FirstValue = double.Parse(FirstValueBox.Text);

            double secondValue = double.Parse(SecondValueBox.Text);
            
            
           //  newTotal = double.Parse(ResultBox.Text);           


            if (FirstValue.ToString() != null && secondValue.ToString() !=null)
            {
                if (RadioButtonList1.SelectedIndex == 0)
                {
                    //TODO: Update newTotal value instead of ViewState or textbox at this point.

                    ViewState["total"] = secondValue + FirstValue;
                }

                if (RadioButtonList1.SelectedIndex == 1)
                {
                    ViewState["total"] = FirstValue - secondValue;
                }

                if (RadioButtonList1.SelectedIndex == 2)
                {
                    ViewState["total"] = FirstValue * secondValue;
                }

                if (RadioButtonList1.SelectedIndex == 3)
                {
                    ViewState["total"] = FirstValue / secondValue;
                }

               

            }
        }
    }
}

            
        
    
