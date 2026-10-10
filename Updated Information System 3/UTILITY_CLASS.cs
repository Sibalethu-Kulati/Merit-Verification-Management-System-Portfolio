#nullable disable
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Updated_Information_System_3
{
    internal class UTILITY_CLASS
    {
        // ---------------------------------------------------------------
        //  Your existing methods
        // ---------------------------------------------------------------

        // FIXED: the old version had the line  formToOpen = new Form();
        // which threw away the form you passed in and opened an empty one.
        public static void openForm(Form formToOpen, Form formToClose)
        {
            formToClose.Hide();
            formToOpen.Show();
        }

        public static void logOut()
        {
            UserSession.Clear();
            Application.Restart();
        }

        public static void openUserControl(UserControl ucToOpen, Control parentContainer)
        {
            foreach (Control ctrl in parentContainer.Controls)
            {
                if (ctrl is UserControl && ctrl != ucToOpen)
                {
                    ctrl.Hide();
                }
            }
            ucToOpen.Show();
            ucToOpen.BringToFront();
        }

        public static T addUserControl<T>(Control parentContainer, Control sidebar) where T : UserControl, new()
        {
            T userControl = new T();

            int rightX = sidebar.Width;

            userControl.Location = new Point(rightX, 0);
            userControl.Size = new Size
                (
                    parentContainer.ClientSize.Width - rightX,
                    parentContainer.ClientSize.Height
                );

            parentContainer.Controls.Add(userControl);

            return userControl;
        }

        // ---------------------------------------------------------------
        //  REQUEST ACCESS WIZARD (new)
        //  Call it from the Sign In form:   UTILITY_CLASS.openRequestAccess(this);
        //  The whole form is built in code, so no form file is needed.
        //  UI only: no validation, no database.
        // ---------------------------------------------------------------

        private static readonly Color RaTealBg = Color.FromArgb(0, 139, 139);    // form background
        private static readonly Color RaTealBtn = Color.FromArgb(0, 128, 128);   // buttons and progress bar

        public static void openRequestAccess(Form signInForm)
        {
            var form = new Form
            {
                Text = "Request Access",
                Font = new Font("Segoe UI", 10),
                AutoScaleDimensions = new SizeF(96F, 96F),
                AutoScaleMode = AutoScaleMode.Dpi,
                BackColor = RaTealBg,
                StartPosition = FormStartPosition.CenterScreen,
                Size = new Size(1213, 738)
            };

            string[] subtitles =
            {
                "Step 1 of 3 \u2013 Organization details",
                "Step 2 of 3 \u2013 Login credentials",
                "Step 3 of 3 \u2013 Review and submit"
            };
            string[] legends =
            {
                "Organization details",
                "Who will receive the login credentials?",
                "Review your request"
            };
            int index = 0;

            // ----- Inputs -----
            var type = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList };
            type.Items.AddRange(new object[] { "High School", "Verifying Organization" });
            type.SelectedIndex = 0;
            var emis = new TextBox();
            var name = new TextBox();
            var address = new TextBox();
            var province = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList };
            province.Items.AddRange(new object[]
            {
                "Eastern Cape", "Free State", "Gauteng", "KwaZulu-Natal", "Limpopo",
                "Mpumalanga", "North West", "Northern Cape", "Western Cape"
            });
            var email = new TextBox();
            var tel = new TextBox();

            var role = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList };
            role.Items.AddRange(new object[] { "IT Admin", "Principal" });
            role.SelectedIndex = 0;
            var rName = new TextBox();
            var rSurname = new TextBox();
            var rEmail = new TextBox();
            var rPhone = new TextBox();

            // Verifying organizations have no EMIS number.
            type.SelectedIndexChanged += (s, e) =>
            {
                bool org = type.SelectedIndex == 1;
                emis.Enabled = !org;
                emis.PlaceholderText = org ? "Not required" : "";
                if (org) emis.Clear();
            };

            // ----- Card, banner, progress bar -----
            var card = new Panel
            {
                Size = new Size(780, 640),
                BackColor = Color.FromArgb(240, 240, 240),
                Padding = new Padding(24),
                BorderStyle = BorderStyle.FixedSingle
            };

            var title = new Label
            {
                Text = "REQUEST ACCESS",
                Dock = DockStyle.Top,
                Height = 46,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 15, FontStyle.Bold),
                ForeColor = Color.Black
            };
            var stepText = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.TopCenter,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.FromArgb(68, 68, 68)
            };
            var banner = new Panel { Dock = DockStyle.Top, Height = 78, BackColor = Color.FromArgb(230, 230, 250) };
            banner.Controls.Add(stepText);   // Fill first,
            banner.Controls.Add(title);      // then Top

            var track = new Panel { Dock = DockStyle.Top, Height = 4, BackColor = Color.FromArgb(215, 215, 215) };
            var bar = new Panel { Dock = DockStyle.Left, BackColor = RaTealBtn };
            track.Controls.Add(bar);

            var grp = new GroupBox
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(18, 14, 18, 8),
                Font = new Font("Segoe UI Semibold", 10)   // bold title, same as the labels
            };
            var review = new Label { Dock = DockStyle.Fill, Font = new Font("Consolas", 10.5f) };

            // ----- Footer: link on the left, Back + Next on the right -----
            var footer = new Panel { Dock = DockStyle.Bottom, Height = 64 };
            var link = new LinkLabel
            {
                Text = "Back to Sign In",
                AutoSize = true,
                Location = new Point(0, 20),
                LinkColor = RaTealBg,
                ActiveLinkColor = RaTealBtn,
                VisitedLinkColor = RaTealBg,
                LinkBehavior = LinkBehavior.AlwaysUnderline,
                Font = new Font("Segoe UI Semibold", 10)
            };
            var back = RaMakeButton("Back", 120, false);
            var next = RaMakeButton("Next", 160, true);
            footer.Controls.Add(link);
            footer.Controls.Add(back);
            footer.Controls.Add(next);

            // Positioned from the footer's real width every time it resizes.
            footer.Resize += (s, e) =>
            {
                next.Left = footer.ClientSize.Width - next.Width;
                back.Left = next.Left - 12 - back.Width;
            };

            // Docked in this order: the last Top/Bottom control added sits outermost.
            var spacerTop = new Panel { Dock = DockStyle.Top, Height = 20 };
            var spacerBottom = new Panel { Dock = DockStyle.Bottom, Height = 14 };
            card.Controls.Add(grp);
            card.Controls.Add(spacerTop);
            card.Controls.Add(track);
            card.Controls.Add(banner);
            card.Controls.Add(spacerBottom);
            card.Controls.Add(footer);
            form.Controls.Add(card);

            // ----- Pages (all built now, only one visible at a time) -----
            var pages = new Panel[3];
            pages[0] = RaMakePage(
                ("Organization type", type), ("EMIS number", emis),
                ("School / organization name", name), ("Address", address),
                ("Province", province), ("Email address", email), ("Telephone", tel));

            pages[1] = new Panel();
            pages[1].Controls.Add(RaMakePage(
                ("Role", role), ("Name", rName), ("Surname", rSurname),
                ("Email address", rEmail), ("Phone number", rPhone)));
            pages[1].Controls.Add(new Label
            {
                Dock = DockStyle.Top,
                Height = 56,
                ForeColor = Color.FromArgb(90, 90, 90),
                Font = new Font("Segoe UI", 9, FontStyle.Italic),
                Text = "The principal decides who manages the system. This person receives the " +
                       "username and password once the request is approved."
            });

            pages[2] = new Panel();
            pages[2].Controls.Add(review);

            foreach (var page in pages)
            {
                page.Dock = DockStyle.Fill;
                page.Visible = false;
                grp.Controls.Add(page);
            }

            // ----- Behaviour -----
            void UpdateBar() => bar.Width = track.ClientSize.Width * (index + 1) / 3;

            void CenterCard()
            {
                card.Left = Math.Max(0, (form.ClientSize.Width - card.Width) / 2);
                card.Top = Math.Max(0, (form.ClientSize.Height - card.Height) / 2);
            }

            void ShowPage(int i)
            {
                index = i;
                for (int p = 0; p < pages.Length; p++)
                    pages[p].Visible = (p == i);

                stepText.Text = subtitles[i];
                grp.Text = legends[i];
                back.Visible = i > 0;
                next.Text = i == 2 ? "Submit Request" : "Next";
                UpdateBar();

                if (i == 2)
                {
                    bool org = type.SelectedIndex == 1;
                    review.Text =
                        "Organization type:  " + type.Text + "\n" +
                        "EMIS number:        " + (org ? "Not required" : emis.Text) + "\n" +
                        "Name:               " + name.Text + "\n" +
                        "Address:            " + address.Text + (province.Text.Length > 0 ? ", " + province.Text : "") + "\n" +
                        "Email address:      " + email.Text + "\n" +
                        "Telephone:          " + tel.Text + "\n\n" +
                        "Credentials go to:  " + rName.Text + " " + rSurname.Text + " (" + role.Text + ")\n" +
                        "Email address:      " + rEmail.Text + "\n" +
                        "Phone number:       " + rPhone.Text;
                }
            }

            track.Resize += (s, e) => UpdateBar();
            back.Click += (s, e) => ShowPage(index - 1);
            link.LinkClicked += (s, e) => form.Close();

            next.Click += (s, e) =>
            {
                if (index < 2)
                {
                    ShowPage(index + 1);
                    return;
                }

                string where = string.IsNullOrWhiteSpace(rEmail.Text) ? "the address you gave" : rEmail.Text.Trim();
                MessageBox.Show(
                    "Your request has been submitted.\n\nThe system administrator will review it. " +
                    "If it is approved, the login details are emailed to " + where + ".",
                    "Request sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form.Close();   // goes back to the Sign In form
            };

            // Keep the card in the middle of the window, whatever its size.
            form.Resize += (s, e) => CenterCard();
            form.Load += (s, e) => CenterCard();

            // Show the Sign In form again when this one closes
            // (Back to Sign In, the X button, or after submitting).
            form.FormClosed += (s, e) =>
            {
                if (signInForm != null && !signInForm.IsDisposed) signInForm.Show();
            };

            ShowPage(0);
            CenterCard();

            signInForm?.Hide();
            form.Show();
        }

        private static Button RaMakeButton(string text, int width, bool filled)
        {
            var b = new Button
            {
                Text = text,
                Size = new Size(width, 40),
                Location = new Point(0, 12),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Cursor = Cursors.Hand,
                BackColor = filled ? RaTealBtn : Color.FromArgb(240, 240, 240),
                ForeColor = filled ? Color.White : RaTealBtn
            };
            b.FlatAppearance.BorderColor = RaTealBtn;
            b.FlatAppearance.BorderSize = 1;
            return b;
        }

        // One label + one input per row, placed at fixed positions (no layout surprises).
        private static Panel RaMakePage(params (string Label, Control Input)[] rows)
        {
            var page = new Panel { Dock = DockStyle.Fill, AutoScroll = true };

            for (int i = 0; i < rows.Length; i++)
            {
                int y = 8 + i * 44;
                page.Controls.Add(new Label
                {
                    Text = rows[i].Label,
                    AutoSize = true,
                    Location = new Point(0, y + 4),
                    Font = new Font("Segoe UI Semibold", 10)
                });
                rows[i].Input.Location = new Point(240, y);
                rows[i].Input.Width = 400;
                page.Controls.Add(rows[i].Input);
            }

            // Stretch the inputs to the page width whenever it changes.
            page.Resize += (s, e) =>
            {
                foreach (var r in rows)
                    r.Input.Width = Math.Max(150, page.ClientSize.Width - r.Input.Left - 4);
            };
            return page;
        }
    }
}