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

namespace Dirty
{
    /// <summary>
    /// Interaction logic for Display.xaml
    /// </summary>
    public partial class Display : Window
    {
        public Display()
        {
            InitializeComponent();
        }

        protected override void OnDeactivated(EventArgs e)
        {
            base.OnDeactivated(e);
            this.Topmost = true;

        }
    }
}
