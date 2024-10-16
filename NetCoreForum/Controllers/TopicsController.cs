using Microsoft.AspNetCore.Mvc;
using NetCoreForum.Repositories.Abstract;

namespace NetCoreForum.Controllers
{
    public class TopicsController : Controller
    {
        private readonly ITopicRepository _topicRepository;

        public TopicsController(ITopicRepository topicRepository)
        {
            _topicRepository = topicRepository;
        }

        public async Task<IActionResult> TopicDetails(int id)
        {
            var data = await _topicRepository.GetTopicByTopicID(id);
            return View(data);
        }
    }
}
