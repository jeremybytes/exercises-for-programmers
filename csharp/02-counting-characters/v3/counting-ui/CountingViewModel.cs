using System.ComponentModel;

namespace counting_ui;

public class CountingViewModel : INotifyPropertyChanged
{
    private string? input;
    public string? Input
    {
        get { return input; }
        set
        {
            input = value;
            RaisePropertyChanged();
        }
    }

    public int Count
    {
        get => input?.Length ?? 0;
    }

    public string Message
    {
        get
        {
            if (Count == 0)
                return "";
            return $"{input} has {Count} characters.";
        }
    }


    public event PropertyChangedEventHandler? PropertyChanged;
    private void RaisePropertyChanged(string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new(propertyName));
    }
}
