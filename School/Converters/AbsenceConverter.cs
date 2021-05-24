using School.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace School.Converters
{
    class AbsenceConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if ((values[0] != null && values[1] != null && values[2] != null && values[3] != null) &&
                (!values[0].Equals("") && !values[1].Equals("") && !values[2].Equals("") && !values[3].Equals("")))
            {
                return new AbsenceVM()
                {
                    IdAbsence = int.Parse(values[0].ToString()),
                    Date = System.DateTime.Parse(values[1].ToString()),
                    IsJustified = bool.Parse(values[2].ToString()),
                    CanBeJustified = bool.Parse(values[3].ToString())

                };
            }
            else
            {
                return null;
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            AbsenceVM absence = value as AbsenceVM;
            object[] result = new object[4]
            {
                absence.IdAbsence, 
                absence.Date, 
                absence.IsJustified, 
                absence.CanBeJustified
            };
            return result;
        }
    }

}
