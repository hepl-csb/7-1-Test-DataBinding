using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_Test_DataBinding
{
    public class Personne //: INotifyPropertyChanged
    {
        private int _age;

        //public event PropertyChangedEventHandler PropertyChanged;

        public int Age
        {
            get { return _age; }
            set {
                if (value != _age)
                { 
                    _age = value;
                    //if (PropertyChanged != null)
                    //{
                    //    PropertyChanged(this, new PropertyChangedEventArgs("Age"));
                    //}
                }
            }
        }
    
        public Personne()
        {
            Age = 0;
        }
        public void Vieillir(int annee = 1)
        {
            Age += annee;
        }
    }
}
