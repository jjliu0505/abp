﻿using System.Text;
using Localization.Resources.AbpUi;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.Microsoft.AspNetCore.Razor.TagHelpers;

namespace Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Modal
{
    public class AbpModalFooterTagHelperService : AbpTagHelperService<AbpModalFooterTagHelper>
    {
        private readonly IStringLocalizer<AbpUiResource> _localizer;

        public AbpModalFooterTagHelperService(IStringLocalizer<AbpUiResource> localizer)
        {
            _localizer = localizer;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.AddClass("modal-footer");
            output.Content.SetHtmlContent(CreateContent());
        }

        private string CreateContent()
        {
            var sb = new StringBuilder();

            sb.AppendLine("<button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">" + _localizer["Close"] + "</button>");
            sb.AppendLine("<button type=\"submit\" class=\"btn btn-primary\" data-busy-text=\"" + _localizer["SavingWithThreeDot"] + "\"><i class=\"fa fa-check\"></i> <span>" + _localizer["Save"] + "</span></button>");

            return sb.ToString();
        }
    }
}