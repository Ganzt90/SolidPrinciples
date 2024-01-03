

namespace SolidVendingMachine
    {
    internal class Program
    {
        private static void Main(string[] args)
        {
            
            var file = new FileData(args[0]);
            var menuLoader = LoadFile.LoadFileFromSource(file);
            ///
            /// Dependency Injection
            /// High level modules should not depend on low level modules. Both should depend on abstractions.
            /// Depend on interfaces.
            /// 
            //var menuLoader = new CsvMenuLoader();
            //var menuLoader = new JsonMenuLoader();
            var vendingMachine = new HighEfficiencyVendingMachine(menuLoader);
            vendingMachine.Start();
        }
    }
}
