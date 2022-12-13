using ResWithASP_Net.Data.VO;
using System.Collections.Generic;

namespace ResWithASP_Net.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);
        BookVO FindById(long id);
        List<BookVO> FindAll();
        BookVO Update(BookVO book);
        void Delete(long id);
    }
}
