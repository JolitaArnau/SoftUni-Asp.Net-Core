using AutoMapper;

namespace Eventures.Web.AutoMapper
{
    using System.Globalization;
    using Eventures.Models;
    using ViewModels.Account;
    using ViewModels.Events;
    using ViewModels.Orders;



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
            
            this.CreateMap<Order, MyOrderViewModel>()
                .ForMember(o => o.Start,
                    e => e.MapFrom(s => s.Event.Start.ToString("dd-MMM-yy HH:mm:ss", CultureInfo.InvariantCulture)))
                .ForMember(o => o.End,
                    e => e.MapFrom(s => s.Event.End.ToString("dd-MMM-yy HH:mm:ss", CultureInfo.InvariantCulture)))
                .ForMember(o => o.Tickets,
                    e => e.MapFrom(s => s.TicketsCount));


            this.CreateMap<Order, AllOrdersViewModel>()
                .ForMember(o => o.EventName, e => e.MapFrom(x => x.Event.Name))
                .ForMember(o => o.CustomerName, e => e.MapFrom(x => x.Customer.UserName))
                .ForMember(o => o.OrderedOn,
                    e => e.MapFrom(x => x.OrderedOn.ToString("dd-MMM-yy HH:mm:ss", CultureInfo.InvariantCulture)));
        }
    }
}