using System;
using System.Collections.Generic;

namespace todictionary
{
    public class StringUtilities
    {
        public IDictionary<string, string> ToDictionary(string configuration) {
            var settings = SplitIntoSettings(configuration);
            var keyValuePairs = SplitIntoKeyAndValue(settings);
            var dictionary = CreateDictionary(keyValuePairs);
            return dictionary;
        }

        private IEnumerable<string> SplitIntoSettings(string configuration) {
            return configuration.Split(new [] {";"}, StringSplitOptions.RemoveEmptyEntries);
        }

        private IEnumerable<KeyValuePair<string, string>> SplitIntoKeyAndValue(IEnumerable<string> settings) {
            foreach (var setting in settings) {
                var keyAndValue = setting.Split('=');
                if (keyAndValue[0] == "") {
                    throw new Exception();
                }
                yield return new KeyValuePair<string, string>(keyAndValue[0], keyAndValue[1]);
            }
        }

        private IDictionary<string, string> CreateDictionary(IEnumerable<KeyValuePair<string, string>> keyValuePairs) {
            var result = new Dictionary<string, string>();
            foreach (var keyValuePair in keyValuePairs) {
                result[keyValuePair.Key] = keyValuePair.Value;
            }
            return result;
        }
    }
}
