namespace BigMani.Core
{
    using System;
    using BigMani.GoodStuff;
    using BigMani.Interfaces;
    using BigMani.IO;
    using BigMani.Wokr;

    public class Engine
    {
        private Controller controller;

        private IUserInterface userInterface;

        private Command magic;

        public Engine(IUserInterface userInterface)
        {
            this.controller = new Controller(this);
            this.userInterface = userInterface;
        }

        public IUserInterface UserInterface
        {
            get { return this.userInterface; }
            set { this.userInterface = value; }
        }

        public Command Magic
        {
            get { return this.magic; }
            set { this.magic = value; }
        }

        public void Run()
        {
            while (true)
            {
                string line = this.userInterface.ReadLine();
                if (string.IsNullOrWhiteSpace(line))
                {
                    break;
                }

                line = line.Trim();
                try
                {
                    this.magic = new Command(line);
                    this.controller.DoMagic();
                }
                catch (InvalidOperationException ex)
                {
                    this.userInterface.WriteLine(ex.Message);
                }
            }
        }

        /// <summary>
        /// Prints a message displaying the status of the system 
        /// (percentage of air conditioners tested).
        /// Тhe otput is a float number rounded
        /// to exactly two decimal places.
        /// </summary>
        public void Status()
        {
            int reports = Database.GetReportsCount();
            double airConditioners = Database.GetAirConditionersCount();

            double percent = reports / airConditioners;
            percent = percent * 100;
            new ConsoleWriter().WriteLine(string.Format("Jobs complete: {0:F2}%", percent));       
        }

        public void ValidateParametersCount(Command command, int count)
        {
            if (command.Parameters.Length != count)
            {
                throw new InvalidOperationException(Utility.InvalidCommand);
            }
        }
    }
}
