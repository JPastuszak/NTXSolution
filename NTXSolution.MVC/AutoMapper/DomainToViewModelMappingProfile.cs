
using AutoMapper;
using NTXSolution.Domain.Entities;
using NTXSolution.MVC.ViewModels;

namespace NTXSolution.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<EditoraViewModel, Editora>();
            Mapper.CreateMap<LivroViewModel, Livro>();
        }
    }
}