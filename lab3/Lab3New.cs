using System;
using System.Windows.Forms;

namespace lab3
{
    public partial class Lab3New : Form
    {
        public Lab3New()
        {
            InitializeComponent();
        }

        // ============================================
        // BOOK CLASSES
        // ============================================

        public class Book
        {
            public string Title { get; set; } = string.Empty;
            public string Author { get; set; } = string.Empty;
            public decimal Price { get; set; }

            public virtual string GetInfo()
            {
                return $"📖 BOOK: {Title} by {Author} - ${Price:F2}";
            }
        }

        public class Magazine : Book
        {
            public int IssueNumber { get; set; }

            public override string GetInfo()
            {
                return $"📰 MAGAZINE: {Title} - Issue #{IssueNumber} - ${Price:F2}";
            }
        }

        public class Ebook : Book
        {
            public double FileSizeMB { get; set; }
            public string Format { get; set; } = string.Empty;

            public override string GetInfo()
            {
                return $"💻 EBOOK: {Title} by {Author} - {Format}, {FileSizeMB:F1}MB - ${Price:F2}";
            }
        }

        // Student Challenge #1: Textbook Class
        public class Textbook : Book
        {
            public string Subject { get; set; } = string.Empty;
            public int Edition { get; set; }

            public override string GetInfo()
            {
                return $"📚 TEXTBOOK: {Title} - {Subject} (Edition {Edition}) - ${Price:F2}";
            }
        }

        // Student Challenge #2: AudioBook Class
        public class AudioBook : Book
        {
            public double DurationHours { get; set; }
            public string Narrator { get; set; } = string.Empty;

            public override string GetInfo()
            {
                return $"🎧 AUDIOBOOK: {Title} narrated by {Narrator} - {DurationHours:F1} hours - ${Price:F2}";
            }
        }

        // ============================================
        // POLYMORPHIC FUNCTION (Task 2)
        // This function takes an array of Book objects 
        // and processes them polymorphically
        // ============================================

        private void ProcessBooksPolymorphically(Book[] books)
        {
            // Clear the list box first
            displayListBox.Items.Clear();

            // Add header
            displayListBox.Items.Add("╔════════════════════════════════════════════════════════════════╗");
            displayListBox.Items.Add("║                    BOOKSTORE INVENTORY                        ║");
            displayListBox.Items.Add("╚════════════════════════════════════════════════════════════════╝");
            displayListBox.Items.Add("");

            // POLYMORPHISM IN ACTION!
            // The same method call produces different results for different book types
            foreach (Book book in books)
            {
                displayListBox.Items.Add(book.GetInfo());
            }

            // Add footer with totals
            displayListBox.Items.Add("");
            displayListBox.Items.Add("═══════════════════════════════════════════════════════════════════");

            int totalItems = books.Length;
            decimal totalValue = 0;

            foreach (Book book in books)
            {
                totalValue += book.Price;
            }

            displayListBox.Items.Add($"📊 TOTAL ITEMS: {totalItems}");
            displayListBox.Items.Add($"💰 TOTAL VALUE: ${totalValue:F2}");
            displayListBox.Items.Add("═══════════════════════════════════════════════════════════════════");
        }

        // ============================================
        // BUTTON CLICK HANDLERS
        // ============================================

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            // Creating a polymorphic array - all different types stored as Book
            Book[] myBooks = new Book[]
            {
                // Regular Books (Task 1)
                new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Price = 12.99m },
                new Book { Title = "1984", Author = "George Orwell", Price = 14.99m },
                new Book { Title = "Pride and Prejudice", Author = "Jane Austen", Price = 11.99m },
                new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Price = 13.99m },
                
                // Magazines (Task 2)
                new Magazine { Title = "National Geographic", Author = "Nat Geo Society", IssueNumber = 487, Price = 6.99m },
                new Magazine { Title = "TIME Magazine", Author = "TIME USA", IssueNumber = 125, Price = 5.99m },
                new Magazine { Title = "Wired", Author = "Condé Nast", IssueNumber = 342, Price = 7.99m },
                new Magazine { Title = "People", Author = "Dotdash Meredith", IssueNumber = 58, Price = 4.99m },
                
                // Ebooks (Task 2)
                new Ebook { Title = "The Martian", Author = "Andy Weir", FileSizeMB = 5.2, Format = "EPUB", Price = 9.99m },
                new Ebook { Title = "Dune", Author = "Frank Herbert", FileSizeMB = 8.5, Format = "PDF", Price = 11.99m },
                new Ebook { Title = "Project Hail Mary", Author = "Andy Weir", FileSizeMB = 6.8, Format = "MOBI", Price = 12.99m },
                new Ebook { Title = "Ready Player One", Author = "Ernest Cline", FileSizeMB = 4.2, Format = "EPUB", Price = 8.99m },
                
                // Textbooks (Student Challenge #1)
                new Textbook { Title = "Introduction to Algorithms", Author = "Thomas Cormen", Subject = "Computer Science", Edition = 4, Price = 89.99m },
                new Textbook { Title = "Campbell Biology", Author = "Lisa Urry", Subject = "Biology", Edition = 12, Price = 79.99m },
                new Textbook { Title = "Principles of Economics", Author = "N. Gregory Mankiw", Subject = "Economics", Edition = 9, Price = 74.99m },
                new Textbook { Title = "Fundamentals of Physics", Author = "David Halliday", Subject = "Physics", Edition = 11, Price = 84.99m },
                
