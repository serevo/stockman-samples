using System;
using System.IO;
using System.Linq;
using System.Text;

namespace RepositoryModules
{
    static class RepositoryModuleHelper
    {
        public static SecondaryCondition[] ReadSecondaryConditionsFile()
        {
            var filePath = MySettings.Default.SecondaryConditionFilePath;

            if (!File.Exists(filePath))
                return Array.Empty<SecondaryCondition>();

            var text = File.ReadAllText(filePath, Encoding.GetEncoding("shift_jis"));

            return text.Split(new[] { Environment.NewLine }, StringSplitOptions.None)
                .Select(x => x.Split(','))
                .Where(x => x.Length == 2)
                .Select(x => new SecondaryCondition(x[0], x[1]))
                .ToArray();
        }
    }
}
