using SimplePattern;

Console.WriteLine("Factory pattern demo");

VehicleFactory factory = new ConcreteVehicleFactory();

IVehicle ship = factory.GetSuitableVechilce(TransportType.Sea);
ship.Deliver();

IVehicle truck = factory.GetSuitableVechilce(TransportType.Land);
truck.Deliver();

IVehicle airplane = factory.GetSuitableVechilce(TransportType.Air);
airplane.Deliver();