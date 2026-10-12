#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Updated_Information_System_3
{
    // Pop-up shown when the admin clicks "View Request".
    // UI only: the fields start empty. The controls are built in code,
    // so there is nothing to drag and drop on this form.
    public partial class viewRequest_SystemAdmin : Form
    {
        private static readonly Color Teal = Color.FromArgb(0, 62, 64);
        private static readonly Color Green = Color.FromArgb(0, 128, 0);
        private static readonly Color Red = Color.FromArgb(192, 0, 0);
        private static readonly Color Amber = Color.FromArgb(200, 120, 0);

        // The application's status as stored in the database:
        // PENDING, APPROVED or REJECTED.
        private readonly string _status;

        // A request can only be approved or rejected while it is still PENDING.
        private readonly bool _canReview;

        // Used by the designer and by plain "new viewRequest_SystemAdmin()" calls.
        public viewRequest_SystemAdmin() : this(status: "PENDING")
        {
        }

        public viewRequest_SystemAdmin(
            string emis = "",
            string name = "",
            string email = "",
            string telephone = "",
            string address = "",
            string province = "",
            string organizationType = "",
            string recipientName = "",
            string recipientRole = "",
            string recipientEmail = "",
            string status = "PENDING")
        {
            InitializeComponent();   // keep: created by the designer

            _status = (status ?? "PENDING").ToUpper();
            _canReview = _status == "PENDING";

            Text = "Request Details";
            Font = new Font("Segoe UI", 10);
            BackColor = Color.FromArgb(240, 240, 240);
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;

            // Tall enough to breathe, but never taller than the screen.
            int height = Math.Min(745, Screen.PrimaryScreen.WorkingArea.Height - 20);
            Size = new Size(660, height);

            // ----- Teal header -----
            var header = new Panel { Dock = DockStyle.Top, Height = 76, BackColor = Teal };
            header.Controls.Add(new Label
            {
                Text = "Request Details",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(24, 10)
            });
            header.Controls.Add(new Label
            {
                Text = "Review the request before approving or rejecting it",
                ForeColor = Color.FromArgb(180, 220, 215),
                Font = new Font("Segoe UI", 9),
                AutoSize = true,
                Location = new Point(26, 46)
            });

            // ----- Body: two group boxes + status -----
            var body = new Panel { Dock = DockStyle.Fill, AutoScroll = true };
            body.AutoScrollMargin = new Size(0, 16);

            var info = MakeGroup("School / Organization Information", 7);
            AddRow(info, 0, "EMIS Number", emis);
            AddRow(info, 1, "Name", name);
            AddRow(info, 2, "Email Address", email);
            AddRow(info, 3, "Telephone", telephone);
            AddRow(info, 4, "Address", address);
            AddRow(info, 5, "Province", province);
            AddRow(info, 6, "Organization Type", organizationType);
            info.Location = new Point(24, 18);

            var creds = MakeGroup("Who Receives The Login Credentials", 3);
            AddRow(creds, 0, "Recipient Name", recipientName);
            AddRow(creds, 1, "Recipient Role", recipientRole);
            AddRow(creds, 2, "Recipient Email", recipientEmail);
            creds.Location = new Point(24, info.Bottom + 22);

            int statusY = creds.Bottom + 26;
            var statusCaption = new Label { Text = "Status", AutoSize = true, Location = new Point(42, statusY) };
            var statusValue = new Label
            {
                Text = _status,
                ForeColor = _status == "APPROVED" ? Green : _status == "REJECTED" ? Red : Amber,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(204, statusY - 2)
            };
            var statusNote = new Label
            {
                Text = _canReview ? "" : "This request has already been " + _status.ToLower() + " and cannot be reviewed again.",
                ForeColor = Color.FromArgb(90, 90, 90),
                Font = new Font("Segoe UI", 9),
                AutoSize = true,
                Location = new Point(204, statusY + 26)
            };

            body.Controls.Add(info);
            body.Controls.Add(creds);
            body.Controls.Add(statusCaption);
            body.Controls.Add(statusValue);
            body.Controls.Add(statusNote);

            // Stretch the group boxes to the body width whenever it changes.
            body.Resize += (s, e) =>
            {
                int w = Math.Max(300, body.ClientSize.Width - 48);
                info.Width = w;
                creds.Width = w;
            };

            // ----- Footer: Close on the left, Reject + Approve on the right -----
            var footer = new Panel { Dock = DockStyle.Bottom, Height = 68 };
            var close = MakeButton("Close", Teal, 130);
            var reject = MakeButton("Reject Request", Red, 170);
            var approve = MakeButton("Approve Request", Green, 170);
            close.Left = 24;
            if (!_canReview)
            {
                // Both buttons look greyed out once the request has been decided.
                approve.BackColor = Color.FromArgb(150, 195, 150);
                approve.Cursor = Cursors.Default;
                reject.BackColor = Color.FromArgb(215, 150, 150);
                reject.Cursor = Cursors.Default;
            }
            footer.Controls.Add(close);
            footer.Controls.Add(reject);
            footer.Controls.Add(approve);

            // Positioned from the footer's real width, so they can't end up off-screen.
            footer.Resize += (s, e) =>
            {
                approve.Left = footer.ClientSize.Width - 24 - approve.Width;
                reject.Left = approve.Left - 12 - reject.Width;
            };

            close.Click += (s, e) => DialogResult = DialogResult.Cancel;

            reject.Click += (s, e) =>
            {
                if (!_canReview)
                {
                    MessageBox.Show("This request has already been " + _status.ToLower() + ".", "Cannot reject",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Reject this request?", "Confirm",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
                MessageBox.Show("Request rejected.", "Done",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.No;
            };

            approve.Click += (s, e) =>
            {
                if (!_canReview)
                {
                    MessageBox.Show("This request has already been " + _status.ToLower() + ".", "Cannot approve",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MessageBox.Show("Request approved.", "Done",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.Yes;
            };

            // Fill goes in first so the Top and Bottom panels claim their space before it.
            Controls.Add(body);
            Controls.Add(header);
            Controls.Add(footer);
        }

        // Keep this method: the designer may be wired to it.
        private void viewRequest_SystemAdmin_Load(object sender, EventArgs e)
        {
        }

        private static GroupBox MakeGroup(string title, int rows)
        {
            var g = new GroupBox { Text = title, Size = new Size(580, 34 + rows * 38) };
            g.Resize += (s, e) =>
            {
                foreach (Control c in g.Controls)
                    if (c is TextBox)
                        c.Width = Math.Max(120, g.ClientSize.Width - c.Left - 18);
            };
            return g;
        }

        private static void AddRow(GroupBox g, int row, string label, string value)
        {
            int y = 28 + row * 38;
            g.Controls.Add(new Label { Text = label, AutoSize = true, Location = new Point(18, y + 4) });
            g.Controls.Add(new TextBox
            {
                Text = value,
                ReadOnly = true,
                BackColor = Color.White,
                Location = new Point(180, y),
                Width = 300,
                TabStop = false
            });
        }

        private static Button MakeButton(string text, Color color, int width)
        {
            var b = new Button
            {
                Text = text,
                Size = new Size(width, 40),
                Location = new Point(0, 14),
                BackColor = color,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            b.FlatAppearance.BorderSize = 0;
            return b;
        }
    }
}