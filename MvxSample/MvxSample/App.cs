using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using MvxSample.ViewModels;

namespace MvxSample
{
    public class App: MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            // 注册所有的服务类
            CreatableTypes().EndingWith("Service").AsInterfaces().RegisterAsLazySingleton();
            RegisterAppStart<MainViewModel>();
        }
    }
}
