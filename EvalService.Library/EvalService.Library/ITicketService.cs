using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EvalService.Library
{
    [ServiceContract]
    
    public interface ITicketService
    {
        [OperationContract]
        IEnumerable<Ticket> GetTickets();

        [OperationContract]
        int AddTicket(Ticket t);

        [OperationContract]
        bool Remove(int id);

    }
}
