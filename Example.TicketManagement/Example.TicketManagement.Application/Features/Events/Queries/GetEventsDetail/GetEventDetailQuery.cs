using MediatR;

namespace Example.TicketManagement.Application.Features.Events.Queries.GetEventsDetail
{
    public class GetEventDetailQuery : IRequest<EventDetailVm>
    {
        public Guid Id { get; set; }
    }
}
