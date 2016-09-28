﻿// -------------------------------------------------------------------------------------------------------------------
// <copyright company="Gemotial" file="HLDateTime.cs" project="Gmtl.HandyLib" date="2015-10-16 18:23">
// 
// </copyright>
// -------------------------------------------------------------------------------------------------------------------

using System;

namespace Gmtl.HandyLib
{
    /// <summary>
    /// Handy methods related to System.DateTime
    /// </summary>
    public static class HLDateTime
    {
        /// <summary>
        /// Return Linux timestamp for provided date
        /// </summary>
        /// <remarks>
        /// <code>
        /// int linuxTimestamp = HLDateTime.NowUnixTimestamp;
        /// </code>
        /// </remarks>
        public static int NowUnixTimestamp
        {
            get
            {
                System.DateTime origin = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
                TimeSpan diff = System.DateTime.Now - origin;

                return (int)Math.Floor(diff.TotalSeconds);
            }
        }
    }
}