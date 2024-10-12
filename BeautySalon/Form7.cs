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
    public partial class Form7 : Form
    {
        private decimal totalPrice; //הגדרת משתנה חדש
        private string[] treatmentNames;
        private decimal[] treatmentPrices;
        private int treatmentCount;
        
        public Form7()
        {
            InitializeComponent();
        }

        public Form7 (decimal totalPrice, string[] treatmentNames, decimal[] treatmentPrices, int treatmentCount)//זימון המשתנה מהחלון הקודם
        {
            InitializeComponent();
            this.totalPrice = totalPrice;
            this.treatmentNames = treatmentNames;
            this.treatmentPrices = treatmentPrices;
            this.treatmentCount = treatmentCount;
        }
        private void treatmentTypeServiceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.treatmentTypeServiceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beautySalonDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beautySalonDataSet.TreatmentTypeService' table. You can move, or remove it, as needed.
            this.treatmentTypeServiceTableAdapter.Fill(this.beautySalonDataSet.TreatmentTypeService);
            txtFull.Text = (Form2.customersName);
            lblPrice.Text = $"Total price:{totalPrice:c}"; //הצגת מחיר כולל
            for (int i = 0; i < treatmentCount; i++)
            {
                ListViewItem item = new ListViewItem(treatmentNames[i]); //יצירת רשימה לפי הטיפולים שנבחרו
                item.SubItems.Add(treatmentPrices[i].ToString("C")); //חישוב המחיר עפ"י הטיפולים שנבחרו
                lstwC.Items.Add(item); //הוספת הטיפולים לרשימה 
            }
        }

        private void chkYes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkYes.Checked == true) //הפיכת הפקד לנכון כלומר הוא נבחר
            {
                chkNo.Checked = false; //משמע הפקד הזה לא נבחר
                DialogResult result = MessageBox.Show("Your request has been accepted", "Confirmation", MessageBoxButtons.OK);
                if (result == DialogResult.No)
                    chkYes.Checked = false;
            }

        }

        private void chkNo_CheckedChanged(object sender, EventArgs e) // לראות שלחצנו על הכפתור
        {
            if (chkNo.Checked == true)
            {
                chkYes.Checked = false;
            }

        }

        private void btnEnd_Click(object sender, EventArgs e) // לפני שלוחצים על הכפתור של הסיום אם לא לקחנו על כן או לא תופיע ההודעה הבאה 
        {
            if (!chkYes.Checked && !chkNo.Checked) // בודק אם לחצנו על כן או לא 
            {
                MessageBox.Show("Please select 'Yes' or 'No' before finishing your order.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Thank you very much, your order has been successfully placed!");
            Application.Exit();




        }
    }
}
