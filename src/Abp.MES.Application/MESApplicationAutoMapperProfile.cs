using AutoMapper;
using Abp.MES.Books;
using Abp.MES.Authors;

namespace Abp.MES;

public class MESApplicationAutoMapperProfile : Profile
{
    public MESApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Author, AuthorDto>();
    }
}
