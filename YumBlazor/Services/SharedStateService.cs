namespace YumBlazor.Services
{
    //this class provides a way to manage and share state of the total cart across different components

    public class SharedStateService
    {
        //Onchange is used to notify customer when the state changes
        public event Action OnChange;
        private int _totalCartCount;

        public int TotalCartCount
        {
            get=> _totalCartCount;
            set
            {
                _totalCartCount = value;
                NotifyStateChanged();
            }
        }

        private void NotifyStateChanged()=> OnChange?.Invoke();
    }
}
