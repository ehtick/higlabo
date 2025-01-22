﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/provisioningstep?view=graph-rest-1.0
/// </summary>
public partial class ProvisioningStep
{
    public enum ProvisioningStepProvisioningStepType
    {
        Import,
        Scoping,
        Matching,
        Processing,
        ReferenceResolution,
        Export,
        UnknownFutureValue,
    }
    public enum ProvisioningStepProvisioningResult
    {
        Success,
        Warning,
        Failure,
        Skipped,
        UnknownFutureValue,
    }

    public string? Description { get; set; }
    public DetailsInfo? Details { get; set; }
    public string? Name { get; set; }
    public ProvisioningStepProvisioningStepType ProvisioningStepType { get; set; }
    public ProvisioningStepProvisioningResult Status { get; set; }
}
