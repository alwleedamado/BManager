﻿using BManager.PublicApi.Features.TeamFeature.Queries;

namespace BManager.PublicApi.Features.ProjectFeature.Queries
{
    public class GetProjectQuery
    {
        public Guid Id { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public List<GetTeamQuery> Teams { get; set; } = new List<GetTeamQuery>();
        public DateTimeOffset DueDate { get; set; }
        public decimal Price { get; set; }
    }
}