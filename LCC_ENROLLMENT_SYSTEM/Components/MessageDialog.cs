using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCC_ENROLLMENT_SYSTEM.Components
{
    internal class MessageDialog
    {
        public static void ShowMessage(String message)
        {
            MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
