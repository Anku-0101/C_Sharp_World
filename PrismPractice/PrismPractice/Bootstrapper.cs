using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Prism.Unity;

namespace PrismPractice
{
    public class Bootstrapper : UnityBootstrapper 
    {
        public override void Run(bool runWithDefaultConfiguration)
        {
            base.Run(runWithDefaultConfiguration);
        }

        // Create the Shell
        // Show the Shell Window (Shell Contains Modules inside it)


        // All WPF Windows are Dependency Objects. //
        protected override DependencyObject CreateShell()
        {
            // Dependency Injection using Unity Container 
            return Container.TryResolve<Shell>();
        }

        protected override void InitializeShell()
        {
            // Set MainWindow for Prism
            App.Current.MainWindow = (Window)Shell;
            App.Current.MainWindow.Show();
        }

        /// <summary>
        /// Configures various modules to shell
        /// </summary>
        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();

            // Adding ModuleA
            Type sampleModuleType = typeof(SampleModule.RegisterSampleModule);
            ModuleCatalog.AddModule(new Prism.Modularity.ModuleInfo { ModuleName = sampleModuleType.Name, ModuleType = sampleModuleType.AssemblyQualifiedName });
            
            //New Modules can be added in a similar way
        }
    }
}
