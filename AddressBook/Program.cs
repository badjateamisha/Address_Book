// See https://aka.ms/new-console-template for more information
using AddressBook;

Console.WriteLine("Welcome to Address Book Program!");

CreatingContacts contact = new CreatingContacts();



while (true)
{
    Console.WriteLine("Enter the number :\n1)Creating Contacts\n2)Edit Details\n3)Output Details");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            contact.Contacts();
            break;
        case 2:
            contact.edit();
            break;
        case 3:
            contact.output();
            break;
    }
}