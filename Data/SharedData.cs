using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Maui.Controls;

public class SharedData : INotifyPropertyChanged
{
    private string _fullName;

    public string FullName
    {
        get => _fullName;
        set
        {
            if (_fullName != value)
            {
                _fullName = value;
                OnPropertyChanged();
            }
        }
    }
    

    // Singleton instance
    private static SharedData _instance;
    public static SharedData Instance => _instance ??= new SharedData();

    public event PropertyChangedEventHandler PropertyChanged;
    private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}