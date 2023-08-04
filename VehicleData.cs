public class VehicleData
{
    public string Channel { get; set; }     
    public string Label { get; set; }
    public string PolicyNumber { get; set; }
    public string PolicyType { get; set; }    
    public string InsuranceProduct { get; set; }
    public string TermsAndConditions { get; set; }
    public string ProductName { get; set; }
    public string totalPremiumIncludingTaxes { get; set; }
    public string PolicyStartDate { get; set; }
    public string PolicyEndDate { get; set; }
    public string PromoCode { get; set; }
    public List<CoverageData> Coverages { get; set; }             
}