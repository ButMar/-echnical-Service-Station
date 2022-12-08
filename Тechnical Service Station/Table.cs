using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ТechnicalServiceStation
{
    internal class Table
    {
        private int weight = 60;
        private int lenght = 100;
        private int height = 50;
        private int numberOfPillows = 4;
        private int numberOfShelfs = 1;
        private Car carInShelf = null;
        private bool isOpened = false;
        

        public bool IsOpened { get { return isOpened; } }
 
        public void OpenShelf()
        {
            if (isOpened == true)
            {
                Console.WriteLine("Already opened");
                return;
            }
            isOpened = true;
        }


        public void CloseShelf()
        {
            isOpened = false ;
        }


        public void PutInShelf(Car minicar)
        {
            carInShelf = minicar;
        }

        public void ChangeShelf(Table mytable, Table table2)
        {
            if (isOpened == true && carInShelf != null)
            {
             table2.carInShelf = mytable.carInShelf;
            }
        }
        

    }
}
