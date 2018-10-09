using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffortlessBus
{
    class Onibus
    {
        #region Atributos

        private string _linha;
        private int _numGPS;
        private int _velMedAtual;
        private int _distancia;
        #endregion

        #region Propriedades

        public string Linha { get => _linha; set => _linha = value; }
        public int NumGPS { get => _numGPS; set => _numGPS = value; }
        public int VelMedAtual { get => _velMedAtual; set => _velMedAtual = value; }
        public int Distancia { get => _distancia; set => _distancia = value; }
        #endregion

    }
}
