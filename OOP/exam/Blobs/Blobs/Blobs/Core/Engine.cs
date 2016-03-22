using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Blobs.Interfaces;

namespace Blobs.Core
{
    public class Engine : IEngine
    {
        private IBlobFactory blobFactory;
        private IData data;
        private IInputReader reader;
        private IOutputWriter writer;


        public void Run()
        {
            while (true)
            {
                string[] input = this.reader.ReadLine().Split();

                this.ExecuteCommand(input);
            }
        }

        private void ExecuteCommand(string[] input)
        {
            switch (input[0])
            {
                case "create":
                    this.ExecuteCreateCommand(input[1], input[2], input[3], input[4], input[5]);
                    break;
                case "attack":
                    this.ExecuteAttackCommand(input[1], input[2]);
                    break;
                case "pass":
                    break;
                case "drop":
                    Environment.Exit(0);
                    break;
                default:
                    throw new ArgumentException("Unknown command");
            }
        }


        private void ExecuteCreateCommand(string name, string health, string damage, string behaivor, string attack)
        {
            if (behaivor.Contains("Aggressive") && attack.Contains("Blobplode"))
            {
                IBlob blob = this.blobFactory.CreateBlob("AggressiveBlobplodeBlob", name, Convert.ToInt32(health),
                    Convert.ToInt32(damage));
                this.data.AddBlobs(blob);
            }
            if (behaivor.Contains("Aggressive") && attack.Contains("PutridFart"))
            {
                IBlob blob = this.blobFactory.CreateBlob("AggresivePutridFartBlob", name, Convert.ToInt32(health),
                    Convert.ToInt32(damage));
                this.data.AddBlobs(blob);
            }
            if (behaivor.Contains("Inflated") && attack.Contains("PutridFart"))
            {
                IBlob blob = this.blobFactory.CreateBlob("InflatedPutridFartBlob", name, Convert.ToInt32(health),
                    Convert.ToInt32(damage));
                this.data.AddBlobs(blob);
            }
            if (behaivor.Contains("Inflated") && attack.Contains("Blobplode"))
            {
                IBlob blob = this.blobFactory.CreateBlob("InflatedBlobplodeBlob", name, Convert.ToInt32(health),
                    Convert.ToInt32(damage));
                this.data.AddBlobs(blob);
            }
            else
            {
                throw new ArgumentException("Behavior and attack does not exist");
            }
        }

        private void ExecuteAttackCommand(string attackerBloob, string targetBloob)
        {
            throw new NotImplementedException();
        }
    }
}