using System;
using System.Collections.Generic;
using System.Reflection;

namespace PluralSightDownloader.WinForms
{
    internal class AssemblyReader
    {
        private readonly Assembly _assembly;

        private AssemblyName _assemblyName;

        private readonly Dictionary<string, string> _assemblyAttributes = new Dictionary<string, string>(); 

        internal AssemblyReader(Assembly assembly = null)
        {
            _assembly = assembly ?? Assembly.GetEntryAssembly();
            foreach (Attribute attribute in assembly.GetCustomAttributes())
            {
                Type customAttributeType = attribute.GetType();
                foreach (PropertyInfo propertyInfo in customAttributeType.GetProperties())
                {
                    if (propertyInfo.Name.Equals("TypeId"))
                    {
                        continue;
                    }
                    string value = propertyInfo.GetValue(attribute).ToString();
                    if (!string.IsNullOrEmpty(value))
                    {
                        _assemblyAttributes[customAttributeType.Name] = value;
                    }
                }
            }
            // TODO: Remove magic strings
            // If AssemblyTitle was empty, put in the assembly name.
            if (_assemblyAttributes.ContainsKey("AssemblyTitleAttribute") && 
                string.IsNullOrEmpty(_assemblyAttributes["AssemblyTitleAttribute"]))
            {
                _assemblyAttributes["AssemblyTitleAttribute"] = AssemblyName.Name;
            }
            // If AssemblyVersion was empty, put in the assembly name version
            if (!_assemblyAttributes.ContainsKey("AssemblyVersionAttribute") || 
                string.IsNullOrEmpty(_assemblyAttributes["AssemblyVersionAttribute"]))
            {
                _assemblyAttributes["AssemblyVersionAttribute"] = AssemblyName.Version.ToString();
            }
        }

        private AssemblyName AssemblyName
        {
            get { return _assemblyName ?? (_assemblyName = _assembly.GetName()); }
        }

        internal string GetAssemblyProperty(string key)
        {
            return _assemblyAttributes.ContainsKey(key) 
                ? _assemblyAttributes[key] : 
                string.Empty;
        }

        internal string[] GetReferencedAssemblyNames()
        {
            List<string> referencedAssemblies = new List<string>();
            foreach (AssemblyName referencedAssembly in _assembly.GetReferencedAssemblies())
            {
                referencedAssemblies.Add(referencedAssembly.FullName);
            }
            return referencedAssemblies.ToArray();
        }
    }
}
