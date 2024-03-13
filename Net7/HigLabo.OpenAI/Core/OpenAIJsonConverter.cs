﻿using HigLabo.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigLabo.OpenAI
{
    public class OpenAIJsonConverter : IJsonConverter
    {
        public JsonSerializerSettings SerializeSetting = new JsonSerializerSettings();
        public JsonSerializerSettings DeserializeSetting = new JsonSerializerSettings();

        public OpenAIJsonConverter()
        {
            this.SerializeSetting.ContractResolver = new LowercaseContractResolver();
            this.SerializeSetting.NullValueHandling = NullValueHandling.Ignore;
            this.SerializeSetting.Converters.Add(new EnumToLowerStringConverter());

            this.DeserializeSetting.NullValueHandling = NullValueHandling.Ignore;
            this.DeserializeSetting.Converters.Add(new EnumToLowerStringConverter());
        }
        public string SerializeObject(object obj)
        {
            return JsonConvert.SerializeObject(obj, SerializeSetting);
        }
        public T DeserializeObject<T>(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(json, DeserializeSetting)!;
            }
            catch (Exception ex) 
            {
#if DEBUG
                Debugger.Break();
                Debug.Write(ex.ToString());
#else
                throw;
#endif
            }
            return default(T)!;
        }
    }
}
