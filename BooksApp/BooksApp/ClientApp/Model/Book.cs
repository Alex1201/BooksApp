using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksApp.ClientApp.Model
{
    public class Book
    {
    public long Id { get; set; }
    public string Title { get; set; }
    public int Year { get; set; }
    public bool IsElectronicFormat { get; set; }
    public Genre Genre { get; set; }
    public string PictureURL { get; set; }
    public double Rating { get; set; }
}
}
