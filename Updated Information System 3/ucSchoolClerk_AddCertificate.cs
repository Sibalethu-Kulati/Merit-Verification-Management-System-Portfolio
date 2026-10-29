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
        private int? editCertificateId = null;

        public ucSchoolClerk_AddCertificate(int certificateId) : this()
        {
            editCertificateId = certificateId;
        }
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
            if (editCertificateId.HasValue) LoadForEdit();
        }
        private void SaveEdit(string code, string title)
        {
            byte[] fileData = null;
            string fileName = null, contentType = null;

            if (!string.IsNullOrEmpty(selectedFilePath))
            {
                fileData = File.ReadAllBytes(selectedFilePath);
                if (fileData.Length > 5 * 1024 * 1024)
                {
                    MessageBox.Show("File is too large. Maximum size is 5 MB.");
                    return;
                }
                fileName = Path.GetFileName(selectedFilePath);
                contentType = Path.GetExtension(selectedFilePath).ToLower() switch
                {
                    ".png" => "image/png",
                    ".jpg" or ".jpeg" => "image/jpeg",
                    ".pdf" => "application/pdf",
                    _ => "application/octet-stream"
                };
            }

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    using (var check = new SqlCommand(
                        @"SELECT COUNT(*) FROM CERTIFICATE
                  WHERE CERTIFICATE_NUMBER = @code AND CERTIFICATE_ID <> @id", conn))
                    {
                        check.Parameters.AddWithValue("@code", code);
                        check.Parameters.AddWithValue("@id", editCertificateId.Value);
                        if ((int)check.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("Another certificate already uses this code.");
                            return;
                        }
                    }

                    using (var cmd = new SqlCommand(@"
                UPDATE CERTIFICATE SET
                    CERTIFICATE_NUMBER  = @code,
                    TITLE               = @title,
                    CERTIFICATE_TYPE_ID = @type,
                    ISSUE_DATE          = @date,
                    FILE_NAME           = COALESCE(@fname, FILE_NAME),
                    FILE_CONTENT_TYPE   = COALESCE(@ctype, FILE_CONTENT_TYPE),
                    FILE_DATA           = COALESCE(@fdata, FILE_DATA),
                    UPDATED_AT          = SYSDATETIME(),
                    UPDATED_BY          = @by
                WHERE CERTIFICATE_ID = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@code", code);
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@type", comboBox2.SelectedValue);
                        cmd.Parameters.AddWithValue("@date", dtpIssueDate.Value.Date);
                        cmd.Parameters.AddWithValue("@fname", (object)fileName ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ctype", (object)contentType ?? DBNull.Value);
                        cmd.Parameters.Add("@fdata", SqlDbType.VarBinary, -1).Value =
                            (object)fileData ?? DBNull.Value;
                        cmd.Parameters.AddWithValue("@by", UserSession.PersonId);
                        cmd.Parameters.AddWithValue("@id", editCertificateId.Value);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Certificate updated successfully.");
                this.ParentForm?.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadForEdit()
        {
            string sql = @"SELECT c.CERTIFICATE_NUMBER, c.TITLE, c.CERTIFICATE_TYPE_ID,
                          c.ISSUE_DATE, c.FILE_NAME, l.REGISTER_ID
                   FROM CERTIFICATE c
                   LEFT JOIN LEARNER_REGISTER l
                          ON l.SA_ID_NUMBER = c.HOLDER_ID_NUMBER
                         AND l.HIGH_SCHOOL_ID = c.HIGH_SCHOOL_ID
                   WHERE c.CERTIFICATE_ID = @id";

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", editCertificateId.Value);
                conn.Open();

                using (var r = cmd.ExecuteReader())
                {
                    if (!r.Read()) return;

                    textBox1.Text = r["CERTIFICATE_NUMBER"].ToString();
                    textBox2.Text = r["TITLE"].ToString();
                    comboBox2.SelectedValue = r["CERTIFICATE_TYPE_ID"];
                    dtpIssueDate.Value = Convert.ToDateTime(r["ISSUE_DATE"]);
                    lblFileName.Text = r["FILE_NAME"].ToString();

                    if (r["REGISTER_ID"] != DBNull.Value)
                        comboBox1.SelectedValue = r["REGISTER_ID"];
                    comboBox1.Enabled = false; // holder is locked
                }
            }

            btn_AddCetificate_schoolClerk.Text = "Save Changes";
        }
        private void LoadCategories()
        {
            string query = "SELECT CERTIFICATE_TYPE_ID, TYPE_NAME FROM CERTIFICATE_TYPE ORDER BY TYPE_NAME";

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
                                             FROM SCHOOL_CLERK
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
            if (editCertificateId.HasValue)
            {
                SaveEdit(code, title);
                return;
            }

            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Please attach the physical certificate copy.");
                return;
            }
            byte[] fileData = File.ReadAllBytes(selectedFilePath);
            //S.Kulati how the file_content_type is determined
            string contentType = Path.GetExtension(selectedFilePath).ToLower() switch
            {
                ".png" => "image/png",
                ".jpg" or ".jpeg" => "image/jpeg",
                ".pdf" => "application/pdf",
                _ => "application/octet-stream"
            };

            string fileName = System.IO.Path.GetFileName(selectedFilePath);

            if (fileData.Length > 5 * 1024 * 1024)
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
                        "SELECT COUNT(*) FROM CERTIFICATE WHERE CERTIFICATE_NUMBER = @code", conn))
                    {
                        check.Parameters.AddWithValue("@code", code);
                        if ((int)check.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("This certificate code already exists.");
                            return;
                        }
                    }

                    using (var cmd = new SqlCommand(@"INSERT INTO CERTIFICATE (HIGH_SCHOOL_ID, CERTIFICATE_TYPE_ID, HOLDER_ID_NUMBER,
                                HOLDER_FIRST_NAME, HOLDER_LAST_NAME, ISSUE_DATE, CERTIFICATE_NUMBER, TITLE,
                                FILE_NAME, FILE_CONTENT_TYPE, FILE_DATA)
                                SELECT HIGH_SCHOOL_ID, @type, SA_ID_NUMBER, FIRST_NAME,
                                       LAST_NAME, @date, @code, @title,
                                       @fname, @FileContentType, @fdata
                                FROM LEARNER_REGISTER
                                WHERE REGISTER_ID = @reg", conn))
                                    
                                    
                                  
                    {
                        cmd.Parameters.AddWithValue("@reg", comboBox1.SelectedValue);
                        cmd.Parameters.AddWithValue("@type", comboBox2.SelectedValue);
                        cmd.Parameters.AddWithValue("@code", code);
                        cmd.Parameters.AddWithValue("@date", dtpIssueDate.Value.Date);
                        cmd.Parameters.AddWithValue("@fname", fileName);
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@FileContentType", contentType);
                       
                        cmd.Parameters.Add("@fdata", SqlDbType.VarBinary, -1).Value = fileData;
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Certificate added successfully.");
                //ApplicationDatabase.LoadCertificates(ucSchoolClerkCertificates.dataGridView1);
                this.ParentForm?.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
 }
