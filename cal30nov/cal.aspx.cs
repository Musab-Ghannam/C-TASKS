using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cal30nov
{
    public partial class cal : System.Web.UI.Page
    {
        protected void Buttonsum_Click(object sender, EventArgs e)
        {
            int Sum = Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox2.Text);
            TextResult.Text = Convert.ToString(Sum);
        }

        protected void Buttonsub_Click(object sender, EventArgs e)
        {
            int Minus = Int32.Parse(TextBox1.Text) - Int32.Parse(TextBox2.Text);
            TextResult.Text = Convert.ToString(Minus);
        }

        protected void ButtonMul_Click(object sender, EventArgs e)
        {
            int Mul = Int32.Parse(TextBox1.Text) * Int32.Parse(TextBox2.Text);
            TextResult.Text = Convert.ToString(Mul);
        }

        protected void ButtonDiv_Click(object sender, EventArgs e)
        {
            int Div = Int32.Parse(TextBox1.Text) / Int32.Parse(TextBox2.Text);
            TextResult.Text = Convert.ToString(Div);

        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextResult.Text = "";
        }
    }
}