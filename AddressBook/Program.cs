// See https://aka.ms/new-console-template for more information
using AddressBook;

Console.WriteLine("Welcome to Address Book Program!");

CreatingContacts contact = new CreatingContacts();
AddressBookRepo repo = new AddressBookRepo();



while (true)
{
    Console.WriteLine("\nEnter the number :\n1)Creating Contacts\n2)Edit Details\n3)Remove Contacts\n4)Adding multiple contacts\n5)Output Details\n6)Adding Unique Contacts\n7)Display unique contacts" +
        "\n8)Search Person by city or State\n9)Count Persons by city or State\n10)Contacts by city using Dictionary\n11)Contacts by State using Dictionary\n12)Sorting Details By FirstName\n13)Sorting " +
        "Details By State\n14)Sorting Details By City\n15)Sorting Details By Zip\n16)Write File Using FileIO\n17)Append File Using FileIO\n18)Read File Using FileIO\n19)Updating Contacts to Json File\n20)" +
        "Reading Contacts from Json File\n21)Write in CSV file\n22)Read from CSV file\n23)Display of PersonDetail1\n24)Display of Address_Book1\n25)Display of PersonTypes1" +
        "\n26)Display of PersonsDetail_Type1\n27)Display of Employee_Department1\n28)Display of AddressBook");

    int option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
            contact.Contact();
            break;
        case 2:
            contact.EditContacts();
            break;
        case 3:
            contact.RemoveContact();
            break;
        case 4:
            Console.WriteLine("Enter the number of contacts you want");
            int n = Convert.ToInt32(Console.ReadLine());
            contact.Addmultiplepersons(n);
            break;
        case 5:
            contact.output();
            break;
        case 6:
            contact.Adduniquecontacts();
            break;
        case 7:
            contact.DisplayUniqueContacts();
            break;
        case 8:
            contact.SearchByCityState();
            break;
        case 9:
            contact.CountByCityState();
            break;
        case 10:
            contact.ContactsBycity_dictionary();
            contact.DisplayContactsByCities_Dictionary();
            break;
        case 11:
            contact.ContactsBystate_dictionary();
            contact.DisplayContactsByState_dictionary();
            break;
        case 12:
            contact.SortingDetailsByName();
            break;
        case 13:
            Console.WriteLine("Sorting details by City");
            contact.SortingDetailsByCity();
            break;
        case 14:
            Console.WriteLine("Sorting details by State");
            contact.SortingDetailsByState();
            break;
        case 15:
            Console.WriteLine("Sorting details by Zip");
            contact.SortingDetailsByZip();
            break;
        case 16:
            contact.WriteInFileIO();
            break;
        case 17:
            contact.AppendInFileIO();
            break;
        case 18:
            contact.ReadFileIO();
            break;
        case 19:
            contact.WriteCsvFile();
            break;
        case 20:
            contact.ReadCsvFile();
            break;
        case 21:
            contact.WriteJson();
            break;
        case 22:
            contact.ReadJsonFile();
            break;
        case 23:
            Console.WriteLine("Display of PersonDetail1");
            repo.GetAllContactOf_PersonDetail1();
            Console.WriteLine("*********************************************************");
            break;
        case 24:
            Console.WriteLine("Display of Address_Book1");
            repo.GetAllContactOf_Address_Book1();
            Console.WriteLine("*********************************************************");
            break;
        case 25:
            Console.WriteLine("Display of PersonTypes1");
            repo.GetAllContactOf_PersonTypes1();
            Console.WriteLine("*********************************************************");
            break;
        case 26:
            Console.WriteLine("Display of PersonsDetail_Type1");
            repo.GetAllContactOf_PersonsDetail_Type1();
            Console.WriteLine("*********************************************************");
            break;
        case 27:
            Console.WriteLine("Display of Employee_Department1");
            repo.GetAllContactOf_Employee_Department1();
            Console.WriteLine("*********************************************************");
            break;
        case 28:
            Console.WriteLine("Display of AddressBook");
            repo.GetAllContactOf_AddressBook();
            Console.WriteLine("*********************************************************");
            break;
    }
}