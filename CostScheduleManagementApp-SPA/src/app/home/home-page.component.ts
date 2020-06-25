import { Component, OnInit } from '@angular/core';

import * as Highcharts from 'highcharts';
@Component({
    selector: 'app-home-page',
    templateUrl: './home-page.component.html',
    styleUrls: ['./home-page.component.css']
})
export class HomePageComponent implements OnInit {

    public pageTitle: string = 'Cost Schedule Management Application'

    constructor() { }

    ngOnInit() {
    }

    highcharts = Highcharts;

    title = 'Cost Schedule Management Application';
    chartOptions = {
        chart: {
            type: "pie"
        },
        title: {
            text: 'Sales Per Royality Report'
        },
        tooltip: {
            pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
        }, accessibility: {
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
        xAxis: {
            categories: ["Jan", "Feb", "Mar", "Apr", "May", "Jun",
                "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"]
        },
        yAxis: {
            title: {
                text: "dfghjk dhfj"
            }
        },

        series: [{
            name: 'Brands',
            colorByPoint: true,
            data: [{
                name: 'Royalty Free Edition',
                y: 61.41,
                sliced: true,
                selected: true
            }, {
                name: 'Profit Split',
                y: 11.84
            }, {
                name: 'Online Sales Royality',
                y: 10.85
            }, {
                name: 'Gain Share',
                y: 4.67
            }, {
                name: 'Gross Revenue Royalty',
                y: 4.18
            }]
        }]
    }

    chartOptions1 = {
        chart: {
            type: 'column'
        },
        title: {
            text: 'Monthly Schedule Report'
        },
        credits: {
            enabled: false
        },
        xAxis: {
            categories: [
                'Jan','Feb','Mar','Apr','May','Jun',
                'Jul','Aug','Sep','Oct', 'Nov','Dec'
            ],
            crosshair: true
        },
        yAxis: {
            min: 0,
            title: {
                text: 'Schedule(ink)'
            }
        },
        tooltip: {
            headerFormat: '<span style="font-size:10px">{point.key}</span><table>',
            pointFormat: '<tr><td style="color:{series.color};padding:0">{series.name}: </td>' +
                '<td style="padding:0"><b>{point.y}</b></td></tr>',
            footerFormat: '</table>',
            shared: true,
            useHTML: true
        },
        plotOptions: {
            column: {
                borderWidth: 0
            }
        },
        series: [{
            name: 'Batch A',
            data: [49, 71, 106, 129, 144, 176, 135, 148, 216, 194, 956, 544]

        }, {
            name: 'Batch B',
            data: [836, 788, 985, 934, 1060, 845, 1050, 1043, 912, 835, 1066, 923]

        }, {
            name: 'Batch C',
            data: [489, 388, 393, 414, 470, 483, 590, 596, 524, 652, 593, 512]

        }, {
            name: 'Batch D',
            data: [424, 332, 345, 397, 526, 755, 574, 604, 476, 391, 468, 511]

        }, {
            name: 'Batch E',
            data: [489, 388, 393, 414, 470, 483, 590, 596, 524, 652, 593, 512]

        }, {
            name: 'Batch F',
            data: [49, 71, 106, 129, 144, 176, 135, 148, 216, 194, 956, 544]

        }]

    }
}
