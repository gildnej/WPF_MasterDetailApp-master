﻿using WPF_MasterDetailApp.Models;
using System;
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

namespace WPF_MasterDetailApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ProductWindowView : Window
    {
        #region FIELDS

        ProductWindowPresenter productWindowPresenter;

        #endregion

        #region METHODS (pass events to view model)

        private void Button_Quit_Click(object sender, RoutedEventArgs e)
        {
            productWindowPresenter.QuitApplication();
        }
        
        #endregion

        #region CONSTRUCTORS

        public ProductWindowView(ProductWindowPresenter productWindowPresenter)
        {
            ProductWindowPresenter _productWindowPresenter = productWindowPresenter;
            DataContext = productWindowPresenter;

            InitializeComponent();
        }

        #endregion
    }
}
