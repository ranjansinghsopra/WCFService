using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace EvalService.Library
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class TicketService:ITicketService
    {
        private List<Ticket> _tickets;
 
        public IEnumerable<Ticket> GetTickets()
        {
            return _tickets;
        }

        public int AddTicket(Ticket t)
        {
            if(_tickets == null)
                _tickets = new List<Ticket>();

            if (_tickets.Count == 0)
                t.Id = 1;
            else
                t.Id = _tickets.LastOrDefault().Id + 1;

            _tickets.Add(t);

            return t.Id;
        }

        public bool Remove(int id)
        {
            _tickets.Remove(_tickets.Find(t => t.Id == id));
            return true;
        }




        public Ticket GetTicketById(int id)
        {
            return _tickets.Find(t => t.Id == id);
        }
    }
}
