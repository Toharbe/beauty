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
    public partial class Form5 : Form
    {
        public static string TID;
        Form6 win6 = new Form6();
        public static string x, y, z, a, b;
        public static string IdCustomer = x;
        public static string FirstName = y;
        public static string LastName = z;
        public static string bd = a;
        public static string mf = b;
        public Form5()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beautySalonDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beautySalonDataSet.QueuesCalendar' table. You can move, or remove it, as needed.
            this.queuesCalendarTableAdapter.Fill(this.beautySalonDataSet.QueuesCalendar);
            // TODO: This line of code loads data into the 'beautySalonDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.beautySalonDataSet.Customers);
            txtCusFN.Text = (Form2.customersName); //הצגת שם הלקוח לפי ת"ז
            txtCusLN.Text = (Form2.customerLastName); //הצגת שם המשפחה של הלקוח לפי הת"ז
        }

        private void rdbE_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbE.Checked == true) //הפיכת הפקד לנכון
            {
                txtCusLN.ReadOnly = false; //הוגדר נכון וכאשר אני לוחצת עליו אני רוצה לבצע בו שינוי
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCusLN.Text)) //משמע הערך בתא ריק
            {
                MessageBox.Show("LastName not entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop); //ההודעה תוצג ברגע שהתא נשאר ריק
                txtCusLN.Text = Convert.ToString(beautySalonDataSet.Customers.Rows[(Form2.i)][2]); //שמירת הערך 
            }
            else
            {
                beautySalonDataSet.Customers.Rows[(Form2.i)].BeginEdit(); //פקודה שתתחיל לערוך
                beautySalonDataSet.Customers.Rows[(Form2.i)][2] = txtCusLN.Text; //מה שמופיע בתא תשמור לי בתיבה
                beautySalonDataSet.Customers.Rows[(Form2.i)].EndEdit(); //סיום העריכה
                customersTableAdapter.Update(beautySalonDataSet.Customers);
                MessageBox.Show("The changes were made successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information); //הצגת ההודעה ברגע שהכל בוצע כשורה
            }

        }
    }
}

