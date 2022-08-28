namespace ShipperAndCarrierStructure;

public class Carrier
{
    public long Id { get; set; }

    public CarrierOffer CarrierOffer { get; set; }

    public void BookShipment(Shipment shipment) 
    {
        if (shipment.BookedByCarrierId != null
            && shipment.BookedAt != null)
        {
            throw new Exception("A shipment can be booked only once");
        }

        shipment.BookedByCarrierId = Id;
        shipment.BookedAt = DateTime.Now;
    }

    public void CreateOffer(CarrierOffer offer) 
    {
        CarrierOffer = offer;
    }
}
