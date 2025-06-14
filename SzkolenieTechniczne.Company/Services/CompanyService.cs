using SzkolenieTechniczne.Company.CrossCutting.Dtos;
using SzkolenieTechniczne.Company.Extensions;
using SzkolenieTechniczne.Company.Storage;


namespace SzkolenieTechniczne.Company.Services
{
    public class CompanyService
    {
        private readonly CompanyDbContext _context;

        public CompanyService(CompanyDbContext context)
        {
            _context = context;
        }

        public List<CompanyDto> GetAll()
        {
            return _context.Companies
                .Select(c => c.ToDto())
                .ToList();
        }
    }
}
