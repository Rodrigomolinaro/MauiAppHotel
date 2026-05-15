using CommunityToolkit.Mvvm.Input;
using MauiAppHotel.Models;

namespace MauiAppHotel.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}