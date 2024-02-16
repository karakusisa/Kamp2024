using Business.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate;

public class ForeignerManager : IApplicantService
{
    public void ApplyForMask(Person person)
    {
        throw new NotImplementedException();
    }

    public bool CheckPerson(Person person)
    {
        //size herşey beleş, bize yok
        Console.WriteLine("Yabancılara özel muamele...");
        return true;
    }

    public List<Person> GetAll()
    {
        throw new NotImplementedException();
    }
}
