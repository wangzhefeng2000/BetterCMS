﻿using BetterCms.Api;
using BetterCms.Core.Mvc.Commands;
using BetterCms.Module.Root.Mvc;

namespace BetterCms.Module.Root.Commands.Tag.DeleteTag
{
    /// <summary>
    /// A command to delete given tag.
    /// </summary>
    public class DeleteTagCommand : CommandBase, ICommand<DeleteTagCommandRequest, bool>
    {
        /// <summary>
        /// Executes this command.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Executed command result.</returns>
        public bool Execute(DeleteTagCommandRequest request)
        {
            var tag = Repository.Delete<Models.Tag>(request.TagId, request.Version);
            UnitOfWork.Commit();

            // Notify.
            RootApiContext.Events.OnTagDeleted(tag);

            return true;
        }
    }
}