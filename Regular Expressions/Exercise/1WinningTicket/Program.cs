using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _1WinningTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = new StringBuilder();

            string pattern = @"(\@{6,}|\${6,}|\^{6,}|\#{6,})";

            var tickets = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            Regex regex = new Regex(pattern);

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    result.Append($"invalid ticket{Environment.NewLine}");
                    continue;
                }
               
                var leftMatch = regex.Match(ticket.Substring(0, 10));
                var rightMatch = regex.Match(ticket.Substring(0, 10));
                var minLengt = Math.Min(leftMatch.Length, rightMatch.Length);

                if (!leftMatch.Success || !rightMatch.Success)
                {
                    result.Append($"ticket \"{ticket}\" - no match{Environment.NewLine}");
                    continue;
                }

                var leftPart = leftMatch.Value.Substring(0, minLengt);
                var rightPart = rightMatch.Value.Substring(0, minLengt);

                if (leftPart.Equals(rightPart))
                {
                    if (leftPart.Length == 10)
                    {
                        result.Append($"ticket \"{ticket}\" - {minLengt}{leftPart.Substring(0, 1)} Jackpot!{Environment.NewLine}");
                    }
                    else
                    {
                        result.Append($"ticket \"{ticket}\" - {minLengt}{leftPart.Substring(0, 1)}{Environment.NewLine}");
                    }
                }
                else
                {
                    result.Append($"ticket \"{ticket}\" - no match{Environment.NewLine}");
                }
            }

            Console.Write(result.ToString());
        }
    }
}
