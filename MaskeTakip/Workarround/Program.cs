// See https://aka.ms/new-console-template for more information


using Business.Concreate;
using Entities.Concreate;

PttManager pttManager = new(new PersonManager());
pttManager.GiveMask(new Person
{
    FirstName = "tc vatandaşı",
    LastName = "hasta",
    DateOfBirthYear = 1453,
    NationalityIdentity = 524525444878
});

PttManager pttManager1 = new(new ForeignerManager());

pttManager1.GiveMask(new Person
{
    FirstName = "suriyeli",
    LastName = "hasta",
    DateOfBirthYear = 2000,
    NationalityIdentity = 999921554882
});