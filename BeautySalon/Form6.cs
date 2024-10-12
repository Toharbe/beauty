using BeautySalon.BeautySalonDataSetTableAdapters;
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
    public partial class Form6 : Form
    {
        public static string dateprint, timeprint;
        public static string therapistId;
        public static string Customer;
        public static string CustomerId;
        public static string NewCusromerName;
        Form7 win7 = new Form7();
        public Form6(string Name) //שיטה להעברת השם החדש אל החלון 
        {
            InitializeComponent();
            NewCusromerName = Name;

        }

        private void treatmentTypeServiceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.treatmentTypeServiceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beautySalonDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beautySalonDataSet.QueuesCalendar' table. You can move, or remove it, as needed.
            this.queuesCalendarTableAdapter.Fill(this.beautySalonDataSet.QueuesCalendar);
            // TODO: This line of code loads data into the 'beautySalonDataSet.Therapists' table. You can move, or remove it, as needed.
            this.therapistsTableAdapter.Fill(this.beautySalonDataSet.Therapists);
            // TODO: This line of code loads data into the 'beautySalonDataSet.TreatmentTypeService' table. You can move, or remove it, as needed.
            this.treatmentTypeServiceTableAdapter.Fill(this.beautySalonDataSet.TreatmentTypeService);
            txtCustomer.Text = (Form2.customersName); //הצגת שם המטופל לפי השם שהוקלד בחלון 2
            txtCustomerId.Text = (Form2.customersID); //הצגת תז המטופל לפי השם שהוקלד בחלון 2
            cmbThe.Items.Clear(); //ניקוי התא כל פעם בפתיחת החלון
            cmbTreatment.Items.Clear(); //ניקוי התא כל פעם בפתיחת החלון
            for (int i = 0; i < beautySalonDataSet.TreatmentTypeService.Count; i++) // לולאה שתעבור על הטיפולים מהטבלה
            {
                cmbTreatment.Items.Add(Convert.ToString(beautySalonDataSet.TreatmentTypeService.Rows[i][1])); //מיקום הטיפולים בטבלה
            }
            dtpDate.Text = Convert.ToString(DateTime.Now); //הופעה בפקד התאריך והזמן הנוכחי
        }

        private void cmbTreatment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbThe.Items.Clear();
            cmbThe.Text = "";// מנקה את תיבת הטקסט של סוג טיפול
            cmbCode.Items.Clear();
            cmbCode.Text = "";// מנקה את תיבת הטקסט של קוד טיפול
            cmbHours.Items.Clear();
            cmbHours.Text = "";// מנקה את תיבת הטקסט של השעה
            if (cmbTreatment.SelectedItem == null) //בדיקה האם הערך בתא ריק
            {
                MessageBox.Show("Please select a treatment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //במידה והערך בתא ריק תוצג ההודעה
                return;
            }
            string SelectedTreatment = cmbTreatment.SelectedItem.ToString();//קבלת שם הטיפול שנבחר
            foreach (DataRow row in beautySalonDataSet.Therapists.Rows) //מצא את שם המטפל מתוך הטבלה
            {
                if (row["specialization"].ToString() == SelectedTreatment) //הצג את שם המטפל בהתאם לטיפול שנבחר מהרשימה
                {
                    cmbThe.Items.Add((row["FirstName"].ToString())); //הוספת השם אל רשימת הקומבו בוקס
                    break;
                }
            }
            foreach (DataRow row in beautySalonDataSet.TreatmentTypeService.Rows)  //עובר על כל הטיפולים
            {
                if (row["TypeService"].ToString() == SelectedTreatment) // אם הסוג טיפול תואם לשם טיפול שנבחר 
                {
                    cmbCode.Items.Add(row["TreatmentCode"].ToString()); //הוספת קוד המטפל לרשימת הקומבו בוקס
                    break;
                }
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            cmbHours.Items.Clear(); //ניקוי כל הערכים בתא
            DateTime selectedDate = dtpDate.Value; //התאריך שהמשתמש בחר מתוך הפקד נשמר כאן

            string SelectedTreatmentCode = Convert.ToString(cmbCode.SelectedItem);
            string[] AllHours = new string[19]; //פתיחת מערך חדש לאיחסון כל השעות הזמינות לפי שעות העבודה
            int index = 0;
            TimeSpan startTime = new TimeSpan(8, 0, 0); //הגדרת שעת התחלה
            for (TimeSpan currentTime = startTime; currentTime <= new TimeSpan(18, 0, 0); currentTime += new TimeSpan(0, 30, 0))//הלולאה עוברת מ 8 בבוקר עד 18 בערב במרווחי זמן של חצי שעה
            {
                if (index < AllHours.Length) //בודק האם השעה לא תפוסה
                {
                    AllHours[index] = currentTime.ToString(@"hh\:mm"); //במידה ולא זה מוסיף אותה
                    index++;
                }
            }
            string[] occupiedHours = new string[49]; //פתיחת מערך חדש לפי שעות תפוסות
            int occupiedIndex = 0; //איתחול אינדקס לשעות התפוסות
            foreach (DataRow row in beautySalonDataSet.QueuesCalendar.Rows) //חוזר על יומן התורים כדי למצוא את השעות שתפוסות
            {
                DateTime appointmentDate = Convert.ToDateTime(row["Date"]);
                string appointmentTreatmentCode = row["TreatmentCode"].ToString();
                if (appointmentDate.Date == selectedDate.Date && appointmentTreatmentCode == SelectedTreatmentCode) //אם הטיפול והתאריך שנבחרו תפוסים הם לא יופיעו
                {
                    string occupiedHour = Convert.ToDateTime(row["time"]).ToString("HH:mm"); //השעה התפוסה מתווספת למערך של השעות התפוסות
                    occupiedHours[occupiedIndex] = occupiedHour;
                    occupiedIndex++;

                }
            }
            for (int i = 0; i < AllHours.Length; i++) //בודק כל שעה מול השעות התפוסות
            {
                string hour = AllHours[i];
                bool isOccupied = false; //הגדרת משתנה בוליאני
                for (int j = 0; j < occupiedIndex; j++)
                {
                    if (occupiedHours[j] == hour) //אם נמצאה שעה תפוסה באותו התאריך אל תציג את השעה הזו
                    {
                        isOccupied = true;
                        break;
                    }
                }
                if (!isOccupied) //אם השעה אינה תפוסה, הוספת השעה לרשימה
                    cmbHours.Items.Add(hour);
            }
            if (cmbHours.Items.Count == 0) //אם לא נותרו שעות פנויות תוצג ההודעה
                MessageBox.Show("No available hours for the selected date", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private decimal totalPrice = 0; //משתנה שישמור בתוכו את הסכום הכולל
        private string[] TreatmentNames = new string[10]; //פתיחת מערך לפי שם הטיפולים
        private decimal[] TreatmentPrice = new decimal[10]; //פתיחת מערך לפי מחירי הטיפולים
        private int TreatmentCount = 0; //משתנה צובר שצובר בתוכו את הטיפולעים שנבחרו
        private void btnSave1_Click(object sender, EventArgs e)
        {
            if (cmbTreatment.SelectedItem == null || cmbCode.SelectedItem == null || dtpDate.Value == null || cmbHours.SelectedItem == null) //בדיקה שאף תא לא ריק
            {
                MessageBox.Show("Please make sure all selections are made before saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //אם אחד מהתאים ריקים תוצג ההודעה
                return;
            }
            CustomerId = txtCustomerId.Text; //שם את התז בתיבת טקסט
            if (string.IsNullOrEmpty(CustomerId)) //בודק שהתא לא ריק ושבאת הוכנס לשם תז
            {
                MessageBox.Show("Customer ID is not set. Please check your implementation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string selectedTreatment = cmbTreatment.SelectedItem.ToString();  //הערך שנבחר נבחר מהרשימה
            string selectedTreatmentCode = cmbCode.SelectedItem.ToString(); //הערך שנבחר נבחר מהרשימה
            DateTime selectedDate = dtpDate.Value;
            string selectedHour = cmbHours.SelectedItem.ToString(); //הערך שנבחר נבחר מהרשימה
            int therapistId = -1; //הגדרת המשתנה כלומר לטיפול אין מטפל
            foreach (DataRow row in beautySalonDataSet.Therapists.Rows) //עובר בלולאה על כל המטפלים במערך הנתונים על מנת לבדוק שהמטפל תואם את סוג הטיפול שנבחר
            {
                if (row["specialization"].ToString() == selectedTreatment) //אם נמצאה התאמה
                {
                    therapistId = Convert.ToInt32(row["IdTherapist"]); //המטפל המתאים
                    break;
                }
            }
            if (therapistId == -1) //כלומר לא נמצאה התאמה 
            {
                MessageBox.Show("Could not find the selected therapist. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //במידה ואכן לא נמצצאה התאמה תוצג ההודעה
                return;
            }
            

            DataRow newRow = beautySalonDataSet.QueuesCalendar.NewRow(); //יצירת שורה חדשה ביומן התורים
            newRow["Date"] = selectedDate; //תאריך שנבחר שיוצג ביומן תורים בשורה הזו
            newRow["TreatmentCode"] = selectedTreatmentCode; //קוד מטפל שנבחר שיוצג ביומן תורים בשורה הזו
            newRow["time"] = TimeSpan.Parse(selectedHour); //שעה שנבחרת שיוצג ביומן תורים בשורה הזו
            newRow["TherapistId"] = therapistId; //שם המטפל שנבחר שיוצג ביומן תורים בשורה הזו
            newRow["CustomerId"] = CustomerId;  // התז של המטופל יתווסף לטבלה של היומן תורים
            beautySalonDataSet.QueuesCalendar.Rows.Add(newRow); //הוספת השורה ליומן לאחר הקלדת הנתונים
            try //תפקידו לשמור נתונים במסד נתונים
            {
                queuesCalendarTableAdapter.Update(beautySalonDataSet.QueuesCalendar); //כאן התור נשמר
            }
            catch (System.Data.OleDb.OleDbException ex) //במידה ויש שגיאה בתהליך העדכון תוצג ההודעה
            {
                MessageBox.Show($"An error occurred while saving the appointment:{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal finalPrice = 0; //חישוב מחיר סופי ע"ע איפוס משתנה עזר
            foreach (DataRow row in beautySalonDataSet.TreatmentTypeService.Rows)
            {
                if (row["TreatmentCode"].ToString() == selectedTreatmentCode) // אם השם טיפול תואם לשם טיפול שנבחר
                {
                    finalPrice = Convert.ToDecimal(row["Price"]); //בהנחה כי קיים מחיר עבור  הטיפול
                    break;
                }
            }
            if (TreatmentCount < TreatmentNames.Length) //במידה ונבחר לפחות טיפול אחד אז שם הטיפול והמחיר מתווספים למערך
            {
                TreatmentNames[TreatmentCount] = selectedTreatment; //טיפול
                TreatmentPrice[TreatmentCount] = finalPrice; //מחיר
                TreatmentCount++; //במידה ונבחר יותר מטיפול אחד
            }
            totalPrice += finalPrice; //משתנה צובר 
            DialogResult result = MessageBox.Show("Do you want to schedule another appointment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //האם המשתמש מעוניין לקבוע תור נוסף
            foreach (DataRow row in beautySalonDataSet.TreatmentTypeService.Rows) //רץ על המחירים
            {
                if (row["TreatmentCode"].ToString() == selectedTreatmentCode)
                {
                    finalPrice = Convert.ToDecimal(row["Price"]);
                    break;
                }
            }
            if (result == DialogResult.Yes) //במידה וכן
            {
                ResetForm(); //קודם כל נשמרים הנתונים הקודמים והלקוח נשאר בחלון חדש ומאופס
            }
            else //במידה ולא הלקוח מועבר לחלון הבא 6
            {
                Form7 win7 = new Form7(totalPrice, TreatmentNames, TreatmentPrice, TreatmentCount);
                //תציג לי בחלון 7 את המחיר הכולל ואת כל סוגי הטיפולים שנבחרו
                win7.ShowDialog();
                this.Hide();
            }
        }

        private void ResetForm() //שיטה לאיפוס טופס
        {
            cmbTreatment.SelectedIndexChanged -= cmbTreatment_SelectedIndexChanged; //החזרת הטופס למצב ההתחלתי
            cmbTreatment.SelectedIndex = -1;
            cmbCode.Items.Clear(); //איפוס הפקדים
            cmbCode.Text = ""; //איפוס הפקדים
            dtpDate.Value = DateTime.Now; //איפוס הפקדים
            cmbHours.Items.Clear(); //איפוס הפקדים
            cmbThe.Items.Clear(); //איפוס הפקדים
            cmbThe.Text = ""; //איפוס הפקדים
            cmbTreatment.SelectedIndexChanged += cmbTreatment_SelectedIndexChanged; //הוספת הטופס החדש

        }

        public Form6()
        {
            InitializeComponent();
        }
    }
}



