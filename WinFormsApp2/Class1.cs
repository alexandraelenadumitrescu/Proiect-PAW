using System;
using System.Collections.Generic;
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
        
        public int ValoareTotala { get
            {
                int val = 0;
                foreach (Produs produs in produse) { val += (int)(produs.Pret * produs.Cantitate); }
                    return val;
            ; } 
        }
        //adaugare
        public void AdaugaProdus (Produs produs)
        {
            produse.Add(produs);
        }
        //stergere
        public void StergeProdus(Produs produs)
        {
            produse.Remove(produs);
        }


        //evenimente

        //adaugare produs

        //stergere produs

        //modificare produs- la modificarea datelor unui
        //obiect din colectie sau la inlocuirea unui obiect



    }
}
