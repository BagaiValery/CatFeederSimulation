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
            try
            {
                _SimulationServise.feeder.MountOfFood = int.Parse(simulationView.FeederText);
            }
            catch (FormatException)
            {
                _SimulationServise.feeder.MountOfFood = 100;
            }
            try
            {
                _SimulationServise.feeder.FeedingSchedule.portion = int.Parse(simulationView.PortionText);
            }
            catch (FormatException)
            {
                _SimulationServise.feeder.portion = 50;
                simulationView.PortionText = "50";
            }
        }
        public void StopSimulation()
        {
            if (_SimulationServise != null)
                _SimulationServise.StopSim();
        }
        public void FeedNow()
        {
            if (_SimulationServise != null)
                try
                {
                int portion = int.Parse(simulationView.FeedingText);
                _SimulationServise.feeder.Feed(portion);
                }
                catch (FormatException)
                {
                simulationView.FeedingText = "Error";
                }
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
        public void PresentTime()
        {
            if (_SimulationServise != null)
                simulationView.TimeText = _SimulationServise.TimeNow.ToString();
        }
        public void Meow()
        {
            if (_SimulationServise.cat1.Meow) simulationView.MeowText = "Meow!";
        }
        public void BoostUp()
        {
            if (_SimulationServise != null)
                _SimulationServise.TimeBoostUp();
        }
        public void BoostDown()
        {
            if (_SimulationServise != null)
                _SimulationServise.TimeBoostDown();
        }
        public void FoolFeeder()
        {
            if (_SimulationServise != null)
                _SimulationServise.feeder.MakeFull();
        }
    }
}
