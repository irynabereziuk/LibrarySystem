using System;

namespace LibrarySystem
{
    
    internal class PhysicalBookAcquisition : NewBookAcquisition
    {
        protected override void CatalogBook() => Console.WriteLine("Каталогуємо фізичну книгу...");
        protected override void ApplyBarcode() => Console.WriteLine("Наносимо штрих-код на фізичну книгу...");
        protected override void PlaceOnShelf() => Console.WriteLine("Поміщаємо фізичну книгу на полицю...");
    }
}