using System.ComponentModel.DataAnnotations.Schema;

namespace WebHouseHelper.Data
{
    public class MyServices
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal ServicePrice { get; set; }

        public DateTime DateAdded { get; set; }

        public string AverageUserId { get; set; }

        [ForeignKey("DrivewayId")]
        public Driveway Driveway { get; set; }
        public int DrivewayId { get; set; }


        [ForeignKey("InsulationOfTheFacadeId")]
        public InsulationOfTheFacade InsulationOfTheFacade { get; set; }
        public int InsulationOfTheFacadeId { get; set; }


        [ForeignKey("WindowsInstalationId")]
        public WindowsInstalation WindowsInstalation { get; set; }
        public int WindowsInstalationId { get; set; }


        [ForeignKey("HouseCleaningId")]
        public HouseCleaning HouseCleaning { get; set; }
        public int HouseCleaningId { get; set; }


        [ForeignKey("ElectricityId")]
        public Electricity Electricity { get; set; }
        public int ElectricityId { get; set; }

        [ForeignKey("BuildingId")]
        public Building Building { get; set; }
        public int BuildingId { get; set; }


        [ForeignKey("RoofCoveringId")]
        public RoofCovering RoofCovering { get; set; }
        public int RoofCoveringId { get; set; }


        [ForeignKey("PlumbindId")]
        public Plumbind Plumbind { get; set; }
        public int PlumbindId { get; set; }


        [ForeignKey("LandscapingId")]
        public Landscaping Landscaping { get; set; }
        public int LandscapingId { get; set; }


        [ForeignKey("LayingTilesId")]
        public LayingTiles LayingTiles { get; set; }
        public int LayingTilesId { get; set; }


        [ForeignKey("DesignId")]
        public Design Design { get; set; }
        public int DesignId { get; set; }
    }
}
