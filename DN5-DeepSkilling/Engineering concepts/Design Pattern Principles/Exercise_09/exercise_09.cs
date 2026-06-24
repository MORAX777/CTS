using System;


namespace CommandPatternExample
{
   
    interface ICommand
    {
        void Execute();
    }

   
    class Light
    {
        private string location;

        public Light(string location)
        {
            this.location = location;
        }

        public void TurnOn()
        {
            Console.WriteLine(location + " light is ON");
        }

        public void TurnOff()
        {
            Console.WriteLine(location + " light is OFF");
        }
    }

    

    class LightOnCommand : ICommand
    {
        private Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.TurnOn();
        }
    }

    class LightOffCommand : ICommand
    {
        private Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.TurnOff();
        }
    }

    
    class RemoteControl
    {
        private ICommand command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void PressButton()
        {
            if (command != null)
                command.Execute();
            else
                Console.WriteLine("No command set.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Command Pattern - Home Automation\n");
            Light livingRoomLight = new Light("Living Room");
            Light bedroomLight    = new Light("Bedroom");

           
            ICommand livingRoomOn  = new LightOnCommand(livingRoomLight);
            ICommand livingRoomOff = new LightOffCommand(livingRoomLight);
            ICommand bedroomOn     = new LightOnCommand(bedroomLight);
            ICommand bedroomOff    = new LightOffCommand(bedroomLight);

           
            RemoteControl remote = new RemoteControl();

            Console.WriteLine(" Pressing buttons on remote ");
            remote.SetCommand(livingRoomOn);
            remote.PressButton();

            remote.SetCommand(bedroomOn);
            remote.PressButton();

            remote.SetCommand(livingRoomOff);
            remote.PressButton();

            remote.SetCommand(bedroomOff);
            remote.PressButton();
        }
    }
}
