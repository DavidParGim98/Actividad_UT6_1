﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_UT6_1
{
    public class Usuario : INotifyPropertyChanged
    {
        private Emisor _nombre;
        private string _imagen;
        private string _mensaje;

        public enum Emisor
        {
            Usuario, Robot
        }

        public Emisor Nombre
        {
            get => _nombre;

            set
            {
                if (this._nombre != value)
                {
                    this._nombre = value;
                    this.NotifyPropertyChanged("Nombre");
                }
            }
        }
        public string Imagen
        {
            get => _imagen;

            set
            {
                if (this._imagen != value)
                {
                    this._imagen = value;
                    this.NotifyPropertyChanged("Imagen");
                }
            }
        }
        public string Mensaje
        {
            get => _mensaje;

            set
            {
                if (this._mensaje != value)
                {
                    this._mensaje = value;
                    this.NotifyPropertyChanged("Mensaje");
                }
            }
        }

        public Usuario(Emisor nombre, string imagen, string mensaje)
        {
            Nombre = nombre;
            Imagen = imagen;
            Mensaje = mensaje;
        }

        public Usuario()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
 
}
