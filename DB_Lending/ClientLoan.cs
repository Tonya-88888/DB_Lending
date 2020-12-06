using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Lending
{
	/*PKClientLoan int IDENTITY NOT NULL PRIMARY KEY,
	FKBankLoan int NOT NULL,
	FKClient int NOT NULL,
	TermsLoan tinyint NOT NULL,
	SumLoan money NOT NULL,
	StartDate date NOT NULL,
	EndDate date NOT NULL, -- предполагаемая
	PaidOut bit NOT NULL, -- выплачено
	BalanceOwed money NOT NULL, --остаток осн долга
	Returned money NOT NULL, --сколько выплатил клиент с %
	PrePenalty DECIMAL(6,3)  NOT NULL,  -- штраф за предоплату в %
	DelayPenalty DECIMAL(6,3)  NOT NULL,  -- штраф за задержку в %
	
	FKPledge int NULL,
	FKRate int NULL,
	--ставка %
	--id валюты
	--	FKRate int NULL,
*/
	public class ClientLoan
    {
        int idBankLoan;
		int idClient;
		int termsLoan;
		decimal sumLoan;
		decimal prePenalty;
		decimal delayPenalty;
		decimal rate;
		int termsFrom;
		int tetrmsBefore;
		int countGuarantor;
		int isPledge;

        public int IdBankLoan { get => idBankLoan; set => idBankLoan = value; }
        public int IdClient { get => idClient; set => idClient = value; }
        public int TermsLoan { get => termsLoan; set => termsLoan = value; }
        public decimal SumLoan { get => sumLoan; set => sumLoan = value; }
        public decimal PrePenalty { get => prePenalty; set => prePenalty = value; }
        public decimal DelayPenalty { get => delayPenalty; set => delayPenalty = value; }
        public decimal Rate { get => rate; set => rate = value; }
       
        public int TermsFrom { get => termsFrom; set => termsFrom = value; }
        public int TetrmsBefore { get => tetrmsBefore; set => tetrmsBefore = value; }
        public int CountGuarantor { get => countGuarantor; set => countGuarantor = value; }
        public int IsPledge { get => isPledge; set => isPledge = value; }
    }
}
