using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySalon
{
    public partial class Form2 : Form
    {
        public static int i, j;
        public static string customersID, therapistName, customersName, therapistID, customerLastName;
        Form3 win3 = new Form3();
        Form6 win6 = new Form6();
        Form4 win4 = new Form4();
        Form5 win5 = new Form5();

        private void btnUp_Click(object sender, EventArgs e) //הצגת הודעה האם הלקוח מעוניין להירשם
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Sing Up?", "return", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                win3.ShowDialog(); //הצגת חלון 3
            }
            else
                MessageBox.Show("We're sorry, you need to register first", "Messege" , MessageBoxButtons.OKCancel);

        }

        private void btnInE_Click(object sender, EventArgs e)
        {
            if (rdE.Checked == true)
            {
                long parsedId;
                if (!long.TryParse(txtidE.Text, out parsedId)) //במידה ומקלידים אותיות
                {
                    MessageBox.Show("Please enter a valid numeric ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; //צא מהשיטה אם הקלט אינו מספר חוקי 

                }
                bool userNotFound1 = true;
                for (int i = 0; i < beautySalonDataSet.Customers.Count && userNotFound1; i++) //בדיקה בטבלה האם משתמש קיים או חדש
                {
                    string value = Convert.ToString(beautySalonDataSet.Customers.Rows[i][0]); //מעבר על כל הלקוחות לפי תז
                    if (txtidE.Text == value) //שומר את התז הראשונה ועוצר
                    {
                        userNotFound1 = false;
                        customersID = Convert.ToString(beautySalonDataSet.Customers.Rows[i][0]);
                        customersName = Convert.ToString(beautySalonDataSet.Customers.Rows[i][1]);
                        customerLastName = Convert.ToString(beautySalonDataSet.Customers.Rows[i][2]);
                    }
                }
                if (userNotFound1) //לאחר בדיקה התז אינה הופיעה, כלומר זה משתמש חדש
                {
                    MessageBox.Show("User does not exist", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return ;
                }
                DialogResult result = MessageBox.Show("Do you want to make changes to your personal details?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //במידה והלקוח רוצה לבצע שינוי בפרטים האישיים
                if (result == DialogResult.No)
                {
                    win6.ShowDialog(); //אם הלקוח לא מעוניין לבצע שינויים זה יעביר אותו לחלון 6, קביעת תור 

                }
                else
                    win5.ShowDialog(); //יעבור לחלונית 5, לביצוע השינויים 
            }
            else //אם התז הופיעה ,יקח את השם והתז ויעבור לחלונית 6
            {
                customersName = Convert.ToString(beautySalonDataSet.Customers.Rows[i][2]);
                win6.ShowDialog(); //הצגת חלון 6
            }
        }

        private void btnInT_Click(object sender, EventArgs e)
        {
            if (rdT.Checked == true) //הפיכת הפקד לנכון
            {
                bool userNotFound2 = true;
                for (int j = 0; j < beautySalonDataSet.Therapists.Count && userNotFound2; j++) //לולאה שרצה על כל הטבלה של המטפלים
                {
                    therapistID = Convert.ToString(beautySalonDataSet.Therapists.Rows[j][0]); //רץ על העמודה של המטפלים והת"ז נשמרת במשתנה הזה
                    if (txtidT.Text == therapistID) //מחפש את הת"ז של המטפל
                    {
                        userNotFound2 = false;
                        therapistName = Convert.ToString(beautySalonDataSet.Therapists.Rows[j][1]);
                        therapistID = Convert.ToString(beautySalonDataSet.Therapists.Rows[j][0]);
                    }
                }
                if (userNotFound2) //במידה והת"ז של המטפל לא נמצאה
                {
                    MessageBox.Show("Therapist does not exist", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                else //במידה והת"ז של המטפל נמצאה
                {
                    win4.ShowDialog(); //הצגת חלון 4
                }
            }
            else
            {
                win4.ShowDialog();
            }
        }

        private void btnClearE_Click(object sender, EventArgs e)
        {
            txtidE.Clear(); //מנקה את התוכן
        }

        private void btnClearT_Click(object sender, EventArgs e)
        {
            txtidT.Clear(); //מנקה את התוכן
        }

        private void rdT_CheckedChanged(object sender, EventArgs e) //אם לחצנו על הכפתור של לקוח קיים, שאר הפקדים יהפכו לזמינים
        {
            if (rdT.Checked == true)
            {
                txtidT.Visible = true;
                btnInT.Visible = true;
                btnClearT.Visible = true;
            }
            else
            {
                txtidT.Visible = false;
                btnInT.Visible = false;
                btnClearT.Visible = false;
            }
        }

        private void rdE_CheckedChanged(object sender, EventArgs e) //אם לחצנו על הכפתור של לקוח קיים, שאר הפקדים יהפכו לזמינים
        {
            if (rdE.Checked == true)
            {
                txtidE.Visible = true;
                btnInE.Visible = true;
                btnClearE.Visible = true;
            }
            else
            {
                txtidE.Visible = false;
                btnInE.Visible = false;
                btnClearE.Visible = false;
            }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beautySalonDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beautySalonDataSet.Therapists' table. You can move, or remove it, as needed.
            this.therapistsTableAdapter.Fill(this.beautySalonDataSet.Therapists);
            // TODO: This line of code loads data into the 'beautySalonDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.beautySalonDataSet.Customers);
            rdT.Checked = false; //הפיכת הפקד ללא נכון
            rdE.Checked = false; //הפיכת הפקד ללא נכון
        }
    }
}
