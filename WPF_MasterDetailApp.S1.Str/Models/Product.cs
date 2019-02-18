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

        public int _id;
        public string _GameName;
        public string _GameGenera;
        public VideoGame game;
        public string _imageFileName;
        public string description;
        public DateTime _releaseDate;
        public string _developer;

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
