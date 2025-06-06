﻿using HigLabo.Net.OAuth;
using System.Runtime.CompilerServices;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/bookingbusiness-list-staffmembers?view=graph-rest-1.0
/// </summary>
public partial class BookingBusinessListStaffMembersParameter : IRestApiParameter, IQueryParameterProperty
{
    public class ApiPathSettings
    {
        public ApiPath ApiPath { get; set; }
        public string? Id { get; set; }

        public string GetApiPath()
        {
            switch (this.ApiPath)
            {
                case ApiPath.Solutions_BookingBusinesses_Id_StaffMembers: return $"/solutions/bookingBusinesses/{Id}/staffMembers";
                default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
            }
        }
    }

    public enum Field
    {
    }
    public enum ApiPath
    {
        Solutions_BookingBusinesses_Id_StaffMembers,
    }

    public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
    string IRestApiParameter.ApiPath
    {
        get
        {
            return this.ApiPathSetting.GetApiPath();
        }
    }
    string IRestApiParameter.HttpMethod { get; } = "GET";
    public QueryParameter<Field> Query { get; set; } = new QueryParameter<Field>();
    IQueryParameter IQueryParameterProperty.Query
    {
        get
        {
            return this.Query;
        }
    }
}
public partial class BookingBusinessListStaffMembersResponse : RestApiResponse<BookingStaffMember>
{
}
/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/bookingbusiness-list-staffmembers?view=graph-rest-1.0
/// </summary>
public partial class MicrosoftClient
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/bookingbusiness-list-staffmembers?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<BookingBusinessListStaffMembersResponse> BookingBusinessListStaffMembersAsync()
    {
        var p = new BookingBusinessListStaffMembersParameter();
        return await this.SendAsync<BookingBusinessListStaffMembersParameter, BookingBusinessListStaffMembersResponse>(p, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/bookingbusiness-list-staffmembers?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<BookingBusinessListStaffMembersResponse> BookingBusinessListStaffMembersAsync(CancellationToken cancellationToken)
    {
        var p = new BookingBusinessListStaffMembersParameter();
        return await this.SendAsync<BookingBusinessListStaffMembersParameter, BookingBusinessListStaffMembersResponse>(p, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/bookingbusiness-list-staffmembers?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<BookingBusinessListStaffMembersResponse> BookingBusinessListStaffMembersAsync(BookingBusinessListStaffMembersParameter parameter)
    {
        return await this.SendAsync<BookingBusinessListStaffMembersParameter, BookingBusinessListStaffMembersResponse>(parameter, CancellationToken.None);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/bookingbusiness-list-staffmembers?view=graph-rest-1.0
    /// </summary>
    public async ValueTask<BookingBusinessListStaffMembersResponse> BookingBusinessListStaffMembersAsync(BookingBusinessListStaffMembersParameter parameter, CancellationToken cancellationToken)
    {
        return await this.SendAsync<BookingBusinessListStaffMembersParameter, BookingBusinessListStaffMembersResponse>(parameter, cancellationToken);
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/bookingbusiness-list-staffmembers?view=graph-rest-1.0
    /// </summary>
    public async IAsyncEnumerable<BookingStaffMember> BookingBusinessListStaffMembersEnumerateAsync(BookingBusinessListStaffMembersParameter parameter, [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        var res = await this.SendAsync<BookingBusinessListStaffMembersParameter, BookingBusinessListStaffMembersResponse>(parameter, cancellationToken);
        if (res.Value != null)
        {
            foreach (var item in res.Value)
            {
                yield return item;
            }
            if (res.ODataNextLink.HasValue())
            {
                await foreach (var item in this.GetValueListAsync<BookingStaffMember>(res.ODataNextLink, cancellationToken))
                {
                    yield return item;
                }
            }
        }
    }
}
