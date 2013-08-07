﻿using System;
using System.Linq;

using BetterCms.Core.Exceptions.DataTier;
using BetterCms.Core.Mvc.Commands;

using BetterCms.Module.Pages.ViewModels.Templates;
using BetterCms.Module.Root.Models;
using BetterCms.Module.Root.Mvc;
using BetterCms.Module.Root.ViewModels.Option;

using NHibernate.Transform;

namespace BetterCms.Module.Pages.Command.Layout.GetTemplateForEdit
{
    public class GetTemplateForEditCommand : CommandBase, ICommand<Guid?, TemplateEditViewModel>
    {
        public TemplateEditViewModel Execute(Guid? templateId)
        {
            TemplateEditViewModel templateModel;

            if (templateId == null)
            {
                templateModel = new TemplateEditViewModel();
            }
            else
            {
                Root.Models.Layout templateAlias = null;
                TemplateEditViewModel templateViewModelAlias = null;

                var templateFuture = UnitOfWork.Session.QueryOver(() => templateAlias)
                     .Where(() => templateAlias.Id == templateId && !templateAlias.IsDeleted)
                     .SelectList(select => select
                            .Select(() => templateAlias.Id).WithAlias(() => templateViewModelAlias.Id)
                            .Select(() => templateAlias.Version).WithAlias(() => templateViewModelAlias.Version)
                            .Select(() => templateAlias.Name).WithAlias(() => templateViewModelAlias.Name)
                            .Select(() => templateAlias.PreviewUrl).WithAlias(() => templateViewModelAlias.PreviewImageUrl)
                            .Select(() => templateAlias.LayoutPath).WithAlias(() => templateViewModelAlias.Url))

                    .TransformUsing(Transformers.AliasToBean<TemplateEditViewModel>())
                    .FutureValue<TemplateEditViewModel>();

                TemplateRegionItemViewModel templateRegionAlias = null;
                LayoutRegion layoutRegionAlias = null;
                Region regionAlias = null;

                var regions = UnitOfWork.Session
                    .QueryOver(() => layoutRegionAlias)
                    .Inner.JoinAlias(c => c.Region, () => regionAlias)
                    .Where(() => layoutRegionAlias.Layout.Id == templateId && !regionAlias.IsDeleted && !layoutRegionAlias.IsDeleted)
                    .SelectList(select => select
                        .Select(() => regionAlias.Id).WithAlias(() => templateRegionAlias.Id)
                        .Select(() => layoutRegionAlias.Description).WithAlias(() => templateRegionAlias.Description)
                        .Select(() => regionAlias.Version).WithAlias(() => templateRegionAlias.Version)
                        .Select(() => regionAlias.RegionIdentifier).WithAlias(() => templateRegionAlias.Identifier))
                    .TransformUsing(Transformers.AliasToBean<TemplateRegionItemViewModel>())
                    .Future<TemplateRegionItemViewModel>();

                LayoutOption layoutOptionAlias = null;
                OptionViewModel optionViewModelAlias = null;

                var options = UnitOfWork.Session
                      .QueryOver(() => layoutOptionAlias)
                      .Where(() => layoutOptionAlias.Layout.Id == templateId && !layoutOptionAlias.IsDeleted)
                      .SelectList(select => select
                          .Select(() => layoutOptionAlias.Type).WithAlias(() => optionViewModelAlias.Type)
                          .Select(() => layoutOptionAlias.DefaultValue).WithAlias(() => optionViewModelAlias.OptionDefaultValue)
                          .Select(() => layoutOptionAlias.Key).WithAlias(() => optionViewModelAlias.OptionKey))
                      .TransformUsing(Transformers.AliasToBean<OptionViewModel>())
                      .Future<OptionViewModel>();

                templateModel = templateFuture.Value;
                if (templateModel == null)
                {
                    throw new EntityNotFoundException(typeof(TemplateRegionItemViewModel), templateId.Value);
                }

                templateModel.Regions = regions.ToList();
                templateModel.Options = options.OrderBy(o => o.OptionKey).ToList();
            }

            return templateModel;
        }
    }
}