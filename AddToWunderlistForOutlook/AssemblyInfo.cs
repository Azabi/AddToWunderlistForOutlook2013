using System.Diagnostics;
using System.Reflection;

namespace AddToWunderlistForOutlook
{
    public static class AssemblyInfo
    {
        public static string Title
        {
            get
            {
                var result = string.Empty;
                var assembly = Assembly.GetCallingAssembly();

                var customAttributes = assembly.GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (customAttributes.Length > 0)
                {
                    result = ((AssemblyTitleAttribute)customAttributes[0]).Title;
                }

                return result;
            }
        }

        public static string Description
        {
            get
            {
                var result = string.Empty;
                var assembly = Assembly.GetCallingAssembly();

                var customAttributes = assembly.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (customAttributes.Length > 0)
                {
                    result = ((AssemblyDescriptionAttribute)customAttributes[0]).Description;
                }

                return result;
            }
        }

        public static string Company
        {
            get
            {
                var result = string.Empty;
                var assembly = Assembly.GetCallingAssembly();

                var customAttributes = assembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (customAttributes.Length > 0)
                {
                    result = ((AssemblyCompanyAttribute)customAttributes[0]).Company;
                }

                return result;
            }
        }

        public static string Product
        {
            get
            {
                var result = string.Empty;
                var assembly = Assembly.GetCallingAssembly();

                var customAttributes = assembly.GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (customAttributes.Length > 0)
                {
                    result = ((AssemblyProductAttribute)customAttributes[0]).Product;
                }

                return result;
            }
        }

        public static string Copyright
        {
            get
            {
                var result = string.Empty;
                var assembly = Assembly.GetCallingAssembly();

                var customAttributes = assembly.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (customAttributes.Length > 0)
                {
                    result = ((AssemblyCopyrightAttribute)customAttributes[0]).Copyright;
                }

                return result;
            }
        }

        public static string Trademark
        {
            get
            {
                var result = string.Empty;
                var assembly = Assembly.GetCallingAssembly();

                var customAttributes = assembly.GetCustomAttributes(typeof(AssemblyTrademarkAttribute), false);
                if (customAttributes.Length > 0)
                {
                    result = ((AssemblyTrademarkAttribute)customAttributes[0]).Trademark;
                }

                return result;
            }
        }

        public static string AssemblyVersion
        {
            get
            {
                var assembly = Assembly.GetCallingAssembly();
                return assembly.GetName().Version.ToString();
            }
        }

        public static string FileVersion
        {
            get
            {
                var assembly = Assembly.GetCallingAssembly();
                var fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
                return fvi.FileVersion;
            }
        }

        public static string Guid
        {
            get
            {
                var result = string.Empty;
                var assembly = Assembly.GetCallingAssembly();

                var customAttributes = assembly.GetCustomAttributes(typeof(System.Runtime.InteropServices.GuidAttribute), false);
                if (customAttributes.Length > 0)
                {
                    result = ((System.Runtime.InteropServices.GuidAttribute)customAttributes[0]).Value;
                }

                return result;
            }
        }

        public static string FileName
        {
            get
            {
                var assembly = Assembly.GetCallingAssembly();
                var fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
                return fvi.OriginalFilename;
            }
        }

        public static string FilePath
        {
            get
            {
                var assembly = Assembly.GetCallingAssembly();
                var fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
                return fvi.FileName;
            }
        }
    }
}


