using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Updated_Information_System_3
{
    internal class ViewRequestFooter
    {
        public Panel Footer { get; set; }
        public Button CloseButton { get; set; }
        public Button RejectButton { get; set; }
        public Button ApproveButton { get; set; }
    }
    internal class ViewRequestStatus
    {
        public Label Caption { get; set; }
        public Label Value { get; set; }
        public Label Note { get; set; }
    }
    internal class ViewRequestBody
    {
        public Panel Body { get; set; }
        public GroupBox Organization { get; set; }
        public GroupBox Recipient { get; set; }
    }
    internal class ViewRequestIUI_Class
    {
        public static void ConfigureForm(Form form)
        {
            form.Text = "Request Details";
            form.Font = new Font("Segoe UI", 10);
            form.BackColor = Color.FromArgb(240, 240, 240);
            form.StartPosition = FormStartPosition.CenterParent;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.ShowInTaskbar = false;

            int height = Math.Min(
                745,
                Screen.PrimaryScreen.WorkingArea.Height - 20
            );

            form.Size = new Size(660, height);
        }

        public static Panel CreateHeader()
        {
            var header = new Panel
            {
                Dock = DockStyle.Top,
                Height = 76,
                BackColor = Color.FromArgb(0, 62, 64)
            };

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

            return header;
        }

        public static GroupBox MakeGroup(string title, int rows)
        {
            var group = new GroupBox
            {
                Text = title,
                Size = new Size(580, 34 + rows * 38)
            };

            group.Resize += (s, e) =>
            {
                foreach (Control control in group.Controls)
                {
                    if (control is TextBox)
                    {
                        control.Width = Math.Max(
                            120,
                            group.ClientSize.Width - control.Left - 18
                        );
                    }
                }
            };

            return group;
        }

        public static void AddRow(GroupBox group,int row,string label,string value)
        {
            int y = 28 + row * 38;
            group.Controls.Add(new Label
            {
                Text = label,
                AutoSize = true,
                Location = new Point(18, y + 4)
            });

            group.Controls.Add(new TextBox
            {
                Text = value,
                ReadOnly = true,
                BackColor = Color.White,
                Location = new Point(180, y),
                Width = 300,
                TabStop = false
            });
        }

        public static Button MakeButton(string text, Color color, int width)
        {
            var button = new Button
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

            button.FlatAppearance.BorderSize = 0;

            return button;
        }

        public static ViewRequestFooter CreateFooter(bool canReview)
        {
            var footer = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 68
            };

            var close = MakeButton("Close", Color.FromArgb(0, 62, 64), 130);
                
            var reject = MakeButton("Reject Request", Color.FromArgb(192, 0, 0), 170);
                
            var approve = MakeButton("Approve Request", Color.FromArgb(0, 128, 0), 170);
                

            close.Left = 24;

            if (!canReview)
            {
                approve.BackColor = Color.FromArgb(150, 195, 150);
                approve.Cursor = Cursors.Default;

                reject.BackColor = Color.FromArgb(215, 150, 150);
                reject.Cursor = Cursors.Default;
            }

            footer.Controls.Add(close);
            footer.Controls.Add(reject);
            footer.Controls.Add(approve);

            footer.Resize += (s, e) =>
            {
                approve.Left = footer.ClientSize.Width - 24 - approve.Width;
                reject.Left = approve.Left - 12 - reject.Width;
            };

            return new ViewRequestFooter
            {
                Footer = footer,
                CloseButton = close,
                RejectButton = reject,
                ApproveButton = approve
            };
        }


        public static ViewRequestStatus CreateStatusSection(
            string status,
            bool canReview,
            int statusY)
        {
            var statusCaption = new Label
            {
                Text = "Status",
                AutoSize = true,
                Location = new Point(42, statusY)
            };

            var statusValue = new Label
            {
                Text = status,
                ForeColor = status == "APPROVED"
                    ? Color.FromArgb(0, 128, 0)
                    : status == "REJECTED"
                        ? Color.FromArgb(192, 0, 0)
                        : Color.FromArgb(200, 120, 0),
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(204, statusY - 2)
            };

            var statusNote = new Label
            {
                Text = canReview
                    ? ""
                    : "This request has already been " + status.ToLower()
                      + " and cannot be reviewed again.",
                ForeColor = Color.FromArgb(90, 90, 90),
                Font = new Font("Segoe UI", 9),
                AutoSize = true,
                Location = new Point(204, statusY + 26)
            };

            return new ViewRequestStatus
            {
                Caption = statusCaption,
                Value = statusValue,
                Note = statusNote
            };
        }

        public static GroupBox CreateOrganizationInfoGroup(
            string emis,string name,string email,string telephone,string address,string province,string organizationType)
        {
            var info = MakeGroup("School / Organization Information", 7);

            AddRow(info, 0, "EMIS Number", emis);
            AddRow(info, 1, "Name", name);
            AddRow(info, 2, "Email Address", email);
            AddRow(info, 3, "Telephone", telephone);
            AddRow(info, 4, "Address", address);
            AddRow(info, 5, "Province", province);
            AddRow(info, 6, "Organization Type", organizationType);

            info.Location = new Point(24, 18);

            return info;
        }

        public static GroupBox CreateRecipientInfoGroup(string recipientName,string recipientRole,string recipientEmail)

        {
            var creds = MakeGroup("Who Receives The Login Credentials", 3);

            AddRow(creds, 0, "Recipient Name", recipientName);
            AddRow(creds, 1, "Recipient Role", recipientRole);
            AddRow(creds, 2, "Recipient Email", recipientEmail);

            return creds;
        }

        public static ViewRequestBody CreateBody(string emis,string name,string email,string telephone,string address,string province,
            string organizationType,string recipientName,string recipientRole, string recipientEmail,string status, bool canReview)
        {
            var body = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                AutoScrollMargin = new Size(0, 16)
            };

            var organization = CreateOrganizationInfoGroup(
                emis, name, email, telephone, address, province, organizationType);

            var recipient = CreateRecipientInfoGroup(
                recipientName, recipientRole, recipientEmail);

            recipient.Location = new Point(24, organization.Bottom + 22);

            int statusY = recipient.Bottom + 26;

            var statusControls = CreateStatusSection(status, canReview, statusY);

            body.Controls.Add(organization);
            body.Controls.Add(recipient);
            body.Controls.Add(statusControls.Caption);
            body.Controls.Add(statusControls.Value);
            body.Controls.Add(statusControls.Note);

            body.Resize += (s, e) =>
            {
                int width = Math.Max(300, body.ClientSize.Width - 48);
                organization.Width = width;
                recipient.Width = width;
            };

            return new ViewRequestBody
            {
                Body = body,
                Organization = organization,
                Recipient = recipient
            };
        }
    }
}
