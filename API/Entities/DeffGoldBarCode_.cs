namespace API.Entities
{
    public class DeffGoldBarCode_
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string BarCodeTypeAr { get; set; }
        public string BarCodeTypeEn { get; set; }
        public string BarCodeName { get; set; }
        public float BarCodeX { get; set; }
        public float BarCodeY { get; set; }
        public int IsVisible { get; set; }
    }
}
