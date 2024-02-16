using Business.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{

    public class PttManager : ISupplierService
    {
        private IApplicantService _ApplicantService;
        public PttManager(IApplicantService applicantService)
        {
            _ApplicantService = applicantService;
        }

        public void GiveMask(Person person)
        {
            if (_ApplicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " maske aldı.");
            }
            else
            {
                Console.WriteLine(person.FirstName + " kimlik doğrulama başarısız, sana maske yok.");
            }


        }
    }
}