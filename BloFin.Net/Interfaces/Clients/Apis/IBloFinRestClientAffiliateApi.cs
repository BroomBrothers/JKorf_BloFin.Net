using BloFin.Net.Objects.Models;
using CryptoExchange.Net.Interfaces.Clients;
using CryptoExchange.Net.Objects;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BloFin.Net.Interfaces.Clients.Apis
{
    /// <summary>
    /// BloFin affiliate API endpoints
    /// </summary>
    public interface IBloFinRestClientAffiliateApi : IRestApiClient, IDisposable
    {
        /// <summary>
        /// Retrieve the direct invitees info of the affiliate
        /// <para><a href="https://docs.blofin.com/index.html#get-direct-invitees" /></para>
        /// </summary>
        /// <param name="uid">Invitee's UID</param>
        /// <param name="needEquity">Whether to return the user's equity in the results.</param>
        /// <param name="afterId">Returns results after this id</param>
        /// <param name="beforeId">Returns results before this id</param>
        /// <param name="startTime">Filter by start time</param>
        /// <param name="endTime">Filter by end time</param>
        /// <param name="limit">Max number of results, max 200. Max 30 when needEquity is true</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<BloFinInvitee[]>> GetDirectInvitees(string? uid = null, bool? needEquity = null, string? afterId = null, string? beforeId = null, DateTime? startTime = null, DateTime? endTime = null, int limit = 30, CancellationToken ct = default);

        /// <summary>
        /// Retrieve the info of sub affiliates.
        /// <para><a href="https://docs.blofin.com/index.html#get-sub-affiliates" /></para>
        /// </summary>
        /// <param name="subAffiliateUid">Sub Affiliates UID</param>
        /// <param name="afterId">Returns results after this id</param>
        /// <param name="beforeId">Returns results before this id</param>
        /// <param name="startTime">Filter by start time</param>
        /// <param name="endTime">Filter by end time</param>
        /// <param name="limit">Max number of results, max 100.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<BloFinSubAffiliate[]>> GetSubAffiliates(string? subAffiliateUid = null, string? afterId = null, string? beforeId = null, DateTime? startTime = null, DateTime? endTime = null, int limit = 100, CancellationToken ct = default);

        /// <summary>
        /// Retrieve the invitees info of sub affiliates.
        /// <para><a href="https://docs.blofin.com/index.html#get-sub-invitees" /></para>
        /// </summary>
        /// <param name="subAffiliateUid">Sub Affiliates UID</param>
        /// <param name="afterId">Returns results after this id</param>
        /// <param name="beforeId">Returns results before this id</param>
        /// <param name="startTime">Filter by start time</param>
        /// <param name="endTime">Filter by end time</param>
        /// <param name="limit">Max number of results, max 30.</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns></returns>
        Task<WebCallResult<BloFinSubInvitee[]>> GetSubInvitees(string? subAffiliateUid = null, string? afterId = null, string? beforeId = null, DateTime? startTime = null, DateTime? endTime = null, int limit = 30, CancellationToken ct = default);
    }
}
