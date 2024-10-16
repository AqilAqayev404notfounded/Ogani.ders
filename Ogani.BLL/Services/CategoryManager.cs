using AutoMapper;
using Ogani.BLL.Services.Contracts;
using Ogani.BLL.ViewModels.CategoryViewModels;
using Ogani.DAL.DataContext.Entities;
using Ogani.DAL.Repositories.Contracts;

namespace Ogani.BLL.Services
{
    public class CategoryManager : CrudManager<Category, CategoryViewModel, CategoryCreateViewModel, CategoryUpdateViewModel>, ICategoryService
    {
        public CategoryManager(IRepository<Category> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
