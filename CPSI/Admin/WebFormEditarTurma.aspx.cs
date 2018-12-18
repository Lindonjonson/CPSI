using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPSI.Admin.Turma
{
    public partial class WebFormEditarTurma : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelTurma.Text = DetailsViewTurma.Rows[0].Cells[1].Text;
        }

        
        

       

       
       
    }
}