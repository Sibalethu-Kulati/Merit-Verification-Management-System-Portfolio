using System;
using System.Collections.Generic;
using System.Text;

namespace Updated_Information_System_3
{
    internal class NavigationClass
    { 
        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~S.Kulati~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
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
        
        public static T addUserControl<T>(Control parentContainer, Control sidebar)where T: UserControl, new()
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
    }
}
