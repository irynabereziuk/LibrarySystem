using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LibrarySystem
{
    
    internal abstract class NewBookAcquisition
    {
        public void RunAcquisition()
        {
            CatalogBook();
            ApplyBarcode();
            PlaceOnShelf();
        }

        protected abstract void CatalogBook();
        protected abstract void ApplyBarcode();
        protected abstract void PlaceOnShelf();
    }
}