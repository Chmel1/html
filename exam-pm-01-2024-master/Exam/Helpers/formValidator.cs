using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Exam.Helpers
{
    internal static class formValidator
    {
        public static bool validateTextBoxToString(TextBox textBox)
        {
            bool isValid = true;
            if (textBox.Text == string.Empty)
            {
                textBox.BackColor = Color.LightCoral;
                isValid = false;
            }
            else
            {
                textBox.BackColor = SystemColors.Window;
            }

            return isValid;
        }

        public static bool validateTextBoxToEmail(TextBox textBox)
        {
            bool isValid = true;

            if (textBox.Text != string.Empty)
            {
                var trimmedEmail = textBox.Text.Trim();
                if (trimmedEmail.EndsWith("."))
                {
                    return false;
                }
                try
                {
                    var addr = new System.Net.Mail.MailAddress(textBox.Text);
                    return addr.Address == trimmedEmail;
                }
                catch
                {
                    return false;
                }
            }
            else { isValid = false; }

            return isValid;
        }
    }
}
