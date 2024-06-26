﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using HigLabo.Core;

namespace BlobToEnumApplication
{
    public class BlobContainerSetting
    {
        public string ConnectionString { get; set; } = "";
        public string ContainerName { get; set; } = "";
        public string RootNamespaceName { get; init; } = "";
        public string OutputFileName { get; set; } = "";
        public string Extension { get; set; } = "";
    }
    public class ConfigData
    {
        public static ConfigData Current { get; set; } = new ConfigData();

        public ObservableCollection<BlobContainerSetting> ContainerList { get; init; } = new();

        public ConfigData() { }

        public void Save()
        {
            var path = System.IO.Path.Combine(Environment.CurrentDirectory, "Config.json");
            File.WriteAllText(path, JsonSerializer.Serialize(this, new JsonSerializerOptions() { WriteIndented = true }));
        }
        public static ConfigData Load()
        {
            var path = System.IO.Path.Combine(Environment.CurrentDirectory, "Config.json");
            if (File.Exists(path) == false)
            {
                var data = new ConfigData();
                File.WriteAllText(path, JsonSerializer.Serialize(data));
                return data;
            }
            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<ConfigData>(json)!;
        }
    }
}
