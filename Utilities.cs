using ABA_Creator.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABA_Creator
{
    public static class Utilities
    {
        public enum PadSide
        {
            LEFT,
            RIGHT
        }

        public static string Pad(string input, PadSide side, int length, string padChar)
        {
            string pad = "";
            Console.WriteLine($"Length: {input.Length} Pad Length: {length}");
            for (int i=0;i<length-input.Length;i++)
            {
                pad += padChar;
                
            }
            switch(side)
            {
                case PadSide.LEFT:
                    return $"{pad}{input}";
                case PadSide.RIGHT:
                    return $"{input}{pad}";
                default:
                    return $"{pad}{input}";
            }
        }

        public static string Pad(int length, string padChar)
        {
            return Pad("", PadSide.LEFT, length, padChar);
        }

        public static string BlankPad(string input, PadSide side,int length)
        {
            return Pad(input, side, length, "   ");
        }

        public static string ZeroPad(string input, PadSide side, int length)
        {
            return Pad(input, side, length, "0");
        }

        public static PaymentSender GetCurrentPayer()
        {
            List<PaymentSender> m_Payers = JsonConvert.DeserializeObject<List<PaymentSender>>(Properties.Settings.Default.Payers);
            if (Properties.Settings.Default.ActivePayer>=0 && Properties.Settings.Default.ActivePayer <= m_Payers.Count)
            {
                return m_Payers[Properties.Settings.Default.ActivePayer];
            }
            else
            {
                return null;
            }

        }

        public static PaymentRecipient GetPayeeFromID(int id)
        {
            List<PaymentRecipient> m_Payees = JsonConvert.DeserializeObject<List<PaymentRecipient>>(Properties.Settings.Default.Payees);
            if (id >= 0 && id <= m_Payees.Count)
            {
                return m_Payees[id];
            }
            else
            {
                return null;
            }
        }

        public static List<PaymentRecipient> GetPayees()
        {
            List<PaymentRecipient> m_Payees = JsonConvert.DeserializeObject<List<PaymentRecipient>>(Properties.Settings.Default.Payees);
            return m_Payees;
        }

        public static void SetPayees(List<PaymentRecipient> _Payees)
        {
            Properties.Settings.Default.Payees = JsonConvert.SerializeObject(_Payees);
            Properties.Settings.Default.Save();
        }
    }
}
