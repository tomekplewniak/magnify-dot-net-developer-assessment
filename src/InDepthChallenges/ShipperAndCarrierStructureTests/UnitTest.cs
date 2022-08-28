using ShipperAndCarrierStructure;

namespace ShipperAndCarrierStructureTests
{
    public class UnitTest
    {
        [Fact]
        public void Carrier_Should_BeAbleToBookShipment()
        {
            var shipper = new Shipper()
            {
                Id = 1,
                Shipment = new Shipment()
                {
                    Id = 1,
                    PickupAddress = "Cracow",
                    DestinationAddress = "Berlin",
                    AdditionalInformation = "Test"
                }
            };

            var carrier = new Carrier()
            {
                Id = 100,
            };

            carrier.BookShipment(shipper.Shipment);

            Assert.NotNull(shipper.Shipment.BookedByCarrierId);
            Assert.Equal(carrier.Id, shipper.Shipment.BookedByCarrierId);
            Assert.NotNull(shipper.Shipment.BookedAt);
        }

        [Fact]
        public void Carrier_Should_ThrowException_ShipmentCannotBeBookedMoreThanOnce()
        {
            var shipper = new Shipper()
            {
                Id = 1,
                Shipment = new Shipment()
                {
                    Id = 1,
                    PickupAddress = "Cracow",
                    DestinationAddress = "Berlin",
                    AdditionalInformation = "Test"
                }
            };

            var carrier = new Carrier()
            {
                Id = 100,
            };

            carrier.BookShipment(shipper.Shipment);


            Assert.Throws<Exception>(() => carrier.BookShipment(shipper.Shipment));
        }
    }
}