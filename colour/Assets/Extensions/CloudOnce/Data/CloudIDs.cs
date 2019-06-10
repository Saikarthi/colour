// <copyright file="CloudIDs.cs" company="Jan Ivar Z. Carlsen, Sindri Jóelsson">
// Copyright (c) 2016 Jan Ivar Z. Carlsen, Sindri Jóelsson. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace CloudOnce
{
#if (UNITY_ANDROID || UNITY_IOS || UNITY_TVOS) && !UNITY_EDITOR
    using Internal;
    using UnityEngine;
#endif
    /// <summary>
    /// Provides access to achievement- and leaderboard IDs registered via the CloudOnce Editor.
    /// This file was automatically generated by CloudOnce. Do not edit.
    /// </summary>
    public static class CloudIDs
    {
        /// <summary>
        /// Contains properties that retrieves achievement IDs for the current platform.
        /// </summary>
        public static class AchievementIDs
        {
        }

        /// <summary>
        /// Contains properties that retrieves leaderboard IDs for the current platform.
        /// </summary>
        public static class LeaderboardIDs
        {
            public static string highscore
            {
                get
                {
#if UNITY_ANDROID && !UNITY_EDITOR
#if CLOUDONCE_GOOGLE
                    return "CgkI__jrurwYEAIQBg";
#else
                    return string.Empty;
#endif
#elif (UNITY_IOS || UNITY_TVOS) && !UNITY_EDITOR
                    return "";
#elif UNITY_EDITOR
                    return "highscore";
#else
                    return string.Empty;
#endif
                }
            }
        }
    }
}
