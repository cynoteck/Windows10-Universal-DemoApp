using System;
using DemoAppW10.Entities.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppW10.Common.Interface
{
    public interface INavigationService
    {
        void GoBack();

        void NavigateToPage(Views type);

        void NavigateToPage(Views type, object navigationParameter);
    }
}
