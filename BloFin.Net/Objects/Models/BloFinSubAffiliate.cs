using System;
using System.Text.Json.Serialization;

namespace BloFin.Net.Objects.Models;

/// <summary>
/// BloFin Sub Affiliate
/// </summary>
public class BloFinSubAffiliate
{
    /// <summary>
    /// Id
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; set; }
    /// <summary>
    /// UID of sub-affiliate
    /// </summary>
    [JsonPropertyName("uid")]
    public string Uid { get; set; } = string.Empty;
    /// <summary>
    /// Commission rate of sub affiliate
    /// </summary>
    [JsonPropertyName("commissionRate")]
    public string CommissionRate { get; set; } = string.Empty;
    /// <summary>
    /// Create time of sub affiliate.
    /// </summary>
    [JsonPropertyName("createTime")]
    public DateTime CreateTime { get; set; }
    /// <summary>
    /// Upper affiliate of sub affiliate.
    /// </summary>
    [JsonPropertyName("upperAffiliate")]
    public string UpperAffiliate { get; set; } = string.Empty;
    /// <summary>
    /// Total invitees of sub affiliate.
    /// </summary>
    [JsonPropertyName("invitees")]
    public int Invitees { get; set; }
    /// <summary>
    /// Total traded invitees of sub affiliate.
    /// </summary>
    [JsonPropertyName("totalTradedUsers")]
    public int TotalTradedUsers { get; set; }
    /// <summary>
    /// Total futures trading volume of sub affiliates invitees.
    /// </summary>
    [JsonPropertyName("totalTradingVolume")]
    public decimal TotalTradingVolume { get; set; }
    /// <summary>
    /// Total futures trading fee of sub affiliates invitees.
    /// </summary>
    [JsonPropertyName("totalTradingFee")]
    public string TotalTradingFee { get; set; } = string.Empty;
    /// <summary>
    /// Total commission of sub affiliate
    /// </summary>
    [JsonPropertyName("totalCommision")]
    public string TotalCommission { get; set; } = string.Empty;
    /// <summary>
    /// My commission got from sub affiliate
    /// </summary>
    [JsonPropertyName("myCommision")]
    public string MyCommision { get; set; } = string.Empty;
    /// <summary>
    /// Tag
    /// </summary>
    [JsonPropertyName("tag")]
    public string Tag { get; set; } = string.Empty;
    /// <summary>
    /// KYC level of invitee
    ///  - 0 = Non KYC
    ///  - 1 = Complete personal information verification
    ///  - 2 = Complete address proof verification
    /// </summary>
    [JsonPropertyName("kycLevel")]
    public int KycLevel { get; set; }
}