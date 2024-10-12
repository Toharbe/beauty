using BeautySalon.BeautySalonDataSetTableAdapters;
using BeautySalon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySalon
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beautySalonDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beautySalonDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.beautySalonDataSet.Customers);

        }
        private void btnUp_Click(object sender, EventArgs e)
        {


            if (txtFname.Text.Any(char.IsDigit)) //במידה ומקלידים מספרים
            {
                MessageBox.Show("Please enter letters only. Numbers are not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // צא מהשיטה אם הקלט מכיל מספרים
            }

            if (txtLname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Please enter letters only. Numbers are not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // צא מהשיטה אם הקלט מכיל מספרים
            }

            long parsedId;
            if (!long.TryParse(txtid.Text, out parsedId)) //במידה ומקלידים אותיות
            {
                MessageBox.Show("Please enter a valid numeric ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //צא מהשיטה אם הקלט אינו מספר חוקי 
            }

            if (cmbG.SelectedItem == null) //בדיקה האם הערך בתא ריק
            {
                MessageBox.Show("Please select a treatment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //במידה והערך בתא ריק תוצג ההודעה
                return;
            }
            //============================Start of project protection ========//   
            foreach (DataRow row in beautySalonDataSet.Customers.Rows) //בודק אם התז כבר מופיע
            {
                if (row["IdCustomer"].ToString() == txtid.Text) //אם התעודת זהות שהוזנה כבר קיימת באקסס
                {
                    MessageBox.Show("This ID card already exists. Please enter a different ID.", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Error); //זה מציג הודעה 
                    return; // יוצא מהשיטה במידה וזה כבר קיים
                }
            }
            //============================End of project protection =========//

            beautySalonDataSet.Customers.Rows.Add(txtid.Text, txtFname.Text, txtLname.Text, dtpBD.Text, cmbG.Text); //הוספת הפרטים של הלקוח החדש לטבלה
            customersTableAdapter.Update(beautySalonDataSet.Customers);
            MessageBox.Show("Registration was successful!"); // בסיום ההרשמה מופיעה ההודעה
            Form2 form2 = new Form2(); //החזרת הלקוח לחלון 2 
            form2.ShowDialog();

        }
    }
}






