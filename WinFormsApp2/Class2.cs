using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class Produs:  INotifyPropertyChanged,IComparable<Produs>//,*///IComparable<Produs>
    {
        private int cod;
        private string denumire;
        private decimal pret;
        private int cantitate;

        public Produs()
        {
        }

        public Produs(int cod, string denumire, decimal pret, int cantitate)
        {
            Cod = cod;
            Denumire = denumire;
            Pret= pret;
            Cantitate = cantitate;
        }
        

        public int Cod {  get { return cod; } set { cod = value;
                OnPropertyChanged(nameof(Cod));
            } }
        public decimal Pret { get { return pret; } set { pret = value;
                OnPropertyChanged(nameof(Pret));

            } }
        public int Cantitate { get { return cantitate; } set { cantitate=value;
                OnPropertyChanged(nameof(Cantitate));
                    } }
        public string Denumire { get { return denumire; } set { denumire = value;
                OnPropertyChanged(nameof(Denumire));
                    } }
        //public interface INotifyPropertyChanged
        //{
        //    event PropertyChangedEventHandler PropertyChanged;
        //}
        public event PropertyChangedEventHandler PropertyChanged;

        public int CompareTo(Produs other)
        {
            return Denumire.CompareTo(other.Denumire);  
        }

        public override string? ToString()
        {
            return $"{Cod} {Denumire} {Pret} {Cantitate}";
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        //public int CompareTo(Produs other)
        //{
        //    return Denumire.CompareTo(other.Denumire);
        //}


    }
}
