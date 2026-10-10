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
    public partial class SchoolRegistration_wizard : Form
    {
        private static readonly Color Teal = Color.FromArgb(0, 62, 64);
        private static readonly Color Green = Color.FromArgb(0, 128, 0);
        private static readonly Color Red = Color.FromArgb(192, 0, 0);

        private readonly string[] _titles = { "School information", "IT administrator", "Review and confirm" };
        private readonly Panel[] _pages = new Panel[3];
        private readonly Panel _body = new Panel { Dock = DockStyle.Fill, Padding = new Padding(30, 20, 30, 10) };
        private readonly Panel _track = new Panel { Dock = DockStyle.Top, Height = 5, BackColor = Color.FromArgb(205, 225, 222) };
        private readonly Panel _bar = new Panel { Dock = DockStyle.Left, BackColor = Green };
        private readonly Label _title = new Label();
        private readonly Label _stepText = new Label();
        private readonly Label _review = new Label { Dock = DockStyle.Fill, Font = new Font("Segoe UI", 11) };
        private Button _back, _next;
        private int _index;

        // Step 1: school information
        private readonly TextBox _emis = new TextBox(), _name = new TextBox(), _address = new TextBox(),
                                 _postal = new TextBox(), _email = new TextBox(), _tel = new TextBox();
        private readonly ComboBox _province = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList };

        // Step 2: IT administrator
        private readonly TextBox _aName = new TextBox(), _aSurname = new TextBox(),
                                 _aEmail = new TextBox(), _aPhone = new TextBox();

        public SchoolRegistration_wizard()
        {
            InitializeComponent();   // keep: created by the designer

            Text = "Register High School";
            Font = new Font("Segoe UI", 10);
            BackColor = Color.FromArgb(240, 240, 240);
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Size = new Size(674, 607);

            _province.Items.AddRange(new object[]
            {
                "Eastern Cape", "Free State", "Gauteng", "KwaZulu-Natal", "Limpopo",
                "Mpumalanga", "North West", "Northern Cape", "Western Cape"
            });

            // ----- Header (teal banner with title) -----
            var header = new Panel { Dock = DockStyle.Top, Height = 76, BackColor = Teal };
            _title.ForeColor = Color.White;
            _title.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            _title.AutoSize = true;
            _title.Location = new Point(24, 10);
            _stepText.ForeColor = Color.FromArgb(180, 220, 215);
            _stepText.AutoSize = true;
            _stepText.Location = new Point(26, 46);
            header.Controls.Add(_title);
            header.Controls.Add(_stepText);

            // ----- Progress bar -----
            _track.Controls.Add(_bar);
            _track.Resize += (s, e) => UpdateBar();

            // ----- Footer: Cancel on the left, Back + Next on the right -----
            var footer = new Panel { Dock = DockStyle.Bottom, Height = 64 };
            var cancel = MakeButton("Cancel", Red);
            _back = MakeButton("Back", Teal);
            _next = MakeButton("Next", Green);
            cancel.Left = 30;
            footer.Controls.Add(cancel);
            footer.Controls.Add(_back);
            footer.Controls.Add(_next);

            // Positioned from the footer's REAL width every time it resizes,
            // so the buttons can never end up off-screen.
            footer.Resize += (s, e) =>
            {
                _next.Left = footer.ClientSize.Width - 30 - _next.Width;
                _back.Left = _next.Left - 10 - _back.Width;
            };

            cancel.Click += (s, e) => DialogResult = DialogResult.Cancel;
            _back.Click += (s, e) => ShowPage(_index - 1);
            _next.Click += (s, e) => NextClicked();

            // Fill goes in first so the Top and Bottom panels claim their space before it.
            Controls.Add(_body);
            Controls.Add(_track);
            Controls.Add(header);
            Controls.Add(footer);

            // ----- Pages (all built now, only one visible at a time) -----
            _pages[0] = MakePage(
                ("EMIS number", _emis), ("School name", _name), ("Address", _address),
                ("Postal code", _postal), ("Province", _province),
                ("School email", _email), ("Telephone", _tel));

            _pages[1] = new Panel();
            _pages[1].Controls.Add(MakePage(
                ("Name", _aName), ("Surname", _aSurname), ("Email", _aEmail), ("Phone number", _aPhone)));
            _pages[1].Controls.Add(new Label
            {
                Dock = DockStyle.Top,
                Height = 48,
                ForeColor = Color.FromArgb(90, 90, 90),
                Font = new Font("Segoe UI", 9, FontStyle.Italic),
                Text = "The principal decides who manages the system. Enter the details of the person " +
                       "who will be this school's system administrator."
            });

            _pages[2] = new Panel();
            _pages[2].Controls.Add(_review);

            foreach (var page in _pages)
            {
                page.Dock = DockStyle.Fill;
                page.Visible = false;
                _body.Controls.Add(page);
            }

            ShowPage(0);
        }

        // Keep this method: the designer may be wired to it.
        private void SchoolRegistration_wizard_Load(object sender, EventArgs e)
        {
        }

        private static Button MakeButton(string text, Color color)
        {
            var b = new Button
            {
                Text = text,
                Size = new Size(130, 40),
                Location = new Point(0, 12),
                BackColor = color,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            b.FlatAppearance.BorderSize = 0;
            return b;
        }

        // One label + one input per row, placed at fixed positions (no layout surprises).
        private static Panel MakePage(params (string Label, Control Input)[] rows)
        {
            var page = new Panel { Dock = DockStyle.Fill, AutoScroll = true };

            for (int i = 0; i < rows.Length; i++)
            {
                int y = 8 + i * 46;
                page.Controls.Add(new Label { Text = rows[i].Label, AutoSize = true, Location = new Point(0, y + 5) });
                rows[i].Input.Location = new Point(160, y);
                rows[i].Input.Width = 300;
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

        private void UpdateBar()
        {
            _bar.Width = _track.ClientSize.Width * (_index + 1) / 3;
        }

        private void ShowPage(int i)
        {
            _index = i;
            for (int p = 0; p < _pages.Length; p++)
                _pages[p].Visible = (p == i);

            _title.Text = _titles[i];
            _stepText.Text = "Step " + (i + 1) + " of 3";
            _back.Visible = i > 0;
            _next.Text = i == 2 ? "Register" : "Next";
            UpdateBar();

            if (i == 2)
            {
                _review.Text =
                    "School:      " + _name.Text + "  (EMIS " + _emis.Text + ")\n" +
                    "Address:     " + _address.Text + ", " + _postal.Text + ", " + _province.Text + "\n" +
                    "Email:       " + _email.Text + "\n" +
                    "Telephone:   " + _tel.Text + "\n\n" +
                    "IT admin:    " + _aName.Text + " " + _aSurname.Text + "\n" +
                    "Email:       " + _aEmail.Text + "\n" +
                    "Phone:       " + _aPhone.Text + "\n\n" +
                    "Click Register to save this school.";
            }
        }

        private void NextClicked()
        {
            if (_index < 2)
            {
                ShowPage(_index + 1);
                return;
            }

            MessageBox.Show("High school registered successfully.", "Done",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;   // closes the form
        }
    }
}