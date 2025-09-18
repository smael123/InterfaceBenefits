# Start
Interfaces can be added to classes so that they can work with other classes more easily.

Switch to the main branch to see our use case. Our boss asked us to determine wether an object in an array of objects is duplicated.

In this case a vendor is duplicated if there are two vendors with the same tax id. We create a VendorDuplicateFinder class with a method to check for duplicates.

*Open Program.cs and see Vendor array and VenderDuplicateFinder.ShowDuplicateItems() method call*

If we pass in this array of vendors to the VendorDuplicateFinder class we would get a message saying that:

`Id 123456789 is duplicated. Duplicated Data: Bender's Stolen Car Parts | Bender's Orphanage`

The finder class looks at the array, checks to see if multiple objects have the same id, and if it does  output the id and the differing data.

*Open VendorDouplicateFinder.cs*

# First Hurdle

*switch to solution-pt1*

Now we are asked to find duplicates in 3 other types of classes. We could make a new Finder class for each object, but that is repetitive and invokes a high maintenance cost.

For each class we need to find duplicates for we only need to identify the unique id property and what different data to display.

We can create an interface IDuplicateableItem with two getter methods.

*Open IDuplicatableItem.cs*

Then we can create a DuplicateFinder class that takes in an array of IDuplicateableItem objects instead of Vendor objects.

*Open VendorDuplicateFinder.cs and DuplicateFinder.cs*

Then we can make both the Vendor and Customer class implement this interface.

*Open Vendor.cs and Customer.cs*