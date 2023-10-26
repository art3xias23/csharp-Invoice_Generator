using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WinForms.Invoice.Generator.Structure
{
    internal class ListBoxItem : INotifyPropertyChanged
    {
        internal ListBoxItem(DateTime newItem)
        {
            Item = newItem;
        }
        private DateTime _item;

        public DateTime Item
        {
            get => _item;
            set { _item = value; OnPropertyChanged(); }
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
