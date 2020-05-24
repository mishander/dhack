using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Parser
{
    public static class RegexParser
    {
        private static string[] namePatterns = { "КЛОПОТАННЯ", "ЗАЯВА" };
        private static string docPattern = "а.?20\\d{1,3}.?\\d{0,5}";
        private static string docDatePattern = "(?<=(а.?20\\d{1,3}.?\\d{0,5})).*";
        private static string applicantPattern = "(?<=Заявник)(?:(?!$).)*";
        private static string ppPattern = "Патентний повірений(?:(?!$).)*";

        private static string RegexTextSinglePattern(string text, string pattern)
        {
            // Create a Regex
            Regex rg = new Regex(pattern);
            MatchCollection matched = rg.Matches(text);
            if (matched.Count > 0)
                return matched[0].Value;
            else
                return "";
        }

        private static string RegexTextMultiplePattern(string text, string[] patterns)
        {
            foreach (string pattern in patterns)
            {
                Regex rg = new Regex(pattern);
                MatchCollection matched = rg.Matches(text);
                if (matched.Count > 0)
                    return matched[0].Value;
            }
            return "";
        }

        public static Dictionary<string, KeyValuePair<string, bool>> RegexSearch(string line)
        {
            Dictionary<string, KeyValuePair<string, bool>> res = new Dictionary<string, KeyValuePair<string, bool>>();
            foreach (string pattern in namePatterns)
            {
                if (line.Contains(pattern))
                {
                    res.Add("NameText", new KeyValuePair<string, bool>(pattern, true));
                    res.Add("RecognizedMainText", new KeyValuePair<string, bool>(RegexTextSinglePattern(line, "(?<=" + pattern + ")[\\r\\n]+([^\\r\\n]+)"), true));
                }
            }
            //doc number regexp:
            res.Add("DocNumberText", new KeyValuePair<string, bool>(RegexTextSinglePattern(line, docPattern), true));
            //doc number line
            res.Add("DocNumberDate", new KeyValuePair<string, bool>(RegexTextSinglePattern(line, docDatePattern), true));
            // who
            res.Add("ppText", new KeyValuePair<string, bool>(RegexTextSinglePattern(line, ppPattern), true));
            // applicant
            res.Add("applicantText", new KeyValuePair<string, bool>(RegexTextSinglePattern(line, applicantPattern), true));
            return res;
        }
    }
}
