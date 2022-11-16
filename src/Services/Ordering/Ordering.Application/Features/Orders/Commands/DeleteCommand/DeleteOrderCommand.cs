using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ordering.Application.Features.Orders.Commands.DeleteCommand
{
    public class DeleteOrderCommand : IRequest
    {
        public int Id { get; set; }
    }
}
