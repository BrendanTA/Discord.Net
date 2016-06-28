﻿using System;
using System.Threading.Tasks;
using Discord.API.Rest;
using System.Collections.Generic;

namespace Discord
{
    public interface IMessage : IDeletable, ISnowflakeEntity, IUpdateable
    {
        /// <summary> Gets the time of this message's last edit, if any. </summary>
        DateTimeOffset? EditedTimestamp { get; }
        /// <summary> Returns true if this message was sent as a text-to-speech message. </summary>
        bool IsTTS { get; }
        /// <summary> Returns true if this message was added to its channel's pinned messages. </summary>
        bool IsPinned { get; }
        /// <summary> Returns the original, unprocessed text for this message. </summary>
        string RawText { get; }
        /// <summary> Returns the text for this message after mention processing. </summary>
        string Text { get; }
        /// <summary> Gets the time this message was sent. </summary>
        DateTimeOffset Timestamp { get; }

        /// <summary> Gets the channel this message was sent to. </summary>
        IMessageChannel Channel { get; }
        /// <summary> Gets the author of this message. </summary>
        IUser Author { get; }
        /// <summary> Returns a collection of all attachments included in this message. </summary>
        IReadOnlyCollection<Attachment> Attachments { get; }
        /// <summary> Returns a collection of all embeds included in this message. </summary>
        IReadOnlyCollection<IEmbed> Embeds { get; }
        /// <summary> Returns a collection of channel ids mentioned in this message. </summary>
        IReadOnlyCollection<ulong> MentionedChannelIds { get; }
        /// <summary> Returns a collection of roles mentioned in this message. </summary>
        IReadOnlyCollection<IRole> MentionedRoles { get; }
        /// <summary> Returns a collection of users mentioned in this message. </summary>
        IReadOnlyCollection<IUser> MentionedUsers { get; }

        /// <summary> Modifies this message. </summary>
        Task ModifyAsync(Action<ModifyMessageParams> func);
        /// <summary> Adds this message to its channel's pinned messages. </summary>
        Task PinAsync();
        /// <summary> Removes this message from its channel's pinned messages. </summary>
        Task UnpinAsync();
    }
}