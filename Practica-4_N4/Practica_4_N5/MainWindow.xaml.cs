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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practica_4_N5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            int N = Convert.ToInt32(polA.Text);
            if(N>1)
            {
                int K = 0;
                int f = 1;
                while (K <= N)
                {
                    K = K + f;
                    f++;
                   
   
                }
                Otv.Content = $"{K}";

            }
            else
            {
                Otv.Content = $"число меньше одного";
            }

            
        }
    }
}
