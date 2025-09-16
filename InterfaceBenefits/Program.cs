// See https://aka.ms/new-console-template for more information

using InterfaceBenefits.Models;
using InterfaceBenefits.Utils;

Vendor[] vendors = [
    new Vendor { TaxId = "123456789", BusinessName = "Bender's Stolen Car Parts", IsCompliance = true },
    new Vendor { TaxId = "453451234", BusinessName = "Fry's School of Hard Rock", IsCompliance = false },
    new Vendor { TaxId = "123456789", BusinessName = "Bender's Orphanage", IsCompliance = false },
];

DuplicateFinder.ShowDuplicateItems(vendors, "Vendors");

Customer[] customers = [
    new Customer { SocialSecurityNumber = "111223333", FirstName = "Jacob", LastName = "Daniels", IsHomeless = true },
    new Customer { SocialSecurityNumber = "432423423", FirstName = "Anakin", LastName = "Skywalker", IsHomeless = false },
    new Customer { SocialSecurityNumber = "111223333", FirstName = "Padme", LastName = "Amidala", IsHomeless = false }
];

DuplicateFinder.ShowDuplicateItems(customers, "Customers");

RadioStation[] radioStations = [
    new RadioStation { Frequency = 100.2f, Name = "Sunny", State = "Texas" },
    new RadioStation { Frequency = 100.2f, Name = "Joe's Talk Show", State = "Louisiana" },
    new RadioStation { Frequency = 89.0f, Name = "Country Bears 24/7", State = "Texas" },
    new RadioStation { Frequency = 100.2f, Name = "Beyonce 24/7", State = "Texas" },
];

DuplicateFinder.ShowDuplicateItems(radioStations, "Radio Stations");

FacebookAccount[] facebookAccounts = [
    new FacebookAccount { EmailAddress = "someone@example.com", DisplayName = "Jack Daniels" },
    new FacebookAccount { EmailAddress = "somebody2@example.com", DisplayName = "Jane Smith" },
    new FacebookAccount { EmailAddress = "someone@example.com", DisplayName = "John Moore" },
];

List<IDuplicatableItem> duplicatableFacebookAccounts = [];

foreach (FacebookAccount facebookAccount in facebookAccounts)
{
    duplicatableFacebookAccounts.Add(new FacebookAccountDuplicatableAdapter(facebookAccount));
}

DuplicateFinder.ShowDuplicateItems(duplicatableFacebookAccounts, "Facebook Accounts");