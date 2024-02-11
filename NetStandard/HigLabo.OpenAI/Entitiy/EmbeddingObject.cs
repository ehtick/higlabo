﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigLabo.OpenAI
{
    public class EmbeddingObject
    {
        public int Index { get; set; }
        public List<double> Embedding { get; set; } = new List<double>();
    }
}
