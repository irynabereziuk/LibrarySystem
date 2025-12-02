using System;

namespace LibrarySystem
{
    
    internal class EBookAcquisition : NewBookAcquisition
    {
        protected override void CatalogBook() => Console.WriteLine("Каталогуємо електронну книгу...");
        protected override void ApplyBarcode() => Console.WriteLine("Генеруємо унікальний ID для eBook...");
        protected override void PlaceOnShelf() => Console.WriteLine("Додаємо eBook у цифровий каталог...");
    }
}