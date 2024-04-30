// Creating objects of ElectronicProduct and ClothingProduct classes
using tapsiriqoyp;

ElectronicProduct electronicProduct1 = new ElectronicProduct("Laptop", 1000);
ElectronicProduct electronicProduct2 = new ElectronicProduct("Smartphone", 500);

ClothingProduct clothingProduct1 = new ClothingProduct("Shirt", 30);
ClothingProduct clothingProduct2 = new ClothingProduct("Jeans", 50);

// Calling overridden methods to demonstrate inheritance and interface implementations
Console.WriteLine("Electronic Product 1:");
electronicProduct1.printDetails();
Console.WriteLine($"Discount: {electronicProduct1.calculateDiscount()}");
electronicProduct1.leaveReview("Great laptop!");
electronicProduct1.leaveReview("Fast delivery");
Console.WriteLine("Reviews:");
electronicProduct1.viewReviews();

Console.WriteLine("\nElectronic Product 2:");
electronicProduct2.printDetails();
Console.WriteLine($"Discount: {electronicProduct2.calculateDiscount()}");
electronicProduct2.leaveReview("Nice smartphone");
Console.WriteLine("Reviews:");
electronicProduct2.viewReviews();

Console.WriteLine("\nClothing Product 1:");
clothingProduct1.printDetails();
Console.WriteLine($"Discount: {clothingProduct1.calculateDiscount()}");
clothingProduct1.shipProduct("New York");
clothingProduct1.initiateReturn("size does not fit");
clothingProduct1.cancelReturn();

Console.WriteLine("\nClothing Product 2:");
clothingProduct2.printDetails();
Console.WriteLine($"Discount: {clothingProduct2.calculateDiscount()}");
clothingProduct2.shipProduct("Los Angeles");