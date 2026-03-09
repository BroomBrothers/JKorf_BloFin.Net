using BloFin.Net.Clients.MessageHandlers;
using BloFin.Net.Interfaces.Clients.Apis;
using BloFin.Net.Objects.Models;
using BloFin.Net.Objects.Options;
using CryptoExchange.Net.Converters.MessageParsing.DynamicConverters;
using CryptoExchange.Net.Objects;
using CryptoExchange.Net.Objects.Errors;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace BloFin.Net.Clients.Apis
{
    internal class BloFinRestClientAffiliateApi : BloFinRestClientApi, IBloFinRestClientAffiliateApi
    {
        protected override ErrorMapping ErrorMapping => BloFinErrors.Errors;
        protected override IRestMessageHandler MessageHandler { get; } = new BloFinRestMessageHandler(BloFinErrors.Errors);

        private static readonly RequestDefinitionCache _definitions = new RequestDefinitionCache();

        internal BloFinRestClientAffiliateApi(ILogger logger, HttpClient? httpClient, BloFinRestOptions options)
            : base(logger, httpClient, options.Environment.RestClientAddress, options, options.ExchangeOptions)
        {
        }

        /// <inheritdoc />
        public async Task<WebCallResult<BloFinInvitee[]>> GetDirectInvitees(string? uid = null, bool? needEquity = null, string? afterId = null, string? beforeId = null,
            DateTime? startTime = null, DateTime? endTime = null, int limit = 30, CancellationToken ct = default)
        {
            var parameters = new ParameterCollection();
            parameters.AddOptional("uid", uid);
            parameters.AddOptional("after", afterId);
            parameters.AddOptional("before", beforeId);
            parameters.AddOptionalMillisecondsString("begin", startTime);
            parameters.AddOptionalMillisecondsString("end", endTime);
            parameters.AddOptional("limit", limit);

            var request = _definitions.GetOrCreate(HttpMethod.Get, "/api/v1/affiliate/invitees", BloFinExchange.RateLimiter.BloFinRest, 1, true);
            return await SendAsync<BloFinInvitee[]>(request, parameters, ct).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<WebCallResult<BloFinSubAffiliate[]>> GetSubAffiliates(string? subAffiliateUid = null, string? afterId = null, string? beforeId = null,
            DateTime? startTime = null, DateTime? endTime = null, int limit = 100, CancellationToken ct = default)
        {
            var parameters = new ParameterCollection();
            parameters.AddOptional("subAffiliateUid", subAffiliateUid);
            parameters.AddOptional("after", afterId);
            parameters.AddOptional("before", beforeId);
            parameters.AddOptionalMillisecondsString("begin", startTime);
            parameters.AddOptionalMillisecondsString("end", endTime);
            parameters.AddOptional("limit", limit);

            var request = _definitions.GetOrCreate(HttpMethod.Get, "/api/v1/affiliate/sub-affiliates", BloFinExchange.RateLimiter.BloFinRest, 1, true);
            return await SendAsync<BloFinSubAffiliate[]>(request, parameters, ct).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<WebCallResult<BloFinSubInvitee[]>> GetSubInvitees(string? subAffiliateUid = null, string? afterId = null, string? beforeId = null, DateTime? startTime = null,
            DateTime? endTime = null, int limit = 30, CancellationToken ct = default)
        {
            var parameters = new ParameterCollection();
            parameters.AddOptional("subAffiliateUid", subAffiliateUid);
            parameters.AddOptional("after", afterId);
            parameters.AddOptional("before", beforeId);
            parameters.AddOptionalMillisecondsString("begin", startTime);
            parameters.AddOptionalMillisecondsString("end", endTime);
            parameters.AddOptional("limit", limit);

            var request = _definitions.GetOrCreate(HttpMethod.Get, "/api/v1/affiliate/sub-invitees", BloFinExchange.RateLimiter.BloFinRest, 1, true);
            return await SendAsync<BloFinSubInvitee[]>(request, parameters, ct).ConfigureAwait(false);
        }
    }
}
