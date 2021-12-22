using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters.Presenters
{
    class SchedulePresenter
    {
        private readonly IKernel _kernel;
        private readonly ISheduleView _view;
        private readonly ISheduleService _service;

        public SchedulePresenter( IKernel kernel, ISheduleView view, ISheduleService service)
        {
            _kernel = kernel;
            _view = view;
            _view.ImportShedule += ImportShedule;
            _view.AddShedule += AddShedule;
            _view.SetShedule += SetShedule;
            _view.ChooseSchedule += ChooseSchedule;
            _view.ExportShedule += ExportSchedule;
            _service = service;
        }

        private void AddShedule (Shedule sch)
        {

        }
    }
}
