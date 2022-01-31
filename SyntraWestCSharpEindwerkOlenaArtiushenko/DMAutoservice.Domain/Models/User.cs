using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DMAutoservice.Domain.Models
{
    public class User //: Person should inherit but does not migrate: Unable to determine the relationship represented by navigation 'RolePerPerson.User' of type 'User'. 
        //Either manually configure the relationship, or ignore this property using the '[NotMapped]' attribute or by using 'EntityTypeBuilder.Ignore' in 'OnModelCreating'
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        //public int PersonId { get; set; }

        ////nav prop
        //public Person Person { get; set; }
        public List<RolePerPerson> PeoplePerRole { get; set; }

    }
}
