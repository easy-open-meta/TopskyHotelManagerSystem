using EOM.TSHotelManager.Common;
using System.Reflection;

namespace EOM.TSHotelManager.FormUI
{
    public static class Initialize
    {
        public static void CustomizeInitialize()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);

            AppDomain.CurrentDomain.AssemblyLoad += OnAssemblyLoad;
            InitializeConstantsInLoadedAssemblies();
        }

        static void OnAssemblyLoad(object sender, AssemblyLoadEventArgs args)
        {
            InitializeConstantsInAssembly(args.LoadedAssembly);
        }

        static void InitializeConstantsInLoadedAssemblies()
        {
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                InitializeConstantsInAssembly(assembly);
            }
        }

        static void InitializeConstantsInAssembly(Assembly assembly)
        {
            var constantTypes = assembly.GetTypes()
                .Where(t => IsSubclassOfRawGeneric(typeof(Constant<>), t) && t.IsClass);

            foreach (var type in constantTypes)
            {
                var fields = type.GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
                foreach (var field in fields)
                {
                    var value = field.GetValue(null);
                }
            }
        }

        static bool IsSubclassOfRawGeneric(Type generic, Type toCheck)
        {
            while (toCheck != null && toCheck != typeof(object))
            {
                var cur = toCheck.IsGenericType ? toCheck.GetGenericTypeDefinition() : toCheck;
                if (generic == cur)
                {
                    return true;
                }
                toCheck = toCheck.BaseType;
            }
            return false;
        }
    }
}
