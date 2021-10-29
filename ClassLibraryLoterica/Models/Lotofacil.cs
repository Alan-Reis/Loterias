using System;
using System.Collections.Generic;
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

        public int Total {
            get
            {
                return _total;
            }
            set
            {
                _total = _total + value;
            }
        }


        public int Dezena_01 {
            get 
            {
                return _dezena_01;
            }
            set
            {
                if((value >=1) && (value <= 7))
                {
                    _dezena_01 = value;
                }
              
            }
        }
        public int Dezena_02 {
            get
            {
                return _dezena_02;
            }
            set
            {
                if ((value >= 2) && (value <= 9))
                {
                    _dezena_02 = value;
                }

            }
        }
        public int Dezena_03 {
            get
            {
                return _dezena_03;
            }
            set
            {
                if ((value >= 3) && (value <= 11))
                {
                    _dezena_03 = value;
                }

            }
        }
        public int Dezena_04 {
            get
            {
                return _dezena_04;
            }
            set
            {
                if ((value >= 4) && (value <= 13))
                {
                    _dezena_04 = value;
                }

            }
        }
        public int Dezena_05 {
            get
            {
                return _dezena_05;
            }
            set
            {
                if ((value >= 5) && (value <= 14))
                {
                    _dezena_05 = value;
                }

            }
        }
        public int Dezena_06 {
            get
            {
                return _dezena_06;
            }
            set
            {
                if ((value >= 6) && (value <= 16))
                {
                    _dezena_06 = value;
                }

            }
        }
        public int Dezena_07 {
            get
            {
                return _dezena_07;
            }
            set
            {
                if ((value >= 7) && (value <= 17))
                {
                    _dezena_07 = value;
                }

            }
        }
        public int Dezena_08 {
            get
            {
                return _dezena_08;
            }
            set
            {
                if ((value >= 8) && (value <= 18))
                {
                    _dezena_08 = value;
                }

            }
        }
        public int Dezena_09 {
            get
            {
                return _dezena_09;
            }
            set
            {
                if ((value >= 9) && (value <= 19))
                {
                    _dezena_09 = value;
                }

            }
        }
        public int Dezena_10 {
            get
            {
                return _dezena_10;
            }
            set
            {
                if ((value >= 10) && (value <= 20))
                {
                    _dezena_10 = value;
                }

            }
        }
        public int Dezena_11 {
            get
            {
                return _dezena_11;
            }
            set
            {
                if ((value >= 12) && (value <= 21))
                {
                    _dezena_11 = value;
                }

            }
        }
        public int Dezena_12 {
            get
            {
                return _dezena_12;
            }
            set
            {
                if ((value >= 13) && (value <= 22))
                {
                    _dezena_12 = value;
                }

            }
        }
        public int Dezena_13 {
            get
            {
                return _dezena_13;
            }
            set
            {
                if ((value >= 15) && (value <= 23))
                {
                    _dezena_13 = value;
                }

            }
        }
        public int Dezena_14 {
            get
            {
                return _dezena_14;
            }
            set
            {
                if ((value >= 17) && (value <= 24))
                {
                    _dezena_14 = value;
                }

            }
        }
        public int Dezena_15 {
            get
            {
                return _dezena_15;
            }
            set
            {
                if ((value >= 18) && (value <= 25))
                {
                    _dezena_15 = value;
                }

            }
        }
        public string Arrecadacao { get; set; }
        public int Ganhadores { get; set; }

    }
       
}
