using System;
using Microsoft.Extensions.Logging;

namespace FractalDataWorks.Configuration;

/// <summary>
/// High-performance logging methods for ConfigurationProvider using source generators.
/// </summary>
internal static partial class ConfigurationProviderLog
{
    [LoggerMessage(
        EventId = 1,
        Level = LogLevel.Information,
        Message = "Saved configuration {ConfigurationType} with ID {Id}")]
    public static partial void SavedConfiguration(ILogger logger, string configurationType, int id);

    [LoggerMessage(
        EventId = 2,
        Level = LogLevel.Information,
        Message = "Deleted configuration {ConfigurationType} with ID {Id}")]
    public static partial void DeletedConfiguration(ILogger logger, string configurationType, int id);

    [LoggerMessage(
        EventId = 3,
        Level = LogLevel.Information,
        Message = "Reloaded configuration cache for {ConfigurationType}")]
    public static partial void ReloadedConfiguration(ILogger logger, string configurationType);

    [LoggerMessage(
        EventId = 4,
        Level = LogLevel.Debug,
        Message = "Configuration cache updated due to {ChangeType} event")]
    public static partial void CacheUpdated(ILogger logger, ConfigurationChangeType changeType);
}