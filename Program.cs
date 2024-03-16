namespace Lab7_Hashset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> automobilesOwned = new HashSet<string>();
            automobilesOwned.Add("Cadillac Coupe Deville");
            automobilesOwned.Add("Chevrolet Camaro");
            automobilesOwned.Add("Pontiac Grand Prix");
            automobilesOwned.Add("GMC Terrain");
            automobilesOwned.Add("Ford Expedition");

            HashSet<string> trucks = new HashSet<string>();
            trucks.Add("Cadillac Escalade");
            trucks.Add("Ford Expedition");
            trucks.Add("Yukon Denali");
            trucks.Add("Ford F150");
            trucks.Add("Dodge Ram");

            HashSet<string> carsSelected = new HashSet<string>();
            carsSelected.Add("Ford Expedition");
            carsSelected.Add("Cadillac Coupe Deville");
            carsSelected.Add("Dodge Charger");
            carsSelected.Add("Pontiac Grand Prix");
            carsSelected.Add("Volvo");

            Console.WriteLine("Combined list of automobiles owned and trucks");
            automobilesOwned.UnionWith(trucks);
            foreach(string automobile in automobilesOwned)
            {
                Console.WriteLine(automobile);
            }
            Console.WriteLine();

            Console.WriteLine("Languages that are in both lists");
            HashSet<string> bothLists = new HashSet<string>();
            bothLists = automobilesOwned;
            bothLists.IntersectWith(carsSelected);
            foreach( string automobile in bothLists)
            {
                Console.WriteLine(automobile);
            }




        }
    }
}
