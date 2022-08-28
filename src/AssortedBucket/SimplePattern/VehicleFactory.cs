namespace SimplePattern
{
    public abstract class VehicleFactory
    {
        public abstract IVehicle GetSuitableVechilce(TransportType transportType);
    }
}
