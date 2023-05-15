using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.AspNetCore.Mvc;
using repos.Models.Blocks;

namespace repos.Controllers
{
    public class SiteBlockController
    {

    }
    public abstract class BlockComponentBase<T> : AsyncBlockComponent<T> where T : BlockData
    {
        protected override async Task<IViewComponentResult> InvokeComponentAsync(T currentContent)
        {
            return await Task.FromResult(DefaultView(currentContent));
        }

        public ViewViewComponentResult DefaultView(T currentContent)
        {
            return View(GetViewPath(currentContent), currentContent);
        }

        public ViewViewComponentResult DefaultView<TModel>(T currentContent, TModel model)
        {
            return View(GetViewPath(currentContent), model);
        }

        protected string GetViewPath(T currentContent)
        {
            var typeName = currentContent?.GetOriginalType().Name;

            return $"~/Views/{typeName}/Index.cshtml";
        }
    }

    public class SiteBlockComponent : BlockComponentBase<SiteBlockData>
    {
    }
}
