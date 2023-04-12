//Book info
using Microsoft.VisualBasic;

string bookTitle = "Clean Code: A Handbook of Agile Software Craftsmanship";
string bookAuthor = "Robert C. Martin";
string bookIsbnCode = "978-0132350884";
uint pageNumber = 431;
uint bookWeight = 800;
double bookWidth = 17.78;
double bookThickness = 2.79;
double bookHeigth = 23.37;
string bookRating = "4,7/5";
uint bookReviews = 5413;
bool isBookAvailableOnKindle = true;
bool isCoverFlexible = true;

Console.WriteLine($"-------- IL LIBRO DI OGGI: {bookTitle} di {bookAuthor} ------------");
Console.WriteLine("Informazioni generiche:");
Console.WriteLine($"ISBN: {bookIsbnCode}");
Console.WriteLine($"Peso del Libro: {bookWeight}");
Console.WriteLine($"Numero delle pagine : {pageNumber}");
Console.WriteLine($"Dimensioni del libro: {bookWidth} x {bookThickness} x {bookHeigth} cm");
Console.WriteLine();
Console.WriteLine($"Informazioni Amazon:");
Console.WriteLine($"Numero Recensioni: {bookReviews}");
Console.WriteLine($"Valutazione Media: {bookRating} stelline");
Console.WriteLine($"Kindle Disponibile: {isBookAvailableOnKindle}");
Console.WriteLine($"Copertina flessibile disponibile: {isCoverFlexible}");
Console.WriteLine("----------------------------------------------------------------------------");
