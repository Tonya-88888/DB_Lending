using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Lending
{
    public class BankLoanData
    {
        private int currentId; 
        private String type;
        private String name;
        private String affiliation;
        private String rateType;
        private decimal prePenalty;
        private decimal delayPenalty;
        private int termsBefore;
        private int termsFrom;
        private string isPledge;
        private int guarNumber;

        public int CurrentId { get => currentId; set => currentId = value; }
        public string Type { get => type; set => type = value; }
        public string Name { get => name; set => name = value; }
        public string Affiliation { get => affiliation; set => affiliation = value; }
        public string RateType { get => rateType; set => rateType = value; }
        public decimal PrePenalty { get => prePenalty; set => prePenalty = value; }
        public decimal DelayPenalty { get => delayPenalty; set => delayPenalty = value; }
        public int TermsBefore { get => termsBefore; set => termsBefore = value; }
        public int TermsFrom { get => termsFrom; set => termsFrom = value; }
        public string IsPledge { get => isPledge; set => isPledge = value; }
        public int GuarNumber { get => guarNumber; set => guarNumber = value; }
    }
}
