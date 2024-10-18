using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using NetCoreForum.Data;
using NetCoreForum.DTOs.ReplyDTOs;
using NetCoreForum.DTOs.TopicDTOs;
using NetCoreForum.Entites;
using NetCoreForum.Repositories.Abstract;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NetCoreForum.Repositories.Concrete
{
    public class ReplyRepository : IReplyRepository
    {
        public readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ReplyRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CreateReplyDTO> CreateReply(CreateReplyDTO createReplyDTO)
        {
            var replyEntity = _mapper.Map<Reply>(createReplyDTO);
            var result = await _context.Replies.AddAsync(replyEntity);

            await _context.SaveChangesAsync();
            var createdReplyDTO = _mapper.Map<CreateReplyDTO>(result.Entity);

            return createdReplyDTO;
        }
    }
}
