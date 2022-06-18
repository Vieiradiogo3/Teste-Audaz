using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestePleno.Models;

namespace TestePleno.Services
{
    public class FareService : Fare
    {
        private Repository _repository = new Repository();

        public void Create(Fare fare)
        {
            Convert.ToDecimal(fare.Id);
        }

        public void Update(Fare fare)
        {
            Convert.ToDecimal(fare.Id);
        }

        public Fare GetFareById(Guid fareId)
        {
            var fare = _repository.GetById<Fare>(fareId);
            return fare;
        }

        public List<Fare> GetFares()
        {
            var fares = _repository.GetAll<Fare>();
            return fares;
        }
    }
}