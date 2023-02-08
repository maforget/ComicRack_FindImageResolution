using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FindImageResolutionNET.Tools
{
    public static class Reflections
    {
        public static object GetPropertyValue(this Type type, object obj, string PropertyName)
        {
            try
            {
                PropertyInfo property = type.GetProperty(PropertyName);
                return property.GetValue(obj);
            }
            catch (Exception e)
            {
                SimpleLogger.Error($"Exception: {e.Message}. PropertyName: {PropertyName}");
                return null;
            }
        }

        public static void SetPropertyValue(this object obj, string PropertyName, object value)
        {
            try
            {
                Type type = obj.GetType();
                PropertyInfo property = type.GetProperty(PropertyName);
                property.SetValue(obj, value);
            }
            catch (Exception e)
            {
                SimpleLogger.Error($"Exception: {e.Message}. PropertyName: {PropertyName}");
            }
        }

        public static object GetDefault(this PropertyInfo pi)
        {
            var def = pi.GetCustomAttribute<DefaultValueAttribute>();
            return def != null ? def.Value :
                pi.PropertyType.IsValueType ? Activator.CreateInstance(pi.PropertyType) : null;
        }

        public static T Get<T>(this object sourceObject, string property)
        {
            try
            {
                var type = sourceObject.GetType();
                var prop = type.GetProperty(property);
                var ret = type.GetPropertyValue(sourceObject, property);
                return (T)Convert.ChangeType(ret, typeof(T));
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        public static object InvokeMethod(this object sourceObject, string Method, params object[] param)
        {
            try
            {
                return sourceObject.GetType().GetMethod(Method).Invoke(sourceObject, param);
            }
            catch (Exception e)
            {
                SimpleLogger.Error($"Exception: {e.Message}");
                return null; 
            }
        }
    }
}
