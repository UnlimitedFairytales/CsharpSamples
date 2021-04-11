using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace UnlimitedFairytales.CsharpSamples.UtilitySamples.Extensions
{
    public static class VarDumpExtension
    {
        public static string var_dump(this object o, int searchLevel = 7)
        {
            return var_dumpInner(o, searchLevel, 0, false);
        }

        private static string var_dumpInner(object o, int searchLevel, int currentLevel, bool alreadyIndented)
        {
            var t = o.GetType();
            var result = "";
            var indent = new String(' ', currentLevel * 2);
            if (currentLevel < searchLevel)
            {
                if (t.Equals(typeof(DateTime)))
                {

                }
                else if (t.IsArray)
                {
                    result += (alreadyIndented ? "" : indent) + "Array" + " [" + Environment.NewLine;
                    foreach (var item in (Array)o)
                    {
                        result += var_dumpInner(item, searchLevel, currentLevel + 1, false);
                    }
                    result += indent + "]" + Environment.NewLine;
                    return result;
                }
                else if (ImplementsGenericIEnumerableWithoutString(t))
                {
                    result += (alreadyIndented ? "" : indent) + t.Name.Remove(t.Name.IndexOf('`')) + "<>" + " [" + Environment.NewLine;
                    foreach (var item in (IEnumerable)o)
                    {
                        result += var_dumpInner(item, searchLevel, currentLevel + 1, false);
                    }
                    result += indent + "]" + Environment.NewLine;
                    return result;
                }
                else if (!t.IsPrimitive && !(o is decimal) && !(o is string) && !o.GetType().IsEnum)
                {

                    var typeType = t.IsClass ? "class" : "valueType";
                    result += (alreadyIndented ? "" : indent) + typeType + " " + t.Name + " {" + Environment.NewLine;
                    foreach (var memInfo in t.GetProperties())
                    {
                        var memberValue = memInfo.GetValue(o);
                        result += indent + "  " + "." + memInfo.Name + " => ";
                        result += var_dumpInner(memberValue, searchLevel, currentLevel + 1, true);
                    }
                    foreach (var memInfo in t.GetFields())
                    {
                        var memberValue = memInfo.GetValue(o);
                        result += indent + "  " + "." + memInfo.Name + " => ";
                        result += var_dumpInner(memberValue, searchLevel, currentLevel + 1, true);
                    }
                    result += indent + "}" + Environment.NewLine;
                    return result;
                }
            }
            return (alreadyIndented ? "" : indent) + o.GetType().Name + "(" + o.ToString() + ")" + Environment.NewLine;
        }

        private static bool ImplementsGenericIEnumerableWithoutString(Type t)
        {
            return t.GetInterfaces().Any(it
                => it.IsGenericType
                && it.GetGenericTypeDefinition() == typeof(IEnumerable<>)
                && !t.Equals(typeof(string)));
        }
    }
}
