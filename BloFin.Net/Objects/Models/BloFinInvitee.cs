using System;
using System.Text.Json.Serialization;

namespace BloFin.Net.Objects.Models
{
    /// <summary>
    /// Blofin Direct Invitee
    /// </summary>
    public class BloFinInvitee
    {
        /// <summary>
        /// Id
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
        /// <summary>
        /// UID of invitee
        /// </summary>
        [JsonPropertyName("uid")]
        public string Uid { get; set; } = string.Empty;
        /// <summary>
        /// Total futures trading amount of invitee
        /// </summary>
        [JsonPropertyName("totalTradingVolume")]
        public decimal TotalTradingVolume { get; set; }
        /// <summary>
        /// Total futures trading fee of invitee
        /// </summary>
        [JsonPropertyName("totalTradingFee")]
        public decimal TotalTradingFee { get; set; }
        /// <summary>
        /// Total commission of invitee
        /// </summary>
        [JsonPropertyName("totalCommision")]
        public decimal TotalCommission { get; set; }
        /// <summary>
        /// Total deposit amount, expressed in USDT.
        /// </summary>
        [JsonPropertyName("totalDeposit")]
        public decimal TotalDeposit { get; set; }
        /// <summary>
        /// Total withdrawn amount, expressed in USDT.
        /// </summary>
        [JsonPropertyName("totalWithdrawal")]
        public decimal TotalWithdrawal { get; set; }
        /// <summary>
        /// Total equity of futures account in USDT.
        /// </summary>
        /// <remarks>0 when not requested</remarks>
        [JsonPropertyName("equity")]
        public decimal Equity { get; set; }
        /// <summary>
        /// Total equity of all accounts in USDT.
        /// </summary>
        /// <remarks>0 when not requested</remarks>
        [JsonPropertyName("totalEquity")]
        public decimal TotalEquity { get; set; }
        /// <summary>
        /// KYC level of invitee
        ///  - 0 = Non KYC
        ///  - 1 = Complete personal information verification
        ///  - 2 = Complete address proof verification
        /// </summary>
        [JsonPropertyName("kycLevel")]
        public int KycLevel { get; set; }
        /// <summary>
        /// Register time of invitee
        /// </summary>
        [JsonPropertyName("registerTime")]
        public DateTime RegisterTime { get; set; }
    }
}
