// -----------------------------------------------------------------------
// <copyright file="JumpingEventArgs.cs" company="Exiled Team">
// Copyright (c) Exiled Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Exiled.Events.EventArgs
{
    using System;

    using Exiled.API.Features;

    using UnityEngine;

    /// <summary>
    /// Contains all informations before a player jumps.
    /// </summary>
    public class JumpingEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JumpingEventArgs"/> class.
        /// </summary>
        /// <param name="player"><inheritdoc cref="Player"/></param>
        /// <param name="pos"><inheritdoc cref="Position"/></param>
        /// <param name="isAllowed"><inheritdoc cref="IsAllowed"/></param>
        public JumpingEventArgs(Player player, Vector3 pos, bool isAllowed = true)
        {
            Player = player;
            Position = pos;
            IsAllowed = isAllowed;
        }

        /// <summary>
        /// Gets the player who's jumping.
        /// </summary>
        public Player Player { get; }

        /// <summary>
        /// Gets or sets the jump position.
        /// </summary>
        public Vector3 Position { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the client data can be synchronized with the server.
        /// </summary>
        public bool IsAllowed { get; set; }
    }
}
