using System;
using System.Collections.Generic;
using System.Text;

namespace Updated_Information_System_3
{
        public static class UserSession
        {
            public static int PersonId { get; set; }
            public static string FirstName { get; set; }
            public static string LastName { get; set; }
            public static string Email { get; set; }

            public static string FullName
            {
                get
                {
                    return FirstName + " " + LastName;
                }
            }

            public static void Clear()
            {
                PersonId = 0;
                FirstName = null;
                LastName = null;
                Email = null;
            }
        }
    
}
