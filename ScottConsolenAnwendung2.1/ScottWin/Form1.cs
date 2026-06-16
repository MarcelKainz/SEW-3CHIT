using System;
using System.Windows.Forms;
using ScottWin;
using DBScott;
using System.ComponentModel;

namespace ScottWin
{
    public partial class Form1 : Form
    {
        DBAccess db = new DBAccess();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            ListViewDepartments.Columns.Add("DEPTNO", 100);
            ListViewDepartments.Columns.Add("DNAME", 120);
            ListViewDepartments.Columns.Add("LOC", 120);

            ListViewDepartments.View = View.Details;
            ListViewDepartments.FullRowSelect = true;

            LoadDepartments();
        }

        private void LoadDepartments()
        {
            ListViewDepartments.Items.Clear();
            string result = db.GetAllDepts();
            string[] all = result.Split("\n");
            foreach (string s in all)
            {
                if (string.IsNullOrWhiteSpace(s)) continue; // leere Zeilen überspringen
                string[] line = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (line.Length >= 3)
                {
                    var lvi = ListViewDepartments.Items.Add(line[0]); // DEPTNO
                    lvi.SubItems.Add(line[1]);                        // DNAME
                    lvi.SubItems.Add(line[2]);                        // LOC
                }
            }
            ListViewDepartments.View = View.Details;
        }

        private void ListViewDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewDepartments.SelectedItems.Count == 0) return;

            var selected = ListViewDepartments.SelectedItems[0];
            tbDeptNO.Text = selected.SubItems[0].Text;
            tbDNAME.Text = selected.SubItems[1].Text;
            tbLOC.Text = selected.SubItems[2].Text;
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbDeptNO.Text, out int deptno))
            {
                MessageBox.Show("DEPTNO muss eine Zahl sein!");
                return;
            }

            string dname = tbDNAME.Text.Trim();
            string loc = tbLOC.Text.Trim();

            if (dname == "" || loc == "")
            {
                MessageBox.Show("Bitte alle Felder ausfüllen.");
                return;
            }

            bool success = db.SaveDept(deptno, dname, loc);

            if (success)
            {
                MessageBox.Show("Gespeichert!");
                LoadDepartments();
            }
        }

        private void tbDEPTNO_TextChanged(object sender, EventArgs e)
        {
            // Optional: Validierung nur Zahlen zulassen
        }

        private void txtDNAME_TextChanged(object sender, EventArgs e) { }

        private void txtLOC_TextChanged(object sender, EventArgs e) { }


        private void Show_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        // Löschen eines Datensatzes basierend auf der eingetragenen Nummer
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try 
            {
                if (!string.IsNullOrEmpty(tbDeptNO.Text))
                {
                    int deptno = Convert.ToInt32(tbDeptNO.Text);
            
                    DBAccess db = new DBAccess();
                    db.DeleteDept(deptno);
            
                    MessageBox.Show($"Abteilung {deptno} wurde gelöscht.");
            
                    // Optional: Felder leeren und Liste aktualisieren
                    tbDeptNO.Clear();
                    tbDNAME.Clear();
                    tbLOC.Clear();
                    // Hier könntest du deine Methode aufrufen, die die ListView neu lädt
                }
                else
                {
                    MessageBox.Show("Bitte gib eine DEPTNO zum Löschen ein.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Löschen: " + ex.Message);
            }
        }

// Erstellen eines neuen Datensatzes
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // Daten aus den Textboxen holen
                int deptno = Convert.ToInt32(tbDeptNO.Text);
                string dname = tbDNAME.Text;
                string loc = tbLOC.Text;

                DBAccess db = new DBAccess();
                db.CreateDept(deptno, dname, loc);

                MessageBox.Show("Neue Abteilung erfolgreich angelegt!");
        
                // Liste aktualisieren wäre hier ratsam
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Erstellen: " + ex.Message);
            }
        }
    }
}