using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Core
{
    public static class Extensions
    {
        public static ObservableCollection<T> ToObs<T>(this List<T> list)
        {
            return new ObservableCollection<T>(list);
        }
    }
}
