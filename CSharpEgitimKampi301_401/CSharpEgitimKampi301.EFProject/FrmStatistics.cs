﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics: Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EFProjectTravelDbEntities db = new EFProjectTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();
            lblGuideCount.Text = db.Guide.Count().ToString();
            lblAvgCapacity.Text = db.Location.Average(x => x.Capacity)?.ToString(".00");
            lblAvgLocationPrice.Text = db.Location.Average(x => x.Price)?.ToString(".00")+" ₺";
            
            int lastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault();

            lblCappadociaLocationCapacity.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();
            lblTurkiyeCapacityAvg.Text = db.Location.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();

            var romeGuideId = db.Location.Where(x => x.City == "Roma").Select(y => y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text = db.Guide.Where(x => x.GuideId == romeGuideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();

            var maxCapacity = db.Location.Max(x => x.Capacity);
            lblMaxCapacityLocation.Text = db.Location.Where(x => x.Capacity == maxCapacity).Select(y => y.City).FirstOrDefault().ToString();

            var maxPriceLocation = db.Location.Max(x => x.Price);
            lblMaxPriceLocation.Text = db.Location.Where(x => x.Price == maxPriceLocation).Select(y => y.City).FirstOrDefault().ToString();

            var guideIdByNameAysegulYilmaz = db.Guide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Yılmaz").Select(y=> y.GuideId).FirstOrDefault();
            lblAysegulCinarLocationCount.Text = db.Location.Where(x => x.GuideId == guideIdByNameAysegulYilmaz).Count().ToString();
        }
    }
}
