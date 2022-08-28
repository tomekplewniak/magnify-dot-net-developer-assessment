namespace ShipperAndCarrierStructure;

public class Shipment
{
    public long Id { get; set; }

    public string PickupAddress { get; set; }

    public string DestinationAddress { get; set; }

    public decimal BudgetAmount { get; set; }

    public string AdditionalInformation { get; set; }

    public long? BookedByCarrierId { get; set; }

    public DateTime? BookedAt { get; set; }
}
