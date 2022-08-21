using System.Collections.ObjectModel;

namespace Core;

public static class Extensions
{
    public static ObservableCollection<T> ToObs<T>(this List<T> list) =>
        new ObservableCollection<T>(list);
}
