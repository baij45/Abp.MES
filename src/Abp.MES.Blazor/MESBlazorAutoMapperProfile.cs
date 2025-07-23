using AutoMapper;
using Abp.MES.Books;
using Abp.MES.Authors;

namespace Abp.MES.Blazor;

public class MESBlazorAutoMapperProfile : Profile
{
    public MESBlazorAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();

        //Define your AutoMapper configuration here for the Blazor project.
        CreateMap<AuthorDto, UpdateAuthorDto>();
    }
}
