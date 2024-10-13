using AutoMapper;
using NetCoreForum.Data;
using NetCoreForum.DTOs.PendingUserDTOs;
using NetCoreForum.Entites;
using NetCoreForum.Repositories.Abstract;

namespace NetCoreForum.Repositories.Concrete
{
    public class PendingUserRepository : IPendingUserRepository
    {
        public readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public PendingUserRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task CreatePendingUserAsync(CreatePendingUserDTO createPendingUserDTO)
        {
            var value = _mapper.Map<PendingUser>(createPendingUserDTO);
            _context.PendingUsers.Add(value);
            await _context.SaveChangesAsync();
        }
    }
}
