using Microsoft.AspNetCore.Mvc;
using NetCoreForum.Constants.ClaimTypes;
using NetCoreForum.DTOs.ReplyDTOs;
using NetCoreForum.Entites;
using NetCoreForum.Repositories.Abstract;
using System.Security.Claims;

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
            var UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var UserName = User.FindFirstValue(ClaimTypes.Name);
            var Biography = User.FindFirstValue(ClaimTypes.UserData);
            var Photo = User.FindFirstValue("UserPhoto");
            var Signature = User.FindFirstValue("UserSignature");

            return Json(new
            {
                UserID,
                UserName,
                Photo,
                Signature,
                Biography
            });
        }
    }
}
