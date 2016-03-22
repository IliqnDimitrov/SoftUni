using System;
using System.Linq;
using System.Text;
using Empires.Interfaces;

namespace Empires.Core
{
    public class Engine : IEngine
    {
        private IBuildingFactory buildingFactory;
        private IResourceFactory resourceFactory;
        private IUnitFactory unitFactory;
        private IEmpiresData data;
        private IInputReader reader;
        private IOutputWriter writer;

        public Engine(IBuildingFactory buildingFactory , IResourceFactory resourceFactory, IUnitFactory unitFactory, IEmpiresData data, IInputReader reader, IOutputWriter writer)
        {
            this.buildingFactory = buildingFactory;
            this.resourceFactory = resourceFactory;
            this.unitFactory = unitFactory;
            this.data = data;
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            while (true)
            {
                string[] input = this.reader.ReadLine().Split();

                this.ExecuteCommand(input);
                this.UpdateBuildings();
            }
        }

        private void UpdateBuildings()
        {
            foreach (IBuilding building in this.data.Biuldings)
            {
                building.Update();

                if (building.CanProduceResource)
                {
                    var resource = building.ProduceResource();
                    this.data.Resource[resource.ResourceType] += resource.Quantity;
                }
                if (building.CanProduceUnit)
                {
                    var unit = building.ProdcueUnit();
                    this.data.AddUnit(unit);
                }
            }
        }

        private void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "empire-status":
                    this.ExecuteStatusCommand();
                    break;
                case "armistice":
                    Environment.Exit(0);
                    break;
                case "skip":
                    break;
                case "build":
                    this.ExecuteBuildCommand(inputParams[1]);
                    break;
                default:
                    throw new ArgumentException("Unknown command.");

            }
        }

        private void ExecuteBuildCommand(string buildingType)
        {
            IBuilding building = this.buildingFactory.CreateBuilding(buildingType, this.unitFactory,
                this.resourceFactory);

            this.data.AddBulding(building);
        }

        private void ExecuteStatusCommand()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine("Treasury:");

            foreach (var resource in this.data.Resource)
            {
                output.AppendFormat("--{0}: {1}\n", resource.Key, resource.Value);
            }

            output.AppendLine("Buildings:");

            if (this.data.Biuldings.Any())
            {
                foreach (IBuilding building in this.data.Biuldings)
                {
                    output.AppendLine(building.ToString());
                }
            }

            else
            {
                output.AppendLine("N/A");
            }

            output.AppendLine("Units:");

            if (this.data.Units.Any())
            {
                foreach (var unit in this.data.Units)
                {
                    output.AppendFormat("--{0}: {1}\n",unit.Key,unit.Value);
                }
            }

            else
            {
                output.AppendLine("N/A");
            }
            this.writer.Print(output.ToString().Trim());
        }
    }
}