                // AudioBooks (Student Challenge #2)
                new AudioBook { Title = "Becoming", Author = "Michelle Obama", Narrator = "Michelle Obama", DurationHours = 19.2, Price = 24.99m },
                new AudioBook { Title = "Atomic Habits", Author = "James Clear", Narrator = "James Clear", DurationHours = 5.7, Price = 19.99m },
                new AudioBook { Title = "The Hobbit", Author = "J.R.R. Tolkien", Narrator = "Andy Serkis", DurationHours = 11.5, Price = 29.99m },
                new AudioBook { Title = "Educated", Author = "Tara Westover", Narrator = "Julia Whelan", DurationHours = 12.1, Price = 22.99m }
            };

            // Process the array polymorphically
            ProcessBooksPolymorphically(myBooks);
        }

        private void btnShowStats_Click(object sender, EventArgs e)
        {
            // Create the same array of books
            Book[] myBooks = new Book[]
            {
                new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Price = 12.99m },
                new Book { Title = "1984", Author = "George Orwell", Price = 14.99m },
                new Book { Title = "Pride and Prejudice", Author = "Jane Austen", Price = 11.99m },
                new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Price = 13.99m },
                new Magazine { Title = "National Geographic", Author = "Nat Geo Society", IssueNumber = 487, Price = 6.99m },
                new Magazine { Title = "TIME Magazine", Author = "TIME USA", IssueNumber = 125, Price = 5.99m },
                new Magazine { Title = "Wired", Author = "Condé Nast", IssueNumber = 342, Price = 7.99m },
                new Magazine { Title = "People", Author = "Dotdash Meredith", IssueNumber = 58, Price = 4.99m },
                new Ebook { Title = "The Martian", Author = "Andy Weir", FileSizeMB = 5.2, Format = "EPUB", Price = 9.99m },
                new Ebook { Title = "Dune", Author = "Frank Herbert", FileSizeMB = 8.5, Format = "PDF", Price = 11.99m },
                new Ebook { Title = "Project Hail Mary", Author = "Andy Weir", FileSizeMB = 6.8, Format = "MOBI", Price = 12.99m },
                new Ebook { Title = "Ready Player One", Author = "Ernest Cline", FileSizeMB = 4.2, Format = "EPUB", Price = 8.99m },
                new Textbook { Title = "Introduction to Algorithms", Author = "Thomas Cormen", Subject = "Computer Science", Edition = 4, Price = 89.99m },
                new Textbook { Title = "Campbell Biology", Author = "Lisa Urry", Subject = "Biology", Edition = 12, Price = 79.99m },
                new Textbook { Title = "Principles of Economics", Author = "N. Gregory Mankiw", Subject = "Economics", Edition = 9, Price = 74.99m },
                new Textbook { Title = "Fundamentals of Physics", Author = "David Halliday", Subject = "Physics", Edition = 11, Price = 84.99m },
                new AudioBook { Title = "Becoming", Author = "Michelle Obama", Narrator = "Michelle Obama", DurationHours = 19.2, Price = 24.99m },
                new AudioBook { Title = "Atomic Habits", Author = "James Clear", Narrator = "James Clear", DurationHours = 5.7, Price = 19.99m },
                new AudioBook { Title = "The Hobbit", Author = "J.R.R. Tolkien", Narrator = "Andy Serkis", DurationHours = 11.5, Price = 29.99m },
                new AudioBook { Title = "Educated", Author = "Tara Westover", Narrator = "Julia Whelan", DurationHours = 12.1, Price = 22.99m }
            };

            // First show all books
            ProcessBooksPolymorphically(myBooks);

            // Then add statistics breakdown
            displayListBox.Items.Add("");
            displayListBox.Items.Add("┌─────────────────────────────────────────────────────────────────┐");
            displayListBox.Items.Add("│                      TYPE BREAKDOWN                            │");
            displayListBox.Items.Add("└─────────────────────────────────────────────────────────────────┘");

            int regularCount = 0, magazineCount = 0, ebookCount = 0, textbookCount = 0, audioCount = 0;

            foreach (Book book in myBooks)
            {
                if (book is Textbook) textbookCount++;
                else if (book is AudioBook) audioCount++;
                else if (book is Magazine) magazineCount++;
                else if (book is Ebook) ebookCount++;
                else if (book is Book) regularCount++;
            }

            displayListBox.Items.Add($"  📖 Regular Books:  {regularCount,2} item(s)");
            displayListBox.Items.Add($"  📰 Magazines:      {magazineCount,2} item(s)");
            displayListBox.Items.Add($"  💻 Ebooks:         {ebookCount,2} item(s)");
            displayListBox.Items.Add($"  📚 Textbooks:      {textbookCount,2} item(s)");
            displayListBox.Items.Add($"  🎧 AudioBooks:     {audioCount,2} item(s)");
            displayListBox.Items.Add("─────────────────────────────────────────────────────────────────");

            // Calculate and display averages
            decimal total = 0;
            foreach (Book book in myBooks)
            {
                total += book.Price;
            }

            decimal averagePrice = total / myBooks.Length;

            // Find most expensive book
            Book mostExpensive = myBooks[0];
            foreach (Book book in myBooks)
            {
                if (book.Price > mostExpensive.Price)
                    mostExpensive = book;
            }

            displayListBox.Items.Add($"  💰 TOTAL VALUE:    ${total:F2}");
            displayListBox.Items.Add($"  📊 AVERAGE PRICE:  ${averagePrice:F2}");
            displayListBox.Items.Add($"  👑 MOST EXPENSIVE: {mostExpensive.Title} (${mostExpensive.Price:F2})");
            displayListBox.Items.Add("═══════════════════════════════════════════════════════════════════");
        }

        private void displayListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This event is triggered when you click on an item in the list box
            // Optional: You can add code here to show details when an item is selected
        }
    }
}