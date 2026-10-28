using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Updated_Information_System_3
{
    internal class InterfaceCreation
    {
        private static readonly Color RaTealBg = Color.FromArgb(0, 139, 139);

        private static readonly Color RaTealBtn = Color.FromArgb(0, 128, 128);

        private static Button RaMakeButton(string text, int width, bool filled)
        {
            var b = new Button { Text = text, Size = new Size(width, 40), Location = new Point(0, 12), FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 10, FontStyle.Bold), Cursor = Cursors.Hand, BackColor = filled ? RaTealBtn : Color.FromArgb(240, 240, 240), ForeColor = filled ? Color.White : RaTealBtn };
            b.FlatAppearance.BorderColor = RaTealBtn;
            b.FlatAppearance.BorderSize = 1;
            return b;
        }

        private static Panel RaMakePage(params (string Label, Control Input)[] rows)
        {
            var page = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(4)
            };

            var labels = new List<Label>();

            for (int i = 0; i < rows.Length; i++)
            {
                var label = new Label
                {
                    Text = rows[i].Label,
                    AutoSize = false,
                    Height = 24,
                    Font = new Font("Segoe UI Semibold", 9)
                };

                labels.Add(label);

                page.Controls.Add(label);
                page.Controls.Add(rows[i].Input);
            }

            void LayoutFields()
            {
                int columnWidth = Math.Max(150, (page.ClientSize.Width - 30) / 2);
                int rowHeight = 76;

                for (int i = 0; i < rows.Length; i++)
                {
                    int column = i % 2;
                    int row = i / 2;

                    int x = column * (columnWidth + 12);
                    int y = 8 + row * rowHeight;

                    labels[i].Location = new Point(x, y);
                    labels[i].Width = columnWidth;

                    rows[i].Input.Location = new Point(x, y + 25);
                    rows[i].Input.Width = columnWidth;
                    rows[i].Input.Visible = true;
                }
            }

            page.Resize += (s, e) => LayoutFields();
            LayoutFields();

            return page;
        }

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

            string[] subtitles = { "Step 1 of 3 \u2013 Organization details", "Step 2 of 3 \u2013 Login credentials", "Step 3 of 3 \u2013 Review and submit" };
            string[] legends = { "Organization details", "Who will receive the login credentials?", "Review your request" };
            int index = 0;

            // ----- Inputs -----
            var type = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList };
            type.Items.AddRange(new object[] { "High School", "Verifying Organization" });
            type.SelectedIndex = 0;

            var institutionId = new TextBox();
            var name = new TextBox();

            // Detailed Address Fields
            var streetNumber = new TextBox();
            var streetName = new TextBox();
            var suburb = new TextBox();
            var city = new TextBox();

            var province = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList };
            province.Items.AddRange(new object[] { "Eastern Cape", "Free State", "Gauteng", "KwaZulu-Natal", "Limpopo", "Mpumalanga", "North West", "Northern Cape", "Western Cape" });

            var postalCode = new TextBox();
            var email = new TextBox();
            var tel = new TextBox();

            var role = new TextBox
            {
                Text = "IT Admin",
                ReadOnly = true,
                TabStop = false
            };

            var staffNumber = new TextBox();
            var rName = new TextBox();
            var rSurname = new TextBox();
            var rEmail = new TextBox();
            var rPhone = new TextBox();
            var rGender = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList };
            rGender.Items.AddRange(new object[] { "FEMALE", "MALE" });
            rGender.SelectedIndex = 0;

            // Verifying organizations have no EMIS number.
            type.SelectedIndexChanged += (s, e) =>
            {
                institutionId.PlaceholderText =
                    type.SelectedIndex == 0
                    ? "Enter 9-digit EMIS number"
                    : "Enter institution's provider code";
            };

            // ----- Card, banner, progress bar -----
            var card = new Panel { Size = new Size(780, 640), BackColor = Color.FromArgb(240, 240, 240), Padding = new Padding(24), BorderStyle = BorderStyle.FixedSingle };
            var title = new Label { Text = "REQUEST ACCESS", Dock = DockStyle.Top, Height = 46, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 15, FontStyle.Bold), ForeColor = Color.Black };
            var stepText = new Label { Dock = DockStyle.Fill, TextAlign = ContentAlignment.TopCenter, Font = new Font("Segoe UI", 9), ForeColor = Color.FromArgb(68, 68, 68) };

            var banner = new Panel { Dock = DockStyle.Top, Height = 78, BackColor = Color.FromArgb(230, 230, 250) };
            banner.Controls.Add(stepText);
            banner.Controls.Add(title);

            var track = new Panel { Dock = DockStyle.Top, Height = 4, BackColor = Color.FromArgb(215, 215, 215) };
            var bar = new Panel { Dock = DockStyle.Left, BackColor = RaTealBtn };
            track.Controls.Add(bar);

            var grp = new GroupBox { Dock = DockStyle.Fill, Padding = new Padding(18, 14, 18, 8), Font = new Font("Segoe UI Semibold", 10) };
            var review = new Label { Dock = DockStyle.Fill, Font = new Font("Consolas", 10.5f) };

            // ----- Footer -----
            var footer = new Panel { Dock = DockStyle.Bottom, Height = 64 };
            var link = new LinkLabel { Text = "Back to Sign In", AutoSize = true, Location = new Point(0, 20), LinkColor = RaTealBg, ActiveLinkColor = RaTealBtn, VisitedLinkColor = RaTealBg, LinkBehavior = LinkBehavior.AlwaysUnderline, Font = new Font("Segoe UI Semibold", 10) };
            var back = RaMakeButton("Back", 120, false);
            var next = RaMakeButton("Next", 160, true);

            footer.Controls.Add(link);
            footer.Controls.Add(back);
            footer.Controls.Add(next);

            footer.Resize += (s, e) =>
            {
                next.Left = footer.ClientSize.Width - next.Width;
                back.Left = next.Left - 12 - back.Width;
            };

            var spacerTop = new Panel { Dock = DockStyle.Top, Height = 20 };
            var spacerBottom = new Panel { Dock = DockStyle.Bottom, Height = 14 };

            card.Controls.Add(grp);
            card.Controls.Add(spacerTop);
            card.Controls.Add(track);
            card.Controls.Add(banner);
            card.Controls.Add(spacerBottom);
            card.Controls.Add(footer);
            form.Controls.Add(card);

            // ----- Pages -----
            var pages = new Panel[3];
            pages[0] = RaMakePage(
                ("Organization Type", type),
                ("Institution ID", institutionId),
                ("Organization Name", name),
                ("Street number", streetNumber),
                ("Street name", streetName),
                ("Suburb", suburb),
                ("City", city),
                ("Province", province),
                ("Postal code", postalCode),
                ("Email address", email),
                ("Telephone", tel));

            pages[1] = new Panel();
            pages[1].Controls.Add(RaMakePage(
                ("Role", role),
                ("Staff number", staffNumber),
                ("Name", rName),
                ("Surname", rSurname),
                ("GENDER", rGender),
                ("Email address", rEmail),
                ("Phone number", rPhone)));

            pages[1].Controls.Add(new Label
            {
                Dock = DockStyle.Top,
                Height = 56,
                ForeColor = Color.FromArgb(90, 90, 90),
                Font = new Font("Segoe UI", 9, FontStyle.Italic),
                Text = "The principal decides who manages the system. This person receives the username and password once the request is approved."
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
                for (int p = 0; p < pages.Length; p++) pages[p].Visible = (p == i);
                stepText.Text = subtitles[i];
                grp.Text = legends[i];
                back.Visible = i > 0;
                next.Text = i == 2 ? "Submit Request" : "Next";
                UpdateBar();

                if (i == 2)
                {
                    bool org = type.SelectedIndex == 1;

                    string fullAddress = $"{streetNumber.Text} {streetName.Text}, {suburb.Text}, {city.Text}";
                    if (province.Text.Length > 0) fullAddress += $", {province.Text}";
                    if (postalCode.Text.Length > 0) fullAddress += $" ({postalCode.Text})";

                    review.Text = "Organization type: " + type.Text + "\n" +
                                  "Institution ID: " + (string.IsNullOrWhiteSpace(institutionId.Text) ? "Not provided" : institutionId.Text) + "\n" +
                                  "Name: " + name.Text + "\n" +
                                  "Address: " + fullAddress + "\n" +
                                  "Email address: " + email.Text + "\n" +
                                  "Telephone: " + tel.Text + "\n\n" +
                                  "Credentials go to: " + rName.Text + " " + rSurname.Text + " (" + role.Text + ")\n" +
                                  "Staff number: " + staffNumber.Text + "\n" +
                                  "Email address: " + rEmail.Text + "\n" +
                                  "Phone number: " + rPhone.Text;
                }
            }

            track.Resize += (s, e) => UpdateBar();
            back.Click += (s, e) => ShowPage(index - 1);
            link.LinkClicked += (s, e) => form.Close();

            next.Click += (s, e) =>
            {
                // ----- STEP 1 VALIDATIONS -----
                if (index == 0)
                {
                    // 1. Check for empty fields
                    if (Validations.IsTextBoxEmpty(institutionId, "Institution ID") ||
                        Validations.IsTextBoxEmpty(name, "Organization Name") ||
                        Validations.IsTextBoxEmpty(streetNumber, "Street Number") ||
                        Validations.IsTextBoxEmpty(streetName, "Street Name") ||
                        Validations.IsTextBoxEmpty(suburb, "Suburb") ||
                        Validations.IsTextBoxEmpty(city, "City") ||
                        Validations.IsTextBoxEmpty(postalCode, "Postal Code") ||
                        Validations.IsTextBoxEmpty(email, "Email Address") ||
                        Validations.IsTextBoxEmpty(tel, "Telephone"))
                    {
                        return;
                    }

                    // 2. Validate High School EMIS number length (9 digits)
                    if (type.SelectedIndex == 0 && !Validations.IsValidEmisNumber(institutionId.Text.Trim()))
                    {
                        MessageBox.Show("Please enter a valid 9-digit EMIS number for the High School.", "Invalid Institution ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        institutionId.Focus();
                        return;
                    }

                    // 3. Organization Name validation (No symbols or numbers)
                    if (!Validations.IsValidName(name.Text.Trim()))
                    {
                        MessageBox.Show("Organization name can only contain letters and spaces (no symbols or numbers).", "Invalid Organization Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        name.Focus();
                        return;
                    }

                    // 4. Email format validation
                    if (!Validations.IsValidEmail(email.Text.Trim()))
                    {
                        MessageBox.Show("Please enter a valid organization email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        email.Focus();
                        return;
                    }

                    // 5. Telephone validation (Must start with 0 and be 10 digits)
                    if (!Validations.IsValidPhoneNumber(tel.Text.Trim()))
                    {
                        MessageBox.Show("Telephone number must start with '0' and contain 10 digits.", "Invalid Telephone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tel.Focus();
                        return;
                    }

                    // 6. Postal Code validation (Must be digits only and exactly 4 digits long)
                    if (!Validations.IsValidPostalCode(postalCode.Text.Trim()))
                    {
                        MessageBox.Show("Postal code must contain exactly 4 digits only (no letters or symbols).", "Invalid Postal Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        postalCode.Focus();
                        return;
                    }
                }

                // ----- STEP 2 VALIDATIONS -----
                if (index == 1)
                {
                    // 1. Check for empty fields
                    if (Validations.IsTextBoxEmpty(staffNumber, "Staff Number") ||
                        Validations.IsTextBoxEmpty(rName, "Name") ||
                        Validations.IsTextBoxEmpty(rSurname, "Surname") ||
                        Validations.IsTextBoxEmpty(rEmail, "Email Address") ||
                        Validations.IsTextBoxEmpty(rPhone, "Phone Number"))
                    {
                        return;
                    }

                    // 2. First Name validation (No symbols or numbers)
                    if (!Validations.IsValidName(rName.Text.Trim()))
                    {
                        MessageBox.Show("First name can only contain letters and spaces (no symbols or numbers).", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        rName.Focus();
                        return;
                    }

                    // 3. Surname validation (No symbols or numbers)
                    if (!Validations.IsValidName(rSurname.Text.Trim()))
                    {
                        MessageBox.Show("Surname can only contain letters and spaces (no symbols or numbers).", "Invalid Surname", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        rSurname.Focus();
                        return;
                    }

                    // 4. Email format validation
                    if (!Validations.IsValidEmail(rEmail.Text.Trim()))
                    {
                        MessageBox.Show("Please enter a valid email address for the IT admin.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        rEmail.Focus();
                        return;
                    }

                    // 5. Phone number validation (Must start with 0 and be 10 digits)
                    if (!Validations.IsValidPhoneNumber(rPhone.Text.Trim()))
                    {
                        MessageBox.Show("Phone number must start with '0' and contain 10 digits.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        rPhone.Focus();
                        return;
                    }
                }

                // Move forward if checks pass and we are not yet on the review page
                if (index < 2)
                {
                    ShowPage(index + 1);
                    return;
                }

                // ----- STEP 3: SUBMIT REQUEST -----
                bool isHighSchool = type.SelectedIndex == 0;

                try
                {
                    bool saved = ApplicationDatabase.SaveAccessRequest(isHighSchool, institutionId.Text, name.Text,
                        email.Text, tel.Text, streetNumber.Text, streetName.Text, suburb.Text, city.Text, province.Text,
                        postalCode.Text, rName.Text, rSurname.Text, rGender.Text, rEmail.Text, rPhone.Text, staffNumber.Text);

                    if (saved)
                    {
                        MessageBox.Show(
                            "Your request has been submitted successfully.\n\n" +
                            "The system administrator will review it. " +
                            "If approved, the login details will be sent to " +
                            rEmail.Text.Trim() + ".",
                            "Request Submitted",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        form.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(
                        "The request could not be saved to the database.\n\n" + ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "An unexpected error occurred.\n\n" + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            };

            form.Resize += (s, e) => CenterCard();
            form.Load += (s, e) =>
            {
                CenterCard();
            };

            form.FormClosed += (s, e) =>
            {
                if (signInForm != null && !signInForm.IsDisposed) signInForm.Show();
            };

            ShowPage(0);
            CenterCard();
            signInForm?.Hide();
            form.Show();
        }
    }
}