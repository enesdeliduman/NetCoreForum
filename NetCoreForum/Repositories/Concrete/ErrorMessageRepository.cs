using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NetCoreForum.Data;
using NetCoreForum.DTOs.ErrorMessagesDTOs;
using NetCoreForum.Repositories.Abstract;

namespace NetCoreForum.Repositories.Concrete
{
    public class ErrorMessageRepository : IErrorMessageRepository
    {
        public readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ErrorMessageRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetErrorMessageByErrorMessageNameDTO> GetErrorMessageByErrorMessageNameAsync(string ErrorMessageName)
        {
            var data = await _context.ErrorMessages.FirstOrDefaultAsync(x => x.ErrorMessageName == ErrorMessageName);
            var value = _mapper.Map<GetErrorMessageByErrorMessageNameDTO>(data);
            return value;
        }

        public async Task<string> GetErrorMessageByErrorMessageNameToStringAsync(string ErrorMessageName)
        {
            var data = await _context.ErrorMessages
                .Where(x => x.ErrorMessageName == ErrorMessageName)
                .Select(x => x.ErrorMessageDescription)
                .FirstOrDefaultAsync();
            return data;
        }

        public async Task<ResultErrorMessageDTO> GetErrorMessagesAsync()
        {
            var data = await _context.ErrorMessages.FirstOrDefaultAsync();
            var value = _mapper.Map<ResultErrorMessageDTO>(data);
            return value;
        }
    }
}
