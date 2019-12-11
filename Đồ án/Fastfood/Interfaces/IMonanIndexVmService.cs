using Fastfood.ViewModels;


namespace Fastfood.Interfaces
{
    public interface IMonanIndexVmService
    {
        MonanIndexVm GetMonanListVm(string searchString, string loai, int pageIndex = 1);
       
    }
}