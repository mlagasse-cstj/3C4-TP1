﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TP1_Base_Prof
{
    /// <summary>
    /// Logique d'interaction pour BetterOmnivox.xaml
    /// </summary>
    public partial class BetterOmnivox : Window
    {
        public BetterOmnivox(Teacher prof)
        {
            InitializeComponent();

            userLoggedIn.Content = $"{prof.FirstName} {prof.LastName}";

        }
    }
}
