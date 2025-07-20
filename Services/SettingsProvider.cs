using Creator.ABA.Extensions;
using Creator.ABA.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text.Json;

namespace Creator.ABA.Services
{
    public class SettingsProvider<T> : ISettingsProvider<T> where T : class, new()
    {
        public T Settings { get; private set; }

        private static readonly JsonSerializerOptions CachedJsonSerializerOptions = new JsonSerializerOptions { WriteIndented = true };
        private static readonly string _defaultSettingsFilePath = Path.Combine(AppContext.BaseDirectory, typeof(T).Name.ToLowerInvariant()+".json");


        public SettingsProvider()
        {
            Settings = new T();
        }

        public void Save(string? settingsFilePath = null)
        {
            string json = JsonSerializer.Serialize(Settings, CachedJsonSerializerOptions);
            File.WriteAllText(settingsFilePath ?? _defaultSettingsFilePath, json);
        }

        public void Load(string? settingsFilePath = null)
        {
            settingsFilePath ??= _defaultSettingsFilePath;

            if (!File.Exists(settingsFilePath))
            {
                throw new FileNotFoundException("Settings file not found.", settingsFilePath);
            }

            string json = File.ReadAllText(settingsFilePath);

            T settings = JsonSerializer.Deserialize<T>(json) ?? throw new InvalidOperationException("Failed to deserialize user settings.");

            // Validate settings
            var validationResults = new List<ValidationResult>();
            var context = new ValidationContext(settings);

            if (!Validator.TryValidateObject(settings, context, validationResults, true))
            {
                throw new AggregateValidationException(validationResults);
            }

            this.Settings = settings;
        }
    }
}
