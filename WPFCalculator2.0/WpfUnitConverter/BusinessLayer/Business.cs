using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfUnitConverter.Business
{
    public class Business
    {

            public Business()
        {
            InstantiateAndShowView();
        }

        public void InstantiateAndShowView()
        {
            PresentationLayer.ViewModel viewModel = new PresentationLayer.ViewModel();
            PresentationLayer.View view = new PresentationLayer.View(viewModel);
            view.DataContext = viewModel;
            view.Show();
        }
    }
}
