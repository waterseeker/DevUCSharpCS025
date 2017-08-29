using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevUCSharpCS_ASP_025
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            //if (firstCheckBox.Checked)
            //{
            //    if (secondCheckBox.Checked)
            //    {
            //        if (thirdCheckBox.Checked)
            //        {
            //            resultLabel.Text = "They're all checked!";
            //        }
            //    }
            //}

            //you could do the same thing like this.... 
            //if (!firstCheckBox.Checked) return;
            //if (!secondCheckBox.Checked) return;
            //if (!thirdCheckBox.Checked) return;
            //resultLabel.Text = "They're all checked!";

            //or you could do it like this.... 
            if (firstCheckBox.Checked && secondCheckBox.Checked && thirdCheckBox.Checked)
                resultLabel.Text = "Or you could do it like this.";
        }
    }
}