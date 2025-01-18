﻿using System;
using System.Collections.Generic;
using Orrery.HeartModule.Shared.Logging;
using VRage;
using VRage.ModAPI;
using VRageMath;

namespace Orrery.HeartModule.Shared.HeartApi
{
    /// <summary>
    /// Contains every HeartApi method.
    /// </summary>
    internal partial class HeartApiMethods
    {
        public const int ApiVersion = 1;

        public MyTuple<int, Dictionary<string, Delegate>, Dictionary<string, Delegate>, Dictionary<string, Delegate>>
            CommunicationTuple =>
            new MyTuple<int, Dictionary<string, Delegate>, Dictionary<string, Delegate>, Dictionary<string, Delegate>>(
                ApiVersion, ModApiMethods, ServerModApiMethods, ClientModApiMethods);

        /// <summary>
        /// API methods shared between client and server.
        /// </summary>
        internal readonly Dictionary<string, Delegate> ModApiMethods = new Dictionary<string, Delegate>
        {
            #region Logging
            ["LogDebug"] = new Action<string>(HeartLog.Debug),
            ["LogInfo"] = new Action<string>(HeartLog.Info),
            ["LogException"] = new Action<Exception, Type>(HeartLog.Exception),
            #endregion

            #region Projectiles
            ["ProjectileInfo"] = new Func<uint, MyTuple<string, Vector3D, Vector3D, IMyEntity>?>(ProjectileInfo)
            #endregion
        };

        /// <summary>
        /// API methods only available for the server.
        /// </summary>
        internal readonly Dictionary<string, Delegate> ServerModApiMethods = new Dictionary<string, Delegate>
        {
            #region Projectiles
            ["ProjectileSpawn"] = new Func<string, Vector3D, Vector3D, IMyEntity, uint>(ProjectileSpawn),
            #endregion
        };

        /// <summary>
        /// API methods only available for the client.
        /// </summary>
        internal readonly Dictionary<string, Delegate> ClientModApiMethods = new Dictionary<string, Delegate>
        {
            #region Projectiles

            #endregion
        };
    }
}
