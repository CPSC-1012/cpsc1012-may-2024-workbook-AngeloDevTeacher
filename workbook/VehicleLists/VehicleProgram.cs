using VehicleLists;

List<Vehicle> vehicles = new List<Vehicle>();

vehicles.Add(new Vehicle("Angelo's car", "broken"));
vehicles.Add(new Vehicle("Sully's paws", "he walks"));
vehicles.Add(new Vehicle("Piper's stroller", "made for touching grass"));


vehicles.Insert(1, new Vehicle("Mike's backpack", "clear dome"));

vehicles.RemoveAt(2);

for (int i = 0; i < vehicles.Count; i++)
{
    vehicles[i].Travel(15.0);
}

Console.WriteLine();