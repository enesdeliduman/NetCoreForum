using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NetCoreForum.Data;
using NetCoreForum.DTOs.EmailTemplateDTOs;
using NetCoreForum.Entites;
using NetCoreForum.Repositories.Abstract;

namespace NetCoreForum.Repositories.Concrete
{
    public class EmailTemplateRepository : IEmailTemplateRepository
    {
        public readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public EmailTemplateRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ResultEmailTemplateDTO> GetEmailTemplatesAsync()
        {
            var data = await _context.EmailTemplates.FirstOrDefaultAsync();
            var value = _mapper.Map<ResultEmailTemplateDTO>(data);
            return value;
        }

        public async Task<GetEmailTemplateByTemplateNameDTO> GetEmailTemplateByTemplateNameAsync(string TemplateName)
        {
            var data = await _context.EmailTemplates.FirstOrDefaultAsync(x => x.TemplateName == TemplateName);
            var value = _mapper.Map<GetEmailTemplateByTemplateNameDTO>(data);
            return value;
        }

    }
}
