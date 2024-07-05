using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface IPeopleData
    {
        Task<List<PersonModel>> GetPeople();
        Task<List<AddressModel>> GetPeopleAddress();
        Task InsertPerson(PersonModel person);
        Task InsertPersonAddress(AddressModel address);
        Task DeletePerson(PersonModel person);
        Task DeletePersonAddress(AddressModel address);
    }
}