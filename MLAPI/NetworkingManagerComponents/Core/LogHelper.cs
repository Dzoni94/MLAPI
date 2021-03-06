﻿using UnityEngine;

namespace MLAPI.Logging
{
    /// <summary>
    /// Log level
    /// </summary>
    public enum LogLevel
    {
        /// <summary>
        /// Developer logging level, most verbose
        /// </summary>
        Developer,
        /// <summary>
        /// Normal logging level, medium verbose
        /// </summary>
        Normal,
        /// <summary>
        /// Error logging level, very quiet
        /// </summary>
        Error,
        /// <summary>
        /// Nothing logging level, no logging will be done
        /// </summary>
        Nothing
    }

    /// <summary>
    /// Helper class for logging
    /// </summary>
    public static class LogHelper
    {
        /// <summary>
        /// Gets the current log level.
        /// </summary>
        /// <value>The current log level.</value>
        public static LogLevel CurrentLogLevel
        {
            get
            {
                if (NetworkingManager.Singleton == null)
                    return LogLevel.Normal;
                else
                    return NetworkingManager.Singleton.LogLevel;
            }
        }

        /// <summary>
        /// Logs an info log with the proper MLAPI prefix
        /// </summary>
        /// <param name="message">The message to log</param>
        public static void LogInfo(string message) => Debug.Log("[MLAPI] " + message);
        /// <summary>
        /// Logs a warning log with the proper MLAPI prefix
        /// </summary>
        /// <param name="message">The message to log</param>
        public static void LogWarning(string message) => Debug.LogWarning("[MLAPI] " + message);
        /// <summary>
        /// Logs an error log with the proper MLAPI prefix
        /// </summary>
        /// <param name="message">The message to log</param>
        public static void LogError(string message) => Debug.LogError("[MLAPI] " + message);
    }
}
