using Microsoft.AspNetCore.Mvc;
using NetCoreForum.Repositories.Abstract;

namespace NetCoreForum.ViewComponents.HomePage
{
    public class _HomePage10TopicComponentPartial : ViewComponent
    {
        private readonly ITopicRepository _topicRepository;

        public _HomePage10TopicComponentPartial(ITopicRepository topicRepository)
        {
            _topicRepository = topicRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await _topicRepository.Last10TopicForHomePage();
            return View(data);
        }
    }
}
