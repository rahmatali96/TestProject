using TestProject.Debugging;

namespace TestProject
{
    public class TestProjectConsts
    {
        public const string LocalizationSourceName = "TestProject";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "8d3c34e5a62e4781b3076b39bbb351e4";
    }
}
