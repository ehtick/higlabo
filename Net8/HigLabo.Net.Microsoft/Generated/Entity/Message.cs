﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft;

/// <summary>
/// https://learn.microsoft.com/en-us/graph/api/resources/message?view=graph-rest-1.0
/// </summary>
public partial class Message
{
    public enum MessageImportance
    {
        Low,
        Normal,
        High,
    }
    public enum MessageInferenceClassificationType
    {
        Focused,
        Other,
    }

    public Recipient[]? BccRecipients { get; set; }
    public ItemBody? Body { get; set; }
    public string? BodyPreview { get; set; }
    public String[]? Categories { get; set; }
    public Recipient[]? CcRecipients { get; set; }
    public string? ChangeKey { get; set; }
    public string? ConversationId { get; set; }
    public string? ConversationIndex { get; set; }
    public DateTimeOffset? CreatedDateTime { get; set; }
    public FollowupFlag? Flag { get; set; }
    public Recipient? From { get; set; }
    public bool? HasAttachments { get; set; }
    public string? Id { get; set; }
    public MessageImportance? Importance { get; set; }
    public MessageInferenceClassificationType? InferenceClassification { get; set; }
    public InternetMessageHeader[]? InternetMessageHeaders { get; set; }
    public string? InternetMessageId { get; set; }
    public bool? IsDeliveryReceiptRequested { get; set; }
    public bool? IsDraft { get; set; }
    public bool? IsRead { get; set; }
    public bool? IsReadReceiptRequested { get; set; }
    public DateTimeOffset? LastModifiedDateTime { get; set; }
    public string? ParentFolderId { get; set; }
    public DateTimeOffset? ReceivedDateTime { get; set; }
    public Recipient[]? ReplyTo { get; set; }
    public Recipient? Sender { get; set; }
    public DateTimeOffset? SentDateTime { get; set; }
    public string? Subject { get; set; }
    public Recipient[]? ToRecipients { get; set; }
    public ItemBody? UniqueBody { get; set; }
    public string? WebLink { get; set; }
    public Attachment[]? Attachments { get; set; }
    public Extension[]? Extensions { get; set; }
    public MultiValueLegacyExtendedProperty[]? MultiValueExtendedProperties { get; set; }
    public SingleValueLegacyExtendedProperty[]? SingleValueExtendedProperties { get; set; }
}
