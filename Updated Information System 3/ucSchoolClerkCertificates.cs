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

    public partial class ucSchoolClerkCertificates : UserControl
    {


        public ucSchoolClerkCertificates()
        {
            InitializeComponent();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OpenCertificateForm(new ucSchoolClerk_AddCertificate(), "Add Certificate");
        }
        private void ucSchoolClerkCertificates_Load(object sender, EventArgs e)
        {

        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void OpenCertificateForm(ucSchoolClerk_AddCertificate form, string title)
        {
            using (form)
            using (var dialog = new Form())
            {
                dialog.Text = title;
                dialog.StartPosition = FormStartPosition.CenterParent;
                dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
                dialog.MaximizeBox = false;
                dialog.MinimizeBox = false;
                dialog.ShowInTaskbar = false;
                dialog.ClientSize = form.Size;

                form.Dock = DockStyle.Fill;
                dialog.Controls.Add(form);
                dialog.ShowDialog(this);
            }
            LoadGrid();
        }
        private void LoadGrid()
        {
            ApplicationDatabase.LoadCertificates(dataGridView1);

            dataGridView1.Columns["HOLDER_FIRST_NAME"].HeaderText = "First Name";
            dataGridView1.Columns["HOLDER_LAST_NAME"].HeaderText = "Last Name";
            dataGridView1.Columns["TITLE"].HeaderText = "Certificate Title";
            dataGridView1.Columns["CERTIFICATE_NUMBER"].HeaderText = "Certificate Code";
            dataGridView1.Columns["TYPE_NAME"].HeaderText = "Category";
            dataGridView1.Columns["ISSUE_DATE"].HeaderText = "Issue Date";
            dataGridView1.Columns["FILE_NAME"].HeaderText = "Uploaded Certificate";
            dataGridView1.Columns["CERTIFICATE_ID"].Visible = false;
        }


        private void ucSchoolClerkCertificates_Load_1(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            ApplicationDatabase.LoadCertificates(dataGridView1);

            LoadGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                picPreview.Image = null;
                return;
            }

            string certNo = dataGridView1.CurrentRow.Cells["CERTIFICATE_NUMBER"].Value?.ToString();
            if (string.IsNullOrEmpty(certNo)) return;

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            using (var cmd = new SqlCommand(
                "SELECT FILE_DATA FROM CERTIFICATE WHERE CERTIFICATE_NUMBER = @n", conn))
            {
                cmd.Parameters.AddWithValue("@n", certNo);
                conn.Open();

                if (cmd.ExecuteScalar() is byte[] bytes && bytes.Length > 0)
                {
                    try
                    {
                        using (var ms = new System.IO.MemoryStream(bytes))
                            picPreview.Image = new Bitmap(Image.FromStream(ms));
                    }
                    catch
                    {
                        picPreview.Image = null; // PDF or unreadable image
                    }
                }
                else picPreview.Image = null;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Select a certificate first.");
                return;
            }

            int certId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CERTIFICATE_ID"].Value);
            OpenCertificateForm(new ucSchoolClerk_AddCertificate(certId), "Update Certificate");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Select a certificate first.");
                return;
            }

            int certId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CERTIFICATE_ID"].Value);
            string code = dataGridView1.CurrentRow.Cells["CERTIFICATE_NUMBER"].Value.ToString();

            if (MessageBox.Show($"Delete certificate {code}? This cannot be undone.", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            if (ApplicationDatabase.DeleteCertificate(certId, out string message))
            {
                picPreview.Image = null;
                LoadGrid();
            }
            else if (message != "")
                MessageBox.Show(message);
        }
    }
}
