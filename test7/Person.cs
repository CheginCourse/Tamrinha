using System;

namespace other
{
    class Person{
        string personName;
        int haghozahme;
        int saatKar;

        public int CalculateDaily(int _haghozahme, int _saatKar){
            this.haghozahme = _haghozahme;
            this.saatKar = _saatKar;
            return haghozahme * saatKar;
        }

        public int CalculateMonthly(int value){
            return 24 * value;
        }
        public int getHaghozahme(){
            return this.haghozahme;
        }
    }
}

