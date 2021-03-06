﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_MasterDetailApp;
using WPF_MasterDetailApp.Models;

namespace WPF_MasterDetailApp.BusinessLayer
{
    public class ProductBL
    {
        #region ENUMS



        #endregion

        #region FIELDS

        ProductWindowView _productWindowView;
        ProductWindowPresenter _productWindowPresenter;

        #endregion

        #region PROPERTIES

        #endregion

        #region CONSTRUCTORS



        public ProductBL()
        {


            _productWindowPresent = new ProductWindowPresenter(GetCompanyData(), GetProductData());


            _productWindowView = new ProductWindowView(_productWindowPresenter);

            _productWindowView.DataContext = _productWindowPresenter;
            _productWindowView.Show();


        }


        #endregion

        #region METHODS

        private Company GetCompanyData()
        {
            return new Company()
            {
                Name = "Jake's Game Collection?",
                Address = "1234 Yeet drive",
                City = "Traverse City",
            };




        }


        private Product GetProductData()
        {
            DateTime _releaseDate = new DateTime(2017, 1, 26);
            return new Product()
            {
                _id = 1,
                _GameName = "Tales of Berseria",
                _GameGenera = "rpg",
                game = Product.VideoGame.rpg,
                _developer = "Bandai Namco Studios Inc",
                _releaseDate = _releaseDate,
                _imageFileName = "Tales_of_Bersia_cover.jpg",
                description = "In Tales of Berseria, players embark on a journey of self-discovery as they assume the role of Velvet, " +
           "a young woman whose once kind demeanor has been replaced and overcome with a festering anger and hatred after a traumatic experience three years prior to the events within Tales of Berseria. " +
           "Velvet will join a crew of pirates as they sail across the sea and visit the many islands that make up the sacred kingdom of Midgand in an all-new adventure"
            };





        }

        #endregion

        #region EVENTS


        #endregion

    }
}
