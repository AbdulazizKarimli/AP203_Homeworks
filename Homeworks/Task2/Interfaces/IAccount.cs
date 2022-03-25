using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Interfaces
{
    internal interface IAccount
    {
        bool PasswordChecker(string password);
        void ShowInfo();
    }
}
