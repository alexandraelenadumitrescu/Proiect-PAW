using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class CosCumparaturi
    {
        public List<Produs> produse {  get; set; }  
        public int NumarProduse=>produse.Count;
        public Produs this[int index]{ get { return produse[index]; } }
        //indexer

        //valoare totala

        public List<Produs> ToList()
        {
            return produse.ToList();
        }
        public int ValoareTotala { get
            {
                int val = 0;
                foreach (Produs produs in produse) { val += (int)(produs.Pret * produs.Cantitate); }
                    return val;
            ; } 
        }
        //alternativ
        public decimal valtot => produse.Sum(p=>p.Pret);


        public CosCumparaturi()
        {
            produse = new List<Produs>();
        }


        //adaugare
        public void AdaugaProdus (Produs produs)
        {
            produse.Add(produs);
            produs.PropertyChanged+= Produs_PropertyChanged;
            AdaugareProdus?.Invoke(this, EventArgs.Empty);
        }
        //stergere
        public void StergeProdus(Produs produs)
        {
            produse.Remove(produs);
            produs.PropertyChanged -= Produs_PropertyChanged;
            StergereProdus?.Invoke (this, EventArgs.Empty);
        }
        public event EventHandler AdaugareProdus;
        public event EventHandler StergereProdus;
        public event EventHandler ModificareProdus;


        //evenimente

        //adaugare produs

        //stergere produs

        //modificare produs- la modificarea datelor unui
        //obiect din colectie sau la inlocuirea unui obiect
        private void Produs_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            ModificareProdus?.Invoke(this, EventArgs.Empty);
        }

        internal void StergeProdus(int cod)
        {
            //throw new NotImplementedException();
            for (int i = 0; i < produse.Count; i++)
            {
                if (produse[i].Cod == cod)
                {
                    produse.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
