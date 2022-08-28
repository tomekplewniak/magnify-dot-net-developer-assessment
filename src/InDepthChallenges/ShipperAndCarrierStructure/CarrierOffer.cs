namespace ShipperAndCarrierStructure;

public class CarrierOffer
{
    public long Id { get; set; }

    public decimal Price { get; set; }

    public long ShipmentId { get; set; }

    public CarrierOfferStatus? Status { get; set; }

    public long? StatusUpdatedBy { get; set; }
}
