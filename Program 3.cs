Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon.");
}
if (daysUntilExpiration <= 5)
{
    discountPercentage = 10;
    Console.WriteLine($"You have {daysUntilExpiration} days left. You are eligible for a {discountPercentage}% discount!");
}
else if (daysUntilExpiration <= 3)
{
    discountPercentage = 20;
    Console.WriteLine($"Hurry up! Only {daysUntilExpiration} days left. You can get a {discountPercentage}% discount!");
}
else if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else
{
    Console.WriteLine($"You have {daysUntilExpiration} days left on your subscription.");
}