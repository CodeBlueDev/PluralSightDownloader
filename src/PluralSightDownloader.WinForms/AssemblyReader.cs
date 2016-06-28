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
            this._assembly = assembly ?? Assembly.GetEntryAssembly();
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
                        this._assemblyAttributes[customAttributeType.Name] = value;
                    }
                }
            }
            // TODO: Remove magic strings
            // If AssemblyTitle was empty, put in the assembly name.
            if (this._assemblyAttributes.ContainsKey("AssemblyTitleAttribute") && 
                string.IsNullOrEmpty(this._assemblyAttributes["AssemblyTitleAttribute"]))
            {
                this._assemblyAttributes["AssemblyTitleAttribute"] = this.AssemblyName.Name;
            }
            // If AssemblyVersion was empty, put in the assembly name version
            if (!this._assemblyAttributes.ContainsKey("AssemblyVersionAttribute") || 
                string.IsNullOrEmpty(this._assemblyAttributes["AssemblyVersionAttribute"]))
            {
                this._assemblyAttributes["AssemblyVersionAttribute"] = this.AssemblyName.Version.ToString();
            }
        }

        private AssemblyName AssemblyName
        {
            get { return this._assemblyName ?? (this._assemblyName = this._assembly.GetName()); }
        }

        internal string GetAssemblyProperty(string key)
        {
            return this._assemblyAttributes.ContainsKey(key) 
                ? this._assemblyAttributes[key] : 
                string.Empty;
        }

        internal string[] GetReferencedAssemblyNames()
        {
            List<string> referencedAssemblies = new List<string>();
            foreach (AssemblyName referencedAssembly in this._assembly.GetReferencedAssemblies())
            {
                referencedAssemblies.Add(referencedAssembly.FullName);
            }
            return referencedAssemblies.ToArray();
        }
    }
}
