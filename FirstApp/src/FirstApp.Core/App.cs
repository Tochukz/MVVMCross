using MvvmCross.IoC;
using MvvmCross.ViewModels;
using FirstApp.Core.ViewModels.Home;

namespace FirstApp.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<HomeViewModel>();
        }
    }
}
