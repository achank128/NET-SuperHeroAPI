using AutoMapper;
using SuperAPI.Models;
using SuperHeroAPI.Dto;

namespace SuperHeroAPI.Helper
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<SuperHero, SuperHeroDto>();
		}
	}
}
