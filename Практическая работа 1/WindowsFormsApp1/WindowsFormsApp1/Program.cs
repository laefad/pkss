﻿using System;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Task7Form());
            Application.Run(new Task10Form());
            Application.Run(new Task13Form());
            Application.Run(new Task16Form());
            Application.Run(new Task19Form());
        }
    }
}
