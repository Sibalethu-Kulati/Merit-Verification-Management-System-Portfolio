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
    public partial class ucVerifierHighSchools : UserControl
    {
        public ucVerifierHighSchools()
        {
            InitializeComponent();
        }
        private void LoadHighSchools()
        {
            string query = @"
        SELECT
            h.EMIS_NO,
            h.SCHOOL_NAME,
            h.EMAIL,
            h.PHONE,
            CONCAT(
                a.STREET_NUMBER, ' ',
                a.STREET_NAME, ', ',
                COALESCE(a.SUBURB + ', ', ''),
                c.CITY_NAME, ', ',
                c.PROVINCE, ' ',
                a.POSTAL_CODE
            ) AS FULL_ADDRESS
        FROM HIGH_SCHOOL h
        INNER JOIN ADDRESS a
            ON h.ADDRESS_ID = a.ADDRESS_ID
        INNER JOIN CITY c
            ON a.CITY_ID = c.CITY_ID";

            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                using (var command = new Microsoft.Data.SqlClient.SqlCommand(query, connection))
                {
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        dgvHighSchools.Rows.Clear();

                        while (reader.Read())
                        {
                            dgvHighSchools.Rows.Add(
                                reader["EMIS_NO"].ToString(),
                                reader["SCHOOL_NAME"].ToString(),
                                reader["EMAIL"].ToString(),
                                reader["PHONE"].ToString(),
                                reader["FULL_ADDRESS"].ToString()
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load high schools:\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ucVerifierHighSchools_Load(object sender, EventArgs e)
        {
            LoadHighSchools();
        }

        private void dgvHighSchools_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
