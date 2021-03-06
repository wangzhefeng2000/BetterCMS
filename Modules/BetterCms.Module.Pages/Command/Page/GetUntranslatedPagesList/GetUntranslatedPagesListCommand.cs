﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetUntranslatedPagesListCommand.cs" company="Devbridge Group LLC">
// 
// Copyright (C) 2015,2016 Devbridge Group LLC
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with this program.  If not, see http://www.gnu.org/licenses/. 
// </copyright>
// 
// <summary>
// Better CMS is a publishing focused and developer friendly .NET open source CMS.
// 
// Website: https://www.bettercms.com 
// GitHub: https://github.com/devbridge/bettercms
// Email: info@bettercms.com
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using BetterCms.Module.Pages.Services;
using BetterCms.Module.Pages.ViewModels.Filter;
using BetterCms.Module.Pages.ViewModels.SiteSettings;

using BetterCms.Module.Root.Mvc;

using BetterModules.Core.Web.Mvc.Commands;

namespace BetterCms.Module.Pages.Command.Page.GetUntranslatedPagesList
{
    public class GetUntranslatedPagesListCommand : CommandBase, ICommand<PagesFilter, PagesGridViewModel<SiteSettingPageViewModel>>
    {
        private readonly IUntranslatedPageListService pageListServce;

        public GetUntranslatedPagesListCommand(IUntranslatedPageListService pageListServce)
        {
            this.pageListServce = pageListServce;
        }

        public virtual PagesGridViewModel<SiteSettingPageViewModel> Execute(PagesFilter request)
        {
            return pageListServce.GetFilteredUntranslatedPagesList(request);
        }
    }
}