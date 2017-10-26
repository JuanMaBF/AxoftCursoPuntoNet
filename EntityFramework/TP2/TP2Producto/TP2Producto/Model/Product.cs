namespace TP2Producto.Model
{
    public class Product
    {
        public int ProductID { get; set; } //Key
        public string Name { get; set; } //ML50
        public int ProductNumber { get; set; } //ML25
        public bool MakeFlag { get; set; }
        public bool FinishedGoogsFlag { get; set; }
        public string Color { get; set; } //Null ML15
        public int SafetyStockLevel { get; set; }
        public int ReorderPoint { get; set; } 
        public int StandarCost { get; set; }
        public int ListPrice { get; set; }
        public string Size { get; set; } //ML5
        public string SizeUnitMeasureCode { get; set; } //ML3
        public string WeightUnitMeasureCode { get; set; } //ML3
        public decimal Weight { get; set; } //Decimal (8, 2)
        public int DaysToManufacture { get; set; } 
        public string ProductLine { get; set; } //ML2
    }
}
