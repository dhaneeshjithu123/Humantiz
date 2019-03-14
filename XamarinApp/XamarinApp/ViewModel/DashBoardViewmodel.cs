using OxyPlot;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Text;

namespace Humantiz.ViewModel
{
  public  class DashBoardViewmodel:ViewModel.BaseViewModel
    {


        public DashBoardViewmodel()
        {
            GetModel();
        }
        private PlotModel _plotModel;

        public PlotModel PlotModel
        {
            get { return _plotModel; }
            set
            {
                _plotModel = value;
                OnPropertyChanged();
            }
        }

        public void GetModel()
        {
           // base.OnAppearing(navigationContext);

            PlotModel = new PlotModel
            {
                Title = "Perfomance Review"
            };

            var areaSerie = new AreaSeries
            {
                StrokeThickness = 2.0
            };

            areaSerie.Points.Add(new DataPoint(0, 50));
            areaSerie.Points.Add(new DataPoint(10, 60));
            areaSerie.Points.Add(new DataPoint(20, 78));
            areaSerie.Points2.Add(new DataPoint(20, 50));
            areaSerie.Points2.Add(new DataPoint(25, 70));
            areaSerie.Points2.Add(new DataPoint(35, 60));

            PlotModel.Series.Add(areaSerie);
        }
    }
}
