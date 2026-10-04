using System;
using System.Collections.Generic;
using System.Text;

namespace Updated_Information_System_3
{
    
    internal class UTILITY_CLASS
    {
        public static void openForm(Form formToOpen, Form formToClose)
        {
            formToOpen = new Form();
            formToClose.Hide();
            formToOpen.Show();
        }
    }

    
}
