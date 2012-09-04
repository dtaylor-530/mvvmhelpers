using System.Composition;
using JulMar.Core.Interfaces;
using JulMar.Core.Services;

namespace JulMar.Windows.Mvvm
{
    /// <summary>
    /// ViewModel locator resource lookup.  Place this into the application
    /// resources and it will retrieve the singleton VM locator using MEF.
    /// </summary>
    public sealed class ViewModelLocatorResource
    {
        /// <summary>
        /// ViewModel dictionary - can be used as indexer operator in Binding expressions.
        /// </summary>
        [Import]
        public IViewModelLocator ViewModels { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public ViewModelLocatorResource()
        {
            DynamicComposer.Instance.Compose(this);
        }
    }
}