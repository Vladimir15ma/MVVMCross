using MvvmCross.IoC;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using TipCalcutator.Core.ViewModels;

namespace TipCalcutator.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()   
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<TipViewModel>();
        }
    }
}
