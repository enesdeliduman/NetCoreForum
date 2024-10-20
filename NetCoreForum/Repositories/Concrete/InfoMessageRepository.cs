using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NetCoreForum.Data;
using NetCoreForum.DTOs.InfoMessagesDTOs;
using NetCoreForum.Repositories.Abstract;

namespace NetCoreForum.Repositories.Concrete
{
    public class InfoMessageRepository : IInfoMessageRepository
    {
        public readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public InfoMessageRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetInfoMessageByInfoMessageNameDTO> GetInfoMessageByInfoMessageNameAsync(string InfoMessageName)
        {
            var data = await _context.InfoMessages.FirstOrDefaultAsync(x => x.InfoMessageName == InfoMessageName);
            var value = _mapper.Map<GetInfoMessageByInfoMessageNameDTO>(data);
            return value;
        }

        public async Task<string> GetInfoMessageByInfoMessageNameToStringAsync(string InfoMessageName)
        {
            var data = await _context.InfoMessages
                .Where(x => x.InfoMessageName == InfoMessageName)
                .Select(x => x.InfoMessageDescription)
                .FirstOrDefaultAsync();
            return data;
        }

        public async Task<ResultInfoMessageDTO> GetInfoMessagesAsync()
        {
            var data = await _context.InfoMessages.FirstOrDefaultAsync();
            var value = _mapper.Map<ResultInfoMessageDTO>(data);
            return value;
        }
    }
}
