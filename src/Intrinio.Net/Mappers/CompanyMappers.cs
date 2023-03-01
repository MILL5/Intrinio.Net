using AutoMapper;
using Cph.FinancialDataSanitizer;
using Intrinio.Net.Model;

namespace Intrinio.Net.Mappers
{
    public class CompanyMappers : Profile
    {
        private readonly AbbreviationParser _parser;

        public CompanyMappers()
        {
            ConfigureMappings();
            _parser = new AbbreviationParser();
        }

        public void ConfigureMappings()
        {
            CreateMap<Company, Company>()
                .ForMember(dest => dest.Name,
                    map => map.MapFrom(src => _parser.ExpandAllAbbreviationsFromString(src.Name, true)));
            CreateMap<CompanySummary, CompanySummary>()
                .ForMember(dest => dest.Name,
                    map => map.MapFrom(src => _parser.ExpandAllAbbreviationsFromString(src.Name, true)));
            CreateMap<CompanyNews, CompanyNews>();
        }
    }
}
