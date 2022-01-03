using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entity;
using Models.Service;
using Presenter.View;

namespace Presenter.Presenters
{
    public class SimulationPresenter
    {
        private SimulationServise _SimulationServise;
        private ISimulation simulationView;

        public SimulationPresenter(ISimulation view)
        {
            simulationView = view;
        }

        public void StartSimulation()
        {
            _SimulationServise = new SimulationServise();
            _SimulationServise.StartSim();
        }
        public void StopSimulation()
        {
            _SimulationServise.StopSim();
        }
        public void PresentFeeder()
        {
            if (_SimulationServise != null)
                simulationView.FeederText = _SimulationServise.feeder.MountOfFood.ToString();
        }
        public void PresentBowl()
        {
            if (_SimulationServise != null)
                simulationView.BowlText = _SimulationServise.feeder.FoodInBowl.ToString();
        }
        public void Meow()
        {
            if (_SimulationServise.cat1.Meow) simulationView.MeowText = "Meow!";
        }
        public void BoostUp()
        {
            _SimulationServise.TimeBoostUp();
        }
        public void BoostDown()
        {
            _SimulationServise.TimeBoostDown();
        }
        public void FoolFeeder()
        {
            _SimulationServise.feeder.MakeFull();
        }
    }
}
