using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroRunning.Modelo
{
    class RegistroCorrida
    {
        #region "Atributos"
        private int _numeroCorredor;
        private int _categoria;
        private DateTime _horaPartida;
        private DateTime _horaLlegada;
        #endregion
        #region "Constructores"
        public RegistroCorrida()
        {
            _numeroCorredor = 0;
            _categoria = 0;
            _horaPartida = DateTime.Now;
            _horaLlegada = DateTime.Now;
        }

        public RegistroCorrida( int numeroCorredor, int categoria, DateTime horaPartida, DateTime horaLlegada)
        {
            _numeroCorredor = numeroCorredor;
            _categoria = categoria;
            _horaPartida = horaPartida;
            _horaLlegada = horaLlegada;
        }
        #endregion
        #region "Propiedades"
        public int numeroCorredor
        {
            set { _numeroCorredor = value; }
            get { return _numeroCorredor; }
        }

        public int categoria
        {
            set { _categoria = value; }
            get { return _categoria; }
        }

        public DateTime horaPartida
        {
            set { _horaPartida = value; }
            get { return _horaPartida; }
        }

        public DateTime horaLlegada
        {
            set { _horaLlegada = value; }
            get { return _horaLlegada; }
        }
        #endregion
        #region "Métodos"
        #endregion
    }
}
