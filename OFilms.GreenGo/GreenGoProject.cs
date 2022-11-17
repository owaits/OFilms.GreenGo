﻿using OFilms.GreenGo.Project.JsonConverters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

namespace OFilms.GreenGo.Project
{
    public class GreenGoProject
    {
        public GreenGoProject()
        {
        }

        public GreenGoProject(string name, string? description = null)
        {
            Settings.Name = name;
            Settings.Description = description ?? string.Empty;
            Settings.CreatedAtTimestamp = DateTime.UtcNow;
        }

        public Settings Settings { get; set; } = new Settings();

        [JsonConverter(typeof(JsonKeyedListConverter<User>))]
        public List<User> Users { get; set; } = new List<User>();

        [JsonConverter(typeof(JsonKeyedListConverter<Group>))]
        public List<Group> Groups { get; set; } = new List<Group>();

        [JsonConverter(typeof(JsonKeyedListConverter<Room>))]
        public List<Room> Rooms { get; set; } = new List<Room>();

        [JsonExtensionData]
        public Dictionary<string, JsonElement>? ExtensionData { get; set; }

        #region Helpers

        public int GetNextGroupId()
        {
            return Groups.Any() ? Groups.Max(item => item.Id) + 1 : 0;
        }

        public int GetNextUserId()
        {
            return Users.Any() ? Users.Max(item => item.Id) + 1 : 0;
        }

        #endregion

        #region Load and Save

        public static GreenGoProject Load(string filename)
        {           
            using (FileStream stream = File.OpenRead(filename))
            {
                var project = JsonSerializer.Deserialize<GreenGoProject>(stream)!;
                return project;
            }
        }

        public void Save(string filename)
        {
            Settings.SavedAtTimestamp = DateTime.UtcNow;

            using (FileStream stream = File.Create(filename))
            {
                JsonSerializer.Serialize<GreenGoProject>(stream, this, new JsonSerializerOptions { WriteIndented = true  });
            }
        }

        #endregion

    }
}
