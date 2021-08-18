using MvvmCross.IoC;
using MvvmCross.ViewModels;
using MvxCriminalIntent.Core.ViewModels.Main;

namespace MvxCriminalIntent.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<MainViewModel>();
        }
    }
}
