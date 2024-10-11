using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NetCoreForum.Data;
using NetCoreForum.DTOs.SiteSettingsDTOs;
using NetCoreForum.Entites;
using NetCoreForum.Repositories.Abstract;

namespace NetCoreForum.Repositories.Concrete
{
    public class SiteSettingsRepository : ISiteSettingsRepository
    {
        public readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;


        public SiteSettingsRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ResultSiteSettingsDto> GetSiteSettingsAsync()
        {
            var data = await _context.SiteSettings.FirstOrDefaultAsync();
            var value = _mapper.Map<ResultSiteSettingsDto>(data);

            return value;
        }
    }
}
