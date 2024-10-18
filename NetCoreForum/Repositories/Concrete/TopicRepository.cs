using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NetCoreForum.Data;
using NetCoreForum.DTOs.ErrorMessagesDTOs;
using NetCoreForum.DTOs.TopicDTOs;
using NetCoreForum.Repositories.Abstract;

namespace NetCoreForum.Repositories.Concrete
{
    public class TopicRepository : ITopicRepository
    {
        public readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public TopicRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetTopicDTO> GetTopicByTopicID(int id)
        {
            var data = await _context.Topics
               .Include(x => x.Category)
               .Include(x => x.AppUser)
               .Include(x => x.Replies)
               .ThenInclude(x => x.AppUser)
               .FirstOrDefaultAsync(x => x.TopicID == id);
            var value = _mapper.Map<GetTopicDTO>(data);
            return value;
        }

        public async Task<List<Last10TopicForHomePageDTO>> Last10TopicForHomePage()
        {
            var data = await _context.Topics
                  .Include(x => x.AppUser)
                  .Include(x => x.Category)
                  .Take(10)
                  .ToListAsync();

            var value = _mapper.Map<List<Last10TopicForHomePageDTO>>(data);
            return value;
        }
    }
}
