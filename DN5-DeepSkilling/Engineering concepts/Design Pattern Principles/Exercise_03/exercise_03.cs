using System;


namespace BuilderPatternExample
{
    
    class Computer
    {
        
        public string CPU      { get; private set; }
        public string RAM      { get; private set; }
        public string Storage  { get; private set; }
        public string GPU      { get; private set; }
        public bool   HasWifi  { get; private set; }

        
        private Computer(Builder builder)
        {
            CPU     = builder.CPU;
            RAM     = builder.RAM;
            Storage = builder.Storage;
            GPU     = builder.GPU;
            HasWifi = builder.HasWifi;
        }

        public void ShowSpecs()
        {
            Console.WriteLine("Computer Specifications:");
            Console.WriteLine("  CPU     : " + CPU);
            Console.WriteLine("  RAM     : " + RAM);
            Console.WriteLine("  Storage : " + Storage);
            Console.WriteLine("  GPU     : " + (GPU ?? "No dedicated GPU"));
            Console.WriteLine("  WiFi    : " + (HasWifi ? "Yes" : "No"));
        }

        
        public class Builder
        {
            
            public string CPU      { get; private set; }
            public string RAM      { get; private set; }
            public string Storage  { get; private set; }
            public string GPU      { get; private set; }
            public bool   HasWifi  { get; private set; }

            
            public Builder(string cpu, string ram, string storage)
            {
                CPU     = cpu;
                RAM     = ram;
                Storage = storage;
            }

            
            public Builder SetGPU(string gpu)
            {
                GPU = gpu;
                return this; 
            }

            
            public Builder SetWifi(bool hasWifi)
            {
                HasWifi = hasWifi;
                return this;
            }

            
            public Computer Build()
            {
                return new Computer(this);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Builder Pattern - Computer Configuration\n");

            
            Console.WriteLine(" Basic Computer ");
            Computer basic = new Computer.Builder("Intel i3", "8GB", "256GB SSD")
                                        .Build();
            basic.ShowSpecs();

            
            Console.WriteLine("\n Gaming Computer ");
            Computer gaming = new Computer.Builder("Intel i9", "32GB", "1TB SSD")
                                         .SetGPU("NVIDIA RTX 4080")
                                         .SetWifi(true)
                                         .Build();
            gaming.ShowSpecs();

            
            Console.WriteLine("\n Office Computer ");
            Computer office = new Computer.Builder("Intel i5", "16GB", "512GB SSD")
                                         .SetWifi(true)
                                         .Build();
            office.ShowSpecs();
        }
    }
}
