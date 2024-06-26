﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/team-completemigration?view=graph-rest-1.0
    /// </summary>
    public partial class TeamCompletemigrationParameter : IRestApiParameter
    {
        public class ApiPathSettings
        {
            public ApiPath ApiPath { get; set; }
            public string? TeamId { get; set; }

            public string GetApiPath()
            {
                switch (this.ApiPath)
                {
                    case ApiPath.Teams_TeamId_CompleteMigration: return $"/teams/{TeamId}/completeMigration";
                    default:throw new HigLabo.Core.SwitchStatementNotImplementException<ApiPath>(this.ApiPath);
                }
            }
        }

        public enum ApiPath
        {
            Teams_TeamId_CompleteMigration,
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
    }
    public partial class TeamCompletemigrationResponse : RestApiResponse
    {
    }
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/team-completemigration?view=graph-rest-1.0
    /// </summary>
    public partial class MicrosoftClient
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/team-completemigration?view=graph-rest-1.0
        /// </summary>
        public async Task<TeamCompletemigrationResponse> TeamCompletemigrationAsync()
        {
            var p = new TeamCompletemigrationParameter();
            return await this.SendAsync<TeamCompletemigrationParameter, TeamCompletemigrationResponse>(p, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/team-completemigration?view=graph-rest-1.0
        /// </summary>
        public async Task<TeamCompletemigrationResponse> TeamCompletemigrationAsync(CancellationToken cancellationToken)
        {
            var p = new TeamCompletemigrationParameter();
            return await this.SendAsync<TeamCompletemigrationParameter, TeamCompletemigrationResponse>(p, cancellationToken);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/team-completemigration?view=graph-rest-1.0
        /// </summary>
        public async Task<TeamCompletemigrationResponse> TeamCompletemigrationAsync(TeamCompletemigrationParameter parameter)
        {
            return await this.SendAsync<TeamCompletemigrationParameter, TeamCompletemigrationResponse>(parameter, CancellationToken.None);
        }
        /// <summary>
        /// https://learn.microsoft.com/en-us/graph/api/team-completemigration?view=graph-rest-1.0
        /// </summary>
        public async Task<TeamCompletemigrationResponse> TeamCompletemigrationAsync(TeamCompletemigrationParameter parameter, CancellationToken cancellationToken)
        {
            return await this.SendAsync<TeamCompletemigrationParameter, TeamCompletemigrationResponse>(parameter, cancellationToken);
        }
    }
}
