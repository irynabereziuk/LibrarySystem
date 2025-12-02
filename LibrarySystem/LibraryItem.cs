using System;

namespace LibrarySystem
{
    
    internal abstract class LibraryItem
    {
        public string Title { get; private set; }
        private ILibraryItemState _state;

        protected LibraryItem(string title)
        {
            Title = title;
            _state = new AvailableState();
        }

        
        public void SetState(ILibraryItemState state) => _state = state;

        public void Lend() => _state.Lend(this);
        public void ReturnItem() => _state.Return(this);
        public void Reserve() => _state.Reserve(this);

        public abstract void DisplayInfo();
    }
}