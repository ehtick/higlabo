﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigLabo.Net.Slack;

public partial class UsersConversationsResponse : RestApiResponse
{
    public Channel[]? Channels { get; set; }
}
