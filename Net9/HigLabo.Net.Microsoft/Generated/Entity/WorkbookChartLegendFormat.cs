﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/workbookchartlegendformat?view=graph-rest-1.0
/// </summary>
public partial class WorkbookChartLegendFormat
{
    public WorkbookChartFill? Fill { get; set; }
    public WorkbookChartFont? Font { get; set; }
}
