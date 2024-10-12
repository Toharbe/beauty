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
    public partial class Form4 : Form
    {
        private object beautysalonDataGridView;
        public Form4()
        {
            InitializeComponent();
        }

        private void queuesCalendarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.queuesCalendarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beautySalonDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beautySalonDataSet.Therapists' table. You can move, or remove it, as needed.
            this.therapistsTableAdapter.Fill(this.beautySalonDataSet.Therapists);
            // TODO: This line of code loads data into the 'beautySalonDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.beautySalonDataSet.Customers);
            // TODO: This line of code loads data into the 'beautySalonDataSet.QueuesCalendar' table. You can move, or remove it, as needed.
            this.queuesCalendarTableAdapter.Fill(this.beautySalonDataSet.QueuesCalendar);
            txtNamet.Text = (Form2.therapistName); //הצגת שם המטפל לפי ת"ז
            txtIDt.Text = (Form2.therapistID); //הצגת הת"ז ממה שהוקלד בחלון הראשון

        }

        private void btnfilterdate_Click(object sender, EventArgs e) //שיטה לפלטור
        {
            string employeeID = txtIDt.Text.Trim(); //שמירת תעודת הזהות
            if ((!string.IsNullOrEmpty(employeeID))) //בודק האם הוזן ת"ז בתיבה של , ת"ז המטפל
            {
                DateTime startDate = dtpStart.Value.Date; //הגדרת זמן התחלתי
                DateTime endDate = dtpEnd.Value.Date; //הגדרת זמן סופי
                DataView dv = new DataView(beautySalonDataSet.Tables["QueuesCalendar"]); //לוקח בסיס נתונים מהטבלה
                dv.RowFilter = $"[TherapistId] = '{employeeID}' AND [date] >= #{startDate:MM/dd/yyyy}# AND [date] <= #{endDate:MM/dd/yyyy}#";//סינון לפי ההגדרה

                if (dv.Count > 0) //אם קיימים נתונים מפולטרים
                {
                    queuesCalendarBindingSource.DataSource = dv; //עדכון בסיס הנתונים החדש
                    lstP.Items.Clear(); //לנקות את התיבה של הליסט בוקס על מנת למנוע כפילויות
                    foreach (DataRowView row in dv) //חוזר על השורות המפולטרות
                    {
                        string customerId = row["customerId"].ToString(); //המרת הת"ז לשם
                        string customerName = GetcustomerName(customerId); //לאחר המרת הת"ז לשם, שמירת השם
                        if (!string.IsNullOrEmpty(customerName) && !lstP.Items.Contains(customerName)) //בדיקה שנבחר שם משמע התא אינו ריק וגם ששם הלקוח לא מופיע יותר מפעם אחת
                        {
                            lstP.Items.Add(customerName); //הוספת שם הלקוח          
                        }
                    }
                   
                }

                else
                    MessageBox.Show("No hours found"); //אם לא קיימים נתונים הצגת ההודעה
            }
            else
                MessageBox.Show("No customers found"); //אם אין לקוחות לאותו היום הצג הודעה
        }

        private string GetcustomerName(string IdCustomer) //שיטה לקבלת שם הלקוח לפי הת"ז שלו
        {
            DataRow[] rows = beautySalonDataSet.Tables["Customers"].Select($"[IdCustomer] = {IdCustomer}"); //שאילתה בטבלת הלקוחות על מנת להוציא את שם הלקוח
            if (rows.Length > 0) //נבחרה שורה
                return rows[0]["FirstName"].ToString(); //החלף בין ת"ז לבין שם הלקוח בהתאמה 
            return string.Empty; //אם לא מצאת שום לקוח תציג לי תיבה ריקה

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            Close(); //סגירת החלון הנוכחי וחזרה לתפריט הראשי
        }

        private void queuesCalendarDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                this.Validate();
                this.queuesCalendarBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.beautySalonDataSet);

        }
    }
}

