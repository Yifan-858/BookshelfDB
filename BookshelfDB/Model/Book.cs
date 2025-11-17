using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookshelfDB.Model
{
    public class Book
    {
        private string _id;
        public string Id 
        { 
            get => _id;
            set 
            {
                if(value.Length != 13)
                {
                    throw new ArgumentException("ISBN must be 13 digits");
                }
            } 
        }
        public string Title { get; set; }
        public Language Language { get; set; }
        public double Price { get; set; }
        public DateTime PublicationDate { get; set; }

        [ForeignKey("Author")]
        public int AuthorID { get; set; }
        public Author Author { get; set; }
    }

    public enum Language
    {
        English,Swedish,French,Italian
    }
}
