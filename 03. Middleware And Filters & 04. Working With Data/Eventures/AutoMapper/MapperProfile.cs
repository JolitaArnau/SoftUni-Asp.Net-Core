using AutoMapper;

namespace Eventures.Web.AutoMapper
{
    using System.Globalization;
    using Eventures.Models;
    using ViewModels.Account;
    using ViewModels.Events;
    

    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            this.CreateMap<EventuresUser, RegisterViewModel>()
                .ForMember(u => u.Username, r => r.MapFrom(m => m.UserName))
                .ReverseMap();

            this.CreateMap<Event, EventViewModel>()
                .ForMember(evm => evm.Start,
                    e => e.MapFrom(s => s.Start.ToString("dd-MMM-yy hh:mm:ss tt", CultureInfo.InvariantCulture)))
                .ForMember(evm => evm.End,
                    e => e.MapFrom(s => s.End.ToString("dd-MMM-yy hh:mm:ss tt", CultureInfo.InvariantCulture)));
        }
    }
}