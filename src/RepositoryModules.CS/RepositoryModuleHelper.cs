using System;
using System.IO;
using System.Linq;
using System.Text;

namespace RepositoryModules
{
    static class RepositoryModuleHelper
    {
        public static Condition[] ReadSecondaryConditionsFile()
        {
            var filePath = MySettings.Default.SecondaryConditionFilePath;

            if (!File.Exists(filePath))
                return Array.Empty<Condition>();

            var text = File.ReadAllText(filePath, Encoding.GetEncoding("shift_jis"));

            return text.Split(new[] { Environment.NewLine }, StringSplitOptions.None)
                .Select(x => x.Split(','))
                .Where(x => x.Length == 2)
                .Select(x => new Condition(x[0], x[1]))
                .ToArray();
        }
    }
}
