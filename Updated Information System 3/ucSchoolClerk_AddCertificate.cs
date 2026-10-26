using Final_Attempt;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Updated_Information_System_3
{
    public partial class ucSchoolClerk_AddCertificate : UserControl
    {
        public ucSchoolClerk_AddCertificate()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void lnkBacktoCertificates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigationClass.openUserControl(ucToOpen: new ucSchoolClerkCertificates(), parentContainer: this);
        }

        private void ucSchoolClerk_AddCertificate_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadCategories();
        }
        private void LoadCategories()
        {
            string query = "SELECT CERTIFICATE_TYPE_ID, TYPE_NAME FROM CERTIFICATE_TYPES ORDER BY TYPE_NAME";

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            using (var da = new SqlDataAdapter(query, conn))
            {
                var dt = new DataTable();
                da.Fill(dt);

                comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "TYPE_NAME";
                comboBox2.ValueMember = "CERTIFICATE_TYPE_ID";
                comboBox2.SelectedIndex = -1;
            }
        }
        private void LoadStudents()
        {
            string query = @"SELECT REGISTER_ID, FIRST_NAME + ' ' + LAST_NAME AS FullName
                     FROM LEARNER_REGISTER
                     WHERE HIGH_SCHOOL_ID = (SELECT HIGH_SCHOOL_ID
                                             FROM SCHOOL_CLERKS
                                             WHERE PERSON_ID = @PersonId)
                     ORDER BY FullName";

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            using (var da = new SqlDataAdapter(query, conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@PersonId", UserSession.PersonId);

                var dt = new DataTable();
                da.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "FullName";
                comboBox1.ValueMember = "REGISTER_ID";
                comboBox1.SelectedIndex = -1;
            }
        }
        private string selectedFilePath = "";
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Certificate Copy";
                ofd.Filter = "Certificate files|*.pdf;*.jpg;*.jpeg;*.png|All files|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePath = ofd.FileName;
                    lblFileName.Text = System.IO.Path.GetFileName(selectedFilePath);
                }
            }
        }

            private void btn_AddCetificate_schoolClerk_Click(object sender, EventArgs e)
        {
            string code = textBox1.Text.Trim();
            string title = textBox2.Text.Trim();

            if (comboBox1.SelectedIndex == -1 || code == "" || title == "" || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Please attach the physical certificate copy.");
                return;
            }

            byte[] fileBytes = System.IO.File.ReadAllBytes(selectedFilePath);
            string fileName = System.IO.Path.GetFileName(selectedFilePath);

            if (fileBytes.Length > 5 * 1024 * 1024)
            {
                MessageBox.Show("File is too large. Maximum size is 5 MB.");
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    using (var check = new SqlCommand(
                        "SELECT COUNT(*) FROM CERTIFICATES WHERE CERTIFICATE_NUMBER = @code", conn))
                    {
                        check.Parameters.AddWithValue("@code", code);
                        if ((int)check.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("This certificate code already exists.");
                            return;
                        }
                    }

                    using (var cmd = new SqlCommand(
     @"INSERT INTO CERTIFICATES
        (HIGH_SCHOOL_ID, CERTIFICATE_TYPE_ID, HOLDER_ID_NUMBER, HOLDER_FIRST_NAME,
         HOLDER_LAST_NAME, ISSUE_DATE, CERTIFICATE_NUMBER, FILE_NAME, FILE_DATA)
      SELECT HIGH_SCHOOL_ID, @type, SA_ID_NUMBER, FIRST_NAME,
             LAST_NAME, @date, @code, @fname, @fdata
      FROM LEARNER_REGISTER
      WHERE REGISTER_ID = @reg", conn))
                    {
                        cmd.Parameters.AddWithValue("@reg", comboBox1.SelectedValue);
                        cmd.Parameters.AddWithValue("@type", comboBox2.SelectedValue);
                        cmd.Parameters.AddWithValue("@code", code);
                        cmd.Parameters.AddWithValue("@date", dtpIssueDate.Value.Date);
                        cmd.Parameters.AddWithValue("@fname", fileName);
                        cmd.Parameters.Add("@fdata", SqlDbType.VarBinary, -1).Value = fileBytes;
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Certificate added successfully.");
                this.ParentForm?.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
 }
