using Microsoft.AspNetCore.Mvc;
using NetCoreForum.DTOs.ReplyDTOs;
using NetCoreForum.Repositories.Abstract;

namespace NetCoreForum.Controllers
{
    public class ReplysController : Controller
    {
        private readonly IReplyRepository _replyRepository;

        public ReplysController(IReplyRepository replyRepository)
        {
            _replyRepository = replyRepository;
        }

        public async Task<JsonResult> CreateReply(CreateReplyDTO createReplyDTO)
        {

            var data = await _replyRepository.CreateReply(createReplyDTO);

            return Json(new
            {

            });
        }
    }
}
