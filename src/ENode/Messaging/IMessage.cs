﻿using System;

namespace ENode.Messaging
{
    /// <summary>Represents a message.
    /// </summary>
    public interface IMessage
    {
        /// <summary>Represents the unique identifier for the message.
        /// </summary>
        Guid Id { get; }
        /// <summary>Get or set whether the message is restore from the message store.
        /// </summary>
        bool IsRestoreFromStorage { get; set; }
    }
}
