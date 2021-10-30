using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLoterica.Models
{
    public class Lotofacil
    {
        public int ConcursoID { get; set; }
        public string Data { get; set; }

        private int _dezena_01;
        private int _dezena_02;
        private int _dezena_03;
        private int _dezena_04;
        private int _dezena_05;
        private int _dezena_06;
        private int _dezena_07;
        private int _dezena_08;
        private int _dezena_09;
        private int _dezena_10;
        private int _dezena_11;
        private int _dezena_12;
        private int _dezena_13;
        private int _dezena_14;
        private int _dezena_15;

        private int _total;
        private int _totalPar;
        private int _totalImpar;
        private int _totalPrimo;

        public int TotalPar { 
            get
            {
                return _totalPar;
            }
                set
            {
                _totalPar = _totalPar + value;
            }
                }
        public int TotalImpar {
            get
            {
                return _totalImpar;
            }
            set
            {
                _totalImpar = _totalImpar + value;
            }
        }
        public int TotalPrimo { get; set; }
        public int Total
        {
            get
            {
                return _total;
            }
            set
            {
                _total = _total + value;
            }
        }

        public int Dezena_01 { get; set; }
        public int Dezena_02 { get; set; }
        public int Dezena_03 { get; set; }
        public int Dezena_04 { get; set; }
        public int Dezena_05 { get; set; }
        public int Dezena_06 { get; set; }
        public int Dezena_07 { get; set; }
        public int Dezena_08 { get; set; }
        public int Dezena_09 { get; set; }
        public int Dezena_10 { get; set; }
        public int Dezena_11 { get; set; }
        public int Dezena_12 { get; set; }
        public int Dezena_13 { get; set; }
        public int Dezena_14 { get; set; }
        public int Dezena_15 { get; set; }
        public string Arrecadacao { get; set; }
        public int Ganhadores { get; set; }
    }

}
