﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HigLabo.Converter;

namespace HigLabo.Mime;

public class MailHeaderCollection : MimeHeaderCollection
{
    public static readonly Rfc2822Converter Rfc2822Converter = new Rfc2822Converter();

    private DateTimeOffset? _Date;
    private String? _Subject;
    private String? _MessageID;
    private String? _InReplyTo;
    private String? _References;

    private MailAddress? _From;
    private MailAddress? _Sender;
    private MailAddress? _ReturnPath;

    private MailAddressCollection? _ReplyTo;
    private MailAddressCollection? _To;
    private MailAddressCollection? _Cc;

    public DateTimeOffset Date
    {
        get
        {
            if (_Date == null)
            {
                var date = this["Date"];
                if (String.IsNullOrEmpty(date) == false)
                {
                    _Date = MailHeaderCollection.Rfc2822Converter.TryParse(date);
                }
            }
            if (_Date == null)
            {
                var text = this["Received"];
                foreach (var item in text.Split(';'))
                {
                    _Date = MailHeaderCollection.Rfc2822Converter.TryParse(item);
                    if (_Date.HasValue) { break; }
                }
            }
            //Mail must have Date or Received header value.
            return _Date!.Value;
        }
    }
    public String Subject
    {
        get
        {
            if (_Subject == null)
            {
                _Subject = this["Subject"];
            }
            return _Subject;
        }
    }
    public String MessageID
    {
        get
        {
            if (_MessageID == null)
            {
                _MessageID = this["Message-ID"];
            }
            return _MessageID;
        }
    }
    public String InReplyTo
    {
        get
        {
            if (_InReplyTo == null)
            {
                _InReplyTo = this["In-Reply-To"];
            }
            return _InReplyTo;
        }
    }
    public String References
    {
        get
        {
            if (_References == null)
            {
                _References = this["References"];
            }
            return _References;
        }
    }
    public MailAddress From
    {
        get
        {
            if (_From == null)
            {
                _From = MailAddress.TryCreate(this["From"]);
            }
            //Mail must have From header.
            return _From!;
        }
    }
    public MailAddress Sender
    {
        get
        {
            if (_Sender == null)
            {
                _Sender = MailAddress.TryCreate(this["Sender"]);
            }
            //Mail must have Sender header.
            return _Sender!;
        }
    }
    public MailAddress? ReturnPath
    {
        get
        {
            if (_ReturnPath == null)
            {
                _ReturnPath = MailAddress.TryCreate(this["Return-Path"]);
            }
            return _ReturnPath;
        }
    }
    public MailAddressCollection ReplyTo
    {
        get
        {
            if (_ReplyTo == null)
            {
                _ReplyTo = new MailAddressCollection(this["Reply-To"]);
            }
            return _ReplyTo;
        }
    }
    public MailAddressCollection To
    {
        get
        {
            if (_To == null)
            {
                _To = new MailAddressCollection(this["To"]);
            }
            return _To;
        }
    }
    public MailAddressCollection Cc
    {
        get
        {
            if (_Cc == null)
            {
                _Cc = new MailAddressCollection(this["Cc"]);
            }
            return _Cc;
        }
    }

    public override string ToString()
    {
        return String.Format("{0} {1} {2}", this.Date.ToString(), this.From, this.Subject);
    }
}
