using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class PeopleData : IPeopleData
    {
        private readonly ISqlDataAccess _db;

        public PeopleData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<PersonModel>> GetPeople()
        {
            string sql = "select * from dbo.Person";

            return _db.LoadData<PersonModel, dynamic>(sql, new { });
        }

          public Task<List<AddressModel>> GetPeopleAddress()
        {
            string sql = "select * from dbo.Address";

            return _db.LoadData<AddressModel, dynamic>(sql, new { });
        }

        public Task InsertPerson(PersonModel person)
        {
            string sql = @"insert into dbo.Person (FirstName, LastName, EmailAddress)
                           values (@FirstName, @LastName, @EmailAddress);";

            return _db.SaveData(sql, person);
        }

        public Task InsertPersonAddress(AddressModel address)
        {
            string sql = @"insert into dbo.Address (PersonId, StreetAddress, City, County, PostCode)
                           values (@PersonId, @StreetAddress, @City, @County, @PostCode);";

            return _db.SaveData(sql, address);
        }

        public Task DeletePerson(PersonModel person)
        {   
            string sql = @"  delete from dbo.Person WHERE PersonId = @PersonId;";
            int PersonId = person.PersonId;
            //string sql = String.Concat("delete from dbo.Person WHERE PersonId = " ,PersonId);
           
            //return _db.SaveData(sql, new { });
            return _db.DeleteData(sql,new {PersonId });
            
        }

         public Task DeletePersonAddress(AddressModel address)
        {   
            int PersonId = address.PersonId;
            string sql = @"  delete from dbo.Address WHERE PersonId = @PersonId;";            
           
            return _db.DeleteData(sql,new {PersonId });
            
        }
    }
}
