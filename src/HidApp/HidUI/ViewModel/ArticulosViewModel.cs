using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Data;
using Entidades;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace HidUI.ViewModel
{
    class ArticulosViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<enTArticulo> _Articulo;

        //Constructor de la clase
        public ArticulosViewModel()
        {
            _Articulo = new ObservableCollection<enTArticulo>();
            _Articulo.Add(new enTArticulo());
            AddArticuloCommand = new DelegateCommand(AddArticuloExecute, AddArticuloCanExecute);
        }
        
        
        

        public ObservableCollection<enTArticulo> Articulo
        {
            get
            {
                return _Articulo;
            }
            set
            {
                _Articulo = value;
                NotifyPropertyChanged("Articulo");
            }
        }



        #region PropertyChanged 
        //Implementacion de la interface...
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string info)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
        #endregion

        public DelegateCommand AddArticuloCommand
        {
            get;
            private set;
        }


        void AddArticuloExecute(object parameters)
        {
            Articulo.Add(new enTArticulo {             });
        }

        bool AddArticuloCanExecute(object parameters)
        {
            return true;
        }


    }

}

