﻿using System.Threading;
using System.Threading.Tasks;
using SmtpServer.IO;

namespace SmtpServer.Protocol
{
    public sealed class DbugCommand : SmtpCommand
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="options">The server options.</param>
        internal DbugCommand(ISmtpServerOptions options) : base(options) { }

        /// <summary>
        /// Execute the command.
        /// </summary>
        /// <param name="context">The execution context to operate on.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task which asynchronously performs the execution.</returns>
        internal override Task ExecuteAsync(SmtpSessionContext context, CancellationToken cancellationToken)
        {
            return context.Client.ReplyAsync(SmtpResponse.Ok, cancellationToken);
        }
    }
}