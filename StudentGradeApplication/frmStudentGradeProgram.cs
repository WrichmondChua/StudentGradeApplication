using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class frmStudentGradeProgram : Form
    {
        public frmStudentGradeProgram()
        {
            InitializeComponent();
        }

        private void btnGenerateAverage_Click(object sender, EventArgs e)
        {
            String name = Convert.ToString(textBoxName.Text);
            double English = Convert.ToDouble(textBoxEnglish.Text);
            double Math = Convert.ToDouble(textBoxMath.Text);
            double Science = Convert.ToDouble(textBoxScience.Text);
            double Filipino = Convert.ToDouble(textBoxFilipino.Text);
            double History = Convert.ToDouble(textBoxHistory.Text);

            double subjects = English + Math + Science + Filipino + History;
            double genave = subjects / 5;

            if (genave >= 75)
            {
                labelResult.Text = ("The student has passsed." +
                                    "\nThe general average of " + name + " is " + genave + ".");
                   
                
            }
            else
            {
                labelResult.Text = ("The student has failed.");
            }
        }
    }
}
