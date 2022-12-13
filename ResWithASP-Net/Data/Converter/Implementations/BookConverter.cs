using ResWithASP_Net.Data.Converter.Contract;
using ResWithASP_Net.Data.VO;
using ResWithASP_Net.Model;
using System.Collections.Generic;
using System.Linq;

namespace ResWithASP_Net.Data.Converter.Implementations
{
    public class BookConverter : IParser<BookVO, Book>, IParser<Book, BookVO>
    {
        public Book Parse(BookVO origin)
        {
            if (origin == null) return null;
            return new Book
            {
                Id = origin.Id,
                Name = origin.Name,
                Description = origin.Description,
                Author = origin.Author,
                Price = origin.Price
            };
        }

        public BookVO Parse(Book origin)
        {
            if (origin == null) return null;
            return new BookVO
            {
                Id = origin.Id,
                Name = origin.Name,
                Description = origin.Description,
                Author = origin.Author,
                Price = origin.Price
            };
        }

        public List<Book> Parse(List<BookVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<BookVO> Parse(List<Book> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
