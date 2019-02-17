﻿using WPF_MasterDetailApp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPF_MasterDetailApp.Models
{
    public class ProductWindowPresenter
    {
        #region ENUMS


        #endregion

        #region FIELDS
        private Company _companyInfo;
        private Product _selectedGame;


        #endregion

        #region PROPERTIES

        public Company CompanyInfo
        {
            get { return _companyInfo; }
            set { _companyInfo = value; }
        }

        public Product SelectedGame
        {
            get { return _selectedGame;}
            set { _selectedGame = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public ProductWindowPresenter (Company company, Product product)
        {
            _selectedGame = product;
            _companyInfo = company;
        }

        #endregion

        #region METHODS

        public void QuitApplication()
        {
            Environment.Exit(0);
        }

        #endregion

        #region EVENTS


        #endregion
    }
}
