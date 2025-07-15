using Microsoft.IdentityModel.Tokens;
using System.Runtime.CompilerServices;

namespace University.API.Helpers
{
    public class LoggingHelper
    {
        public static void LogController(ILogger _logger, string extraInfo = "", [CallerMemberName] string methodName = "", [CallerFilePath] string filePath = "")
        {
            var className = Path.GetFileNameWithoutExtension(filePath);
            if (extraInfo.IsNullOrEmpty())
                _logger.LogInformation($"A new request in {className} -> {methodName}");
            _logger.LogInformation($"A new request in {className} -> {methodName} with {extraInfo}");

        }
    }
}
