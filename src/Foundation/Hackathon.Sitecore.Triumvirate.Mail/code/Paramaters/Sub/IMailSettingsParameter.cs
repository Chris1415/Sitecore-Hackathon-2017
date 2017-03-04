﻿namespace Hackathon.Sitecore.Triumvirate.Foundation.Mail.Paramaters.Sub
{
    /// <summary>
    /// ISettingsParameter
    /// </summary>
    /// <author>
    /// M. Gluzberg, Mrz-2017
    /// </author>
    public interface IMailSettingsParameter
    {
        string MailServer { get; }

        string SenderMail { get; }

        string Username { get; }

        string Password { get; }

        string Port { get; }

        bool EnableSsl { get; }
    }
}
