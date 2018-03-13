using DotNet.Highcharts;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Helpers;
using DotNet.Highcharts.Options;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc5_Graficos.Controllers
{
    public class GraficoColunaController : Controller
    {
        //Necessario instalar o pacote no Nuget DotNet.Highchart 
        //Install-Package DotNet.Highcharts -Version 4.0.0
        // GET: GraficoColuna
        public ActionResult GraficoColuna()
        {
            Highcharts columnChart = new Highcharts("columnchart");
            columnChart.InitChart(new Chart()
            {
                Type = DotNet.Highcharts.Enums.ChartTypes.Column,
                BackgroundColor = new BackColorOrGradient(System.Drawing.Color.AliceBlue),
                Style = "fontWeight: 'bold', fontSize: '17px'",
                BorderColor = System.Drawing.Color.LightBlue,
                BorderRadius = 0,
                BorderWidth = 2
            });
            columnChart.SetTitle(new Title()
            {
                //Titulo
                Text = "Santos x São Paulo"
            });
            columnChart.SetSubtitle(new Subtitle()
            {
                //Subtitulo
                Text = "Classificação por pontos no Campeonato Brasileiro"
            });
            columnChart.SetXAxis(new XAxis()
            {
                Type = AxisTypes.Category,
                Title = new XAxisTitle() { Text = "Anos", Style = "fontWeight: 'bold', fontSize: '17px'" },
                Categories = new[] { "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012" }
            });
            columnChart.SetYAxis(new YAxis()
            {
                Title = new YAxisTitle()
                {
                    Text = "Pontos",
                    Style = "fontWeight: 'bold', fontSize: '17px'"
                },
                ShowFirstLabel = true,
                ShowLastLabel = true,
                Min = 0
            });
            columnChart.SetLegend(new Legend
            {
                Enabled = true,
                BorderColor = System.Drawing.Color.CornflowerBlue,
                BorderRadius = 6,
                BackgroundColor = new BackColorOrGradient(ColorTranslator.FromHtml("#FFADD8E6"))
            });
            columnChart.SetSeries(new Series[]
            {
                new Series{
                    Name = "Santos",
                    //pontuação fixa.
                    Data = new Data(new object[] { 89, 59, 64, 62, 45, 49, 53, 53, 57 })
                },
                new Series()
                {
                    Name = "São Paulo",
                    Data = new Data(new object[] { 82, 58, 78, 77, 75, 65, 59, 66, 50 })
                },

                new Series()
                {
                    Name = "Clube Teste",
                    Data = new Data(new object[] { 89, 20, 78, 62, 75, 23, 50, 56, 82 })
                },

                new Series()
                {
                    Name = "Clube Teste 2",
                    Data = new Data(new object[] { 40, 70, 38, 52, 15, 23, 50, 56, 82 })
                },

                new Series()
                {
                    Name = "Clube Teste 3",
                    Data = new Data(new object[] {  })
                }
            }
            );
            return View(columnChart);
        }
    }
}