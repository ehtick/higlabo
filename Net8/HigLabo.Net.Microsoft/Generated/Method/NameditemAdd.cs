﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/nameditem-add?view=graph-rest-1.0
    /// </summary>
    public partial class NamedItemAddParameter : IRestApiParameter
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? Id { get; set; }
            public string? ItemPath { get; set; }
            public string? IdOrName { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Me_Drive_Items_Id_Workbook_Names_Add: return $"/me/drive/items/{Id}/workbook/names/add";
                    case ApiPath.Me_Drive_Root_ItemPath_Workbook_Names_Add: return $"/me/drive/root:/{ItemPath}:/workbook/names/add";
                    case ApiPath.Me_Drive_Items_Id_Workbook_Worksheets_IdOrname_Names_Add: return $"/me/drive/items/{Id}/workbook/worksheets/{IdOrName}/names/add";
                    case ApiPath.Me_Drive_Root_ItemPath_Workbook_Worksheets_IdOrname_Names_Add: return $"/me/drive/root:/{ItemPath}:/workbook/worksheets/{IdOrName}/names/add";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum NamedItemstring
        {
            String,
            Integer,
            Double,
            Boolean,
            Range,
        }
        public enum ApiPath
        {
            Me_Drive_Items_Id_Workbook_Names_Add,
            Me_Drive_Root_ItemPath_Workbook_Names_Add,
            Me_Drive_Items_Id_Workbook_Worksheets_IdOrname_Names_Add,
            Me_Drive_Root_ItemPath_Workbook_Worksheets_IdOrname_Names_Add,
        }

        public ApiPathSettings ApiPathSetting { get; set; } = new ApiPathSettings();
        string IRestApiParameter.ApiPath
        {
            get
            {
                return this.ApiPathSetting.GetApiPath();
            }
        }
        string IRestApiParameter.HttpMethod { get; } = "POST";
        public string? Name { get; set; }
        public Json? Reference { get; set; }
        public string? Comment { get; set; }
        public string? Scope { get; set; }
        public NamedItemstring Type { get; set; }
        public Json? Value { get; set; }
        public bool? Visible { get; set; }
        public Worksheet? Worksheet { get; set; }
    }
    public partial class NamedItemAddResponse : RestApiResponse
    {
        public enum NamedItemstring
        {
            String,
            Integer,
            Double,
            Boolean,
            Range,
        }

        public string? Comment { get; set; }
        public string? Name { get; set; }
        public string? Scope { get; set; }
        public NamedItemstring Type { get; set; }
        public Json? Value { get; set; }
        public bool? Visible { get; set; }
        public Worksheet? Worksheet { get; set; }
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/nameditem-add?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/nameditem-add?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<NamedItemAddResponse> NamedItemAddAsync()
        {
            var p = new NamedItemAddParameter();
            return await this.SendAsync<NamedItemAddParameter, NamedItemAddResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/nameditem-add?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<NamedItemAddResponse> NamedItemAddAsync(CancellationToken cancellationToken)
        {
            var p = new NamedItemAddParameter();
            return await this.SendAsync<NamedItemAddParameter, NamedItemAddResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/nameditem-add?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<NamedItemAddResponse> NamedItemAddAsync(NamedItemAddParameter parameter)
        {
            return await this.SendAsync<NamedItemAddParameter, NamedItemAddResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/nameditem-add?view=graph-rest-1.0
        /// </summary>
        public async ValueTask<NamedItemAddResponse> NamedItemAddAsync(NamedItemAddParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<NamedItemAddParameter, NamedItemAddResponse>(parameter, cancellationToken);
        }
    }
}
