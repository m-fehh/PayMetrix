using PayMetrix.Debugging;

namespace PayMetrix
{
    public class PayMetrixConsts
    {
        public const string LocalizationSourceName = "PayMetrix";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "b511956c64fe444c938b29f333fea095";
    }
}
