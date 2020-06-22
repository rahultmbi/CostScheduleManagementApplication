import { Component } from '@angular/core';
import { ContributorService } from 'src/app/_service/contributor.service';
import { AlertifyService } from 'src/app/_service/alertify.service';
import { Contributor } from './_model/Contributor';

import * as Highcharts from 'highcharts';

@Component({
   selector: 'app-root',
   templateUrl: './app.component.html',
   styleUrls: ['./app.component.css']
})
export class AppComponent {
  public contributors: any[];

   highcharts = Highcharts;

   constructor(private contributorService: ContributorService, private alertify: AlertifyService) {

    this.contributorService.getContributor().subscribe(result => {
      this.contributors = result;
    }, error => console.error(error));
    }



   title = 'Cost Schedule Management Application';
   chartOptions = {   
      chart: {
         type: "pie"
      },
      title: {
        text: 'Browser market shares in January, 2018'
    },
    tooltip: {
        pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
    },accessibility: {
      point: {
          valueSuffix: '%'
      }
  },
  credits: {
    enabled: false
  },
  plotOptions: {
      pie: {
          allowPointSelect: true,
          cursor: 'pointer',
          dataLabels: {
              enabled: true,
              format: '<b>{point.name}</b>: {point.percentage:.1f} %'
          }
      }
  },
      xAxis:{
         categories:["Jan", "Feb", "Mar", "Apr", "May", "Jun",
            "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"]
      },
      yAxis: {          
         title:{
            text:"Temperature °C"
         } 
      },
      
      series: [{
        name: 'Brands',
        colorByPoint: true,
        data: [{
            name: 'Chrome',
            y: 61.41,
            sliced: true,
            selected: true
        }, {
            name: 'Internet Explorer',
            y: 11.84
        }, {
            name: 'Firefox',
            y: 10.85
        }, {
            name: 'Edge',
            y: 4.67
        }, {
            name: 'Safari',
            y: 4.18
        }, {
            name: 'Sogou Explorer',
            y: 1.64
        }, {
            name: 'Opera',
            y: 1.6
        }, {
            name: 'QQ',
            y: 1.2
        }, {
            name: 'Other',
            y: 2.61
        }]
      }]
    }

    
}