using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System.Runtime.CompilerServices;

namespace University.Core.Helpers
{
    public class LoggingHelper
    {
        public static void LogValidationFaild(ILogger _logger, string extraInfo = "", [CallerMemberName] string methodName = "", [CallerFilePath] string filePath = "")
        {
            var className = Path.GetFileNameWithoutExtension(filePath);
            if(extraInfo.IsNullOrEmpty())
                _logger.LogWarning($"Validation Faild in {className} -> {methodName}");
            _logger.LogWarning($"Validation Faild in {className} -> {methodName} with {extraInfo}");

        }
    }
}
