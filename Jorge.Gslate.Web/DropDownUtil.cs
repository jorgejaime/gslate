using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jorge.Gslate.Web
{
    public static class DropDownUtil
    {
        public static List<SelectListItem> GetDropDownPappingGeneric<T>(IList<T> data, string key, string value, List<int> keySelected = null)
        {
            List<SelectListItem> items = new List<SelectListItem>();

            if (data != null)
            {

                foreach (var item in data)
                {
                    var view = item;
                    var itemKey = (int)(view.GetType().GetProperty(key).GetValue(view, null));
                    var itemValue = view.GetType().GetProperty(value).GetValue(view, null).ToString();
                    var selected = keySelected != null && keySelected.Any(x => x == itemKey);
                    items.Add(new SelectListItem { Text = itemValue, Value = itemKey.ToString(), Selected = selected });
                }
            }
            return items;
        }

        public static List<SelectListItem> GetDropDownPappingGeneric<T>(IList<T> data, string key, string value, int? keySelected = null)
        {
            return GetDropDownPappingGeneric(data, key, value, new List<int> { keySelected == null ? -1 : keySelected.Value });
        }

        public static List<SelectListItem> GetDropDownPappingGeneric<T>(IList<T> data, string key, string value)
        {
            return GetDropDownPappingGeneric(data, key, value, new List<int> { -1});
        }

        public static IEnumerable<SelectListItem> GetDropDownPappingGenericBool(bool selected = false)
        {
            var list = new List<SelectListItem> { new SelectListItem() { Text = "si", Value = "true", Selected = selected == true }, new SelectListItem() { Text = "no", Value = "false", Selected = selected == false } };
            return list;
        }

        public static MultiSelectList GetDropDownMultiplePappingGeneric<T>(List<T> data, string key, string value, List<int> keySelected = null)
        {
            var items = new MultiSelectList(data, key, value, keySelected);

            return items;
        }
    }
}
