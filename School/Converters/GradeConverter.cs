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
    class GradeConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if ((values[0] != null && values[1] != null && values[2] != null && values[3] != null && values[4] != null && values[5] != null) &&
                (!values[0].Equals("") && !values[1].Equals("") && !values[2].Equals("") && !values[3].Equals("") && !values[4].Equals("") && !values[5].Equals("")))
            {
                return new GradeVM()
                {
                    IdGrade = int.Parse(values[0].ToString()),
                    Mark = int.Parse(values[1].ToString()),
                    Date = System.DateTime.Parse(values[2].ToString()),
                    IsMidterm = bool.Parse(values[3].ToString())
                };
            }
            else
            {
                return null;
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            GradeVM grade = value as GradeVM;
            object[] result = new object[4]
            {
                grade.IdGrade,
                grade.Mark,
                grade.Date,
                grade.IsMidterm
            };
            return result;
        }
    }
}
