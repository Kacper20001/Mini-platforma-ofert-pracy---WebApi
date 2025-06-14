using SzkolenieTechniczne.Company.CrossCutting.Dtos;
using SzkolenieTechniczne.Company.Extensions;
using SzkolenieTechniczne.Company.Storage;

namespace SzkolenieTechniczne.Company.Services
{
    public class JobPositionService
    {
        private readonly CompanyDbContext _context;

        public JobPositionService(CompanyDbContext context)
        {
            _context = context;
        }

        public List<JobPositionDto> GetAll()
        {
            return _context.JobPositions
                .Select(j => j.ToDto())
                .ToList();
        }
    }
}
