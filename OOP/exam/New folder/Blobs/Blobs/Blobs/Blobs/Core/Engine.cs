using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Blobs.blobs;
using Blobs.Interfaces;

namespace Blobs.Core
{
    public class Engine : IEngine
    {
        private IBlobFactory blobFactory;
        private IData data;
        private IInputReader reader;
        private IOutputWriter writer;

        public Engine(IBlobFactory blobFactory, IData data, IInputReader reader, IOutputWriter writer)
        {
            this.blobFactory = blobFactory;
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
            }
        }

        private void ExecuteCommand(string[] input)
        {
            switch (input[0])
            {
                case "create":
                    this.ExecuteCreateCommand(input[1], input[2], input[3], input[4], input[5]);
                    Update();
                    break;
                case "attack":
                    this.ExecuteAttackCommand(input[1], input[2]);
                    //Update();
                    break;
                case "pass":
                    Update();
                    break;
                case "status":
                    this.ExecuteStatusCommand(data);
                    Update();
                    break;
                case "drop":
                    Environment.Exit(0);
                    break;
                default:
                    throw new ArgumentException("Unknown command");
            }
        }

        private void ExecuteStatusCommand(IData dt)
        {
            foreach (var item in dt.Blobs)
            {
                if (item.Health == 0)
                {
                    this.writer.Print(string.Format("Blob {0} KILLED", item.Name));
                }
                else if (item.Health > 0)
                {
                    this.writer.Print(string.Format("Blob {0}: {1} HP, {2} Damage", item.Name, item.Health, item.Damage));
                }            
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
            else if (behaivor.Contains("Aggressive") && attack.Contains("PutridFart"))
            {
                IBlob blob = this.blobFactory.CreateBlob("AggresivePutridFartBlob", name, Convert.ToInt32(health),
                    Convert.ToInt32(damage));
                this.data.AddBlobs(blob);
            }
            else if (behaivor.Contains("Inflated") && attack.Contains("PutridFart"))
            {
                IBlob blob = this.blobFactory.CreateBlob("InflatedPutridFartBlob", name, Convert.ToInt32(health),
                    Convert.ToInt32(damage));
                this.data.AddBlobs(blob);
            }
            else if (behaivor.Contains("Inflated") && attack.Contains("Blobplode"))
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
            var attackBlob = data.Blobs.Where(x => x.Name.Contains(attackerBloob));
            var targetBlob = data.Blobs.Where(x => x.Name.Contains(targetBloob));
            IBlob blob1 = attackBlob.First();
            IBlob blob2 = targetBlob.First();            
            int blob1CurrentDamage = blob1.Damage;
            int blob1CurrentHealth = blob1.Health;
            int blob2CurrentHelth = blob2.Health;
            blob1.AttackBH(blob1);
            blob2.Health = blob2.Health - blob1.Damage;
            blob1.Damage = blob1CurrentDamage;
            if (blob1.Health < 0)
            {
                blob1.Health = 0;
            }
            if (blob2.Health < 0)
            {
                blob2.Health = 0;
            }
            if (blob1.Health <= blob1CurrentHealth/2)
            {
                blob1.BH(blob1);
            }
            else if (blob1.isTriged)
            {
                blob1.BH(blob1);
            }
            if (blob2.Health <= blob2CurrentHelth/2)
            {
                blob2.BH(blob2);
            }
            else if (blob2.isTriged)
            {
                blob2.BH(blob2);
            }

            foreach (var item in data.Blobs)
            {
                if (item.Name == blob1.Name)
                {
                    item.Health = blob1.Health;
                    item.Damage = blob1.Damage;
                }
                else if (item.Name == blob2.Name)
                {
                    item.Health = blob2.Health;
                    item.Damage = blob2.Damage;
                }
            }
        }

        private void Update()
        {
            foreach (var item in data.Blobs)
            {
                if (item.isTriged)
                {
                    item.BH(item);
                }
            }
        }
    }
}