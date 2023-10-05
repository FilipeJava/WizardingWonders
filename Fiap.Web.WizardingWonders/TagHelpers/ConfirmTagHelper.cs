using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Fiap.Web.WizardingWonders.TagHelpers;

public class ConfirmTagHelper : TagHelper
{
    public string? Texto { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "button";
        output.Attributes.SetAttribute("class", "btn btn-secondary");
        output.Content.SetContent(string.IsNullOrEmpty(Texto)?"Cadastrar":Texto);
    }
}