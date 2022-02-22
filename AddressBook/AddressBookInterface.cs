using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    //here interface is used to impement multiple behaviours of class
    interface AddressBookInterface
    {
        /// <summary>
        /// Adds the contact.
        /// </summary>
        public void AddContact();


        /// <summary>
        /// Views the contact.
        /// </summary>
        public void ViewContact();

        /// <summary>
        /// Deletes the contact.
        /// </summary>
        public void DeleteContact();

        /// <summary>
        /// Edits the contact.
        /// </summary>
        public void EditContact();
    }
}
