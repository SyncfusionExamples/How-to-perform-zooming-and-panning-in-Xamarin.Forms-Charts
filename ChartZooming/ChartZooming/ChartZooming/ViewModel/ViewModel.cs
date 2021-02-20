using ChartZooming.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ChartZooming
{
    public class ViewModel
    {
        public ObservableCollection<ExportChartDataModel> ClimateData { get; set; }
        public ViewModel()
        {
            ClimateData = new ObservableCollection<ExportChartDataModel>();
            ClimateData.Add(new ExportChartDataModel() { Month = "Jan", Temperature = 33 });
            ClimateData.Add(new ExportChartDataModel() { Month = "Feb", Temperature = 37 });
            ClimateData.Add(new ExportChartDataModel() { Month = "Mar", Temperature = 39 });
            ClimateData.Add(new ExportChartDataModel() { Month = "Apr", Temperature = 43 });
            ClimateData.Add(new ExportChartDataModel() { Month = "May", Temperature = 45 });
            ClimateData.Add(new ExportChartDataModel() { Month = "Jun", Temperature = 43 });
            ClimateData.Add(new ExportChartDataModel() { Month = "Jul", Temperature = 41 });
            ClimateData.Add(new ExportChartDataModel() { Month = "Aug", Temperature = 40 });
            ClimateData.Add(new ExportChartDataModel() { Month = "Sep", Temperature = 39 });
            ClimateData.Add(new ExportChartDataModel() { Month = "Oct", Temperature = 39 });
            ClimateData.Add(new ExportChartDataModel() { Month = "Nov", Temperature = 34 });
            ClimateData.Add(new ExportChartDataModel() { Month = "Dec", Temperature = 33 });
        }
    }

    public class ExportChartDataModel
    {
        public string Month { get; set; }
        public double Temperature { get; set; }
    }
}
