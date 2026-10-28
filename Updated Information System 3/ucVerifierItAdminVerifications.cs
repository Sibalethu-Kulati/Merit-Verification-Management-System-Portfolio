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
    public partial class ucVerifierItAdminVerifications : UserControl
    {
        public ucVerifierItAdminVerifications()
        {
            InitializeComponent();
        }
        private void LoadVerifications()
        {
            string query = @"SELECT VR.VERIFICATION_ID,
                            VR.SEARCHED_CERT_NUMBER,
                            VR.HIGH_SCHOOL_ID,
                            VR.VERIFIER_REP_ID,
                            VR.REQUEST_DATE,
                            VR.STATUS
                     FROM VERIFICATION_REQUEST VR
                     WHERE VR.ORG_ID = (SELECT ORG_ID
                                        FROM ORG_IT_ADMIN
                                        WHERE PERSON_ID = @PersonId)
                     ORDER BY VR.REQUEST_DATE DESC";

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            using (var da = new SqlDataAdapter(query, conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@PersonId", UserSession.PersonId);

                var dt = new DataTable();
                da.Fill(dt);
                dgvHighSchools.DataSource = dt;
            }
        }

        private void dgvHighSchools_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ucVerifierItAdminVerifications_Load(object sender, EventArgs e)
        {
            LoadVerifications();
        }
    }
}
