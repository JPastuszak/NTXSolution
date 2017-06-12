
using AutoMapper;
using NTXSolution.Domain.Entities;
using NTXSolution.MVC.ViewModels;

namespace NTXSolution.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Editora, EditoraViewModel>();
            Mapper.CreateMap<Livro, LivroViewModel>();
        }
    }
}