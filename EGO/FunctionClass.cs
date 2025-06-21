using EGO.infoForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGO
{
    public static class FunctionClass
    {
        public static void ShowError(this Form form, string info)
        {
            using (var errorForm = new ErrorForm(info))
            {
                errorForm.ShowDialog(form);  // 正确：显示errorForm，指定owner为父窗体
            }
        }
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }
    }
}
