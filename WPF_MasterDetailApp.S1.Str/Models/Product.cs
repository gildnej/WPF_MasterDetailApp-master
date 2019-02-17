using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MasterDetailApp.Models
{
    public class Product
    {
        #region ENUMS

        public enum VideoGame {rpg, action, indie}

        #endregion

        #region FIELDS

        private int _id;
        private string _GameName;
        private string _GameGenera;
        private VideoGame game;
        private string _imageFileName;
        private string description;
        private DateTime _releaseDate;
        private string _developer;

        #endregion

        #region PROPERTIES

 

        #endregion

        #region CONSTRUCTORS



        #endregion

        #region METHODS


        #endregion

        #region EVENTS



        #endregion
    }
}
