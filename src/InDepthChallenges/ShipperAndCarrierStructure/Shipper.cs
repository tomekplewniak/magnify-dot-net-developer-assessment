namespace ShipperAndCarrierStructure;

public class Shipper
{
    public long Id { get; set; }

    public Shipment Shipment { get; set; }

    public void CreateShipments(Shipment shipment)
    {
        Shipment = shipment;
    }
}
