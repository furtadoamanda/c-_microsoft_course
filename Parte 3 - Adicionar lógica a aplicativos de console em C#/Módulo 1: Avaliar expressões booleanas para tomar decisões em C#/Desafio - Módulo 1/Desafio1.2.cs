string permission = "Admin|Manager";
int level = 55;

Console.WriteLine(((permission.Contains("Admin")) && (level > 55)) ? "Welcome, Super Admin user." : "Welcome, Admin user.");

Console.WriteLine(((permission.Contains("Manager")) && (level >= 20)) ? "Contact an Admin for access." : "You do not have sufficient privileges.");

Console.WriteLine(((!permission.Contains("Admin")) && (!permission.Contains("Manager"))) ? "You do not have sufficient privileges.");

// SOLUÇÃO:

// string permission = "Admin|Manager";
// int level = 53;

// if (permission.Contains("Admin"))
// {
//     if (level > 55)
//     {
//         Console.WriteLine("Welcome, Super Admin user.");
//     }
//     else
//     {
//         Console.WriteLine("Welcome, Admin user.");
//     }
// }
// else if (permission.Contains("Manager"))
// {
//     if (level >= 20)
//     {
//         Console.WriteLine("Contact an Admin for access.");
//     }
//     else
//     {
//         Console.WriteLine("You do not have sufficient privileges.");
//     }
// }
// else
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }