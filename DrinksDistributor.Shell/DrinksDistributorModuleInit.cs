using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.ObjectBuilder;

namespace DrinksDistributor.Shell
{
    /// <summary>
    /// CAB Module init for DrinksDistributor app/shell.
    /// </summary>
    public class DrinksDistributorModuleInit : ModuleInit
    {
        /// <summary>
        /// Work item for the module.
        /// </summary>
        private WorkItem _workItem;

        /// <summary>
        /// Main constructor.
        /// </summary>
        /// <param name="workItem">Work item for the module</param>
        [InjectionConstructor]
        public DrinksDistributorModuleInit([ServiceDependency] WorkItem workItem)
        {
            _workItem = workItem;
        }

        /// <summary>
        /// Give the opportunity to add services prior to shell.
        /// </summary>
        public override void AddServices()
        {
            base.AddServices();
        }

        /// <summary>
        /// Give the opportunity to add iniatilizations prior to shell.
        /// </summary>
        public override void Load()
        {
            base.Load();
        }
    }
}
