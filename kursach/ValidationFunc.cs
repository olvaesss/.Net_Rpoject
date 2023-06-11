using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace kursach
{
    internal class ValidattionFunc
    {
        string[] forbiddenSigns = new string[] { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "+", "=", "`", "~", "\"", };
        const string cond = @"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)";
        public bool validateCredentials(string Email, string Password, string Password_Repeat)
        {
            const int MIN_LOGIN_SIZE = 4;
            const int MIN_PASSWORD_SIZE = 6;

            if (Email == string.Empty && Password == string.Empty)
            {
                MessageBox.Show("Логин или пароль не могут быть пусты.", "Пустое поле.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Email.Length < MIN_LOGIN_SIZE && Password.Length < MIN_PASSWORD_SIZE)
            {
                MessageBox.Show("Логин или пароль недопустимой длины.", "Недопустимая длина.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Password != Password_Repeat)
            {
                MessageBox.Show("Пароли не совпадают");
                return false;
            }

            if (!Regex.IsMatch(Email, cond))
            {
                MessageBox.Show("Неверный тип Email");
                return false;
            }

            for (int i = 0; i < forbiddenSigns.Length; i++)
            {
                if (Email.Contains(forbiddenSigns[i]) && Password.Contains(forbiddenSigns[i]))
                {
                    MessageBox.Show("Логин или пароль содержит недопустимые символы.", "Недопустимые символы.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
    }
}

