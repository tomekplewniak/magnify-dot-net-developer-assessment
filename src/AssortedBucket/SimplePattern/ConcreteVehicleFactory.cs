namespace SimplePattern
{
    public class ConcreteVehicleFactory : VehicleFactory
    {
        public override IVehicle GetSuitableVechilce(TransportType transportType)
        {
            switch (transportType)
            {
                case TransportType.Land:
                    return new Truck();
                case TransportType.Sea:
                    return new Ship();
                case TransportType.Air:
                    return new Airplane();
                default:
                    throw new ApplicationException(string.Format("We aren't handling this type of transport now", transportType.ToString()));
            }
        }
    }
}
