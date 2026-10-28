using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Final_Attempt;

namespace Updated_Information_System_3
{
    [ToolboxItem(true)]
    public partial class ucVerifierVerifyCertificate : UserControl
    {
        public ucVerifierVerifyCertificate()
        {
            InitializeComponent();
        }
        private void SearchCertificate()
        {
            string certificateNumber = txtSearchBar.Text.Trim();

            if (string.IsNullOrWhiteSpace(certificateNumber))
            {
                MessageBox.Show(
                    "Please enter a certificate number.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string query = @"
        SELECT
            c.CERTIFICATE_NUMBER,
            c.HOLDER_FIRST_NAME,
            c.HOLDER_LAST_NAME,
            h.SCHOOL_NAME,
            ct.TYPE_NAME,
            c.STATUS
        FROM CERTIFICATE c
        INNER JOIN HIGH_SCHOOL h
            ON c.HIGH_SCHOOL_ID = h.HIGH_SCHOOL_ID
        INNER JOIN CERTIFICATE_TYPE ct
            ON c.CERTIFICATE_TYPE_ID = ct.CERTIFICATE_TYPE_ID
        WHERE c.CERTIFICATE_NUMBER = @CertificateNumber";

            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                using (var command = new Microsoft.Data.SqlClient.SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CertificateNumber", certificateNumber);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        dataGridView1.Rows.Clear();

                        if (reader.Read())
                        {
                            string certificateCode =
                                reader["CERTIFICATE_NUMBER"].ToString();

                            string learner =
                                reader["HOLDER_FIRST_NAME"].ToString() + " " +
                                reader["HOLDER_LAST_NAME"].ToString();

                            string highSchool =
                                reader["SCHOOL_NAME"].ToString();

                            string category =
                                reader["TYPE_NAME"].ToString();

                            string status =
                                reader["STATUS"].ToString();

                            dataGridView1.Rows.Add(
                                certificateCode,
                                learner,
                                highSchool,
                                category,
                                status);
                        }
                        else
                        {
                            MessageBox.Show(
                                "No certificate was found with that certificate number.",
                                "Certificate Not Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to search for the certificate:\n\n" + ex.Message,
                    "Search Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchCertificate();
        }
    }
}
