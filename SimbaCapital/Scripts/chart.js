$(function () {
    // Create the chart
    $('#dvTop10FuturesTrends').highcharts({
        chart: {
            type: 'column'
        },
        title: {
            text: 'Top 10 Trades - Futures'
        },
        subtitle: {
            text: ''
        },
        xAxis: {
            type: 'category'
        },
        yAxis: {
            title: {
                text: '$ in Thousands'
            }

        },
        legend: {
            enabled: false
        },
        plotOptions: {
            series: {
                borderWidth: 0,
                dataLabels: {
                    enabled: true
                }
            }
        },

        tooltip: {
            headerFormat: '<span style="font-size:11px">{series.name}</span><br>',
            pointFormat: '<span style="color:{point.color}">{point.name}</span>: <b>{point.y}$</b><br/>'
        },

        series: [{
            name: "Total Investment",
            colorByPoint: true,
            data: [{
                name: "DAXU",
                y: 366652.275
                
            }, {
                name: "YM",
                y: 117000
            }, {
                name: "TF ",
                y: 112200
            },
            {
                name: "ES",
                y: 28125
            },
            {
                name: "NQ",
                y: 17500
            },
            ]
        }]
    });

    $('#dvTop10Trends').highcharts({
        chart: {
            type: 'column'
        },
        title: {
            text: 'Top 10 Trades - Options'
        },
        subtitle: {
            text: ''
        },
        xAxis: {
            type: 'category'
        },
        yAxis: {
            title: {
                text: '$ in Thousands'
            }

        },
        legend: {
            enabled: false
        },
        plotOptions: {
            series: {
                borderWidth: 0,
                dataLabels: {
                    enabled: true
                }
            }
        },

        tooltip: {
            headerFormat: '<span style="font-size:11px">{series.name}</span><br>',
            pointFormat: '<span style="color:{point.color}">{point.name}</span>: <b>{point.y}$</b><br/>'
        },

        series: [{
            name: "Total Investment",
            colorByPoint: true,
            data: [{
                name: "NFLX",
                y: 19200
            }, {
                name: "SPY",
                y: 7360
            }
            ]
        }]
    });

    $('#dvTop10Profit').highcharts({
        chart: {
            type: 'column'
        },
        title: {
            text: 'Top 10 Tickers by Profits Futute'
        },
        subtitle: {
            text: ''
        },
        xAxis: {
            type: 'category'
        },
        yAxis: {
            title: {
                text: '$ in Thousands'
            }

        },
        legend: {
            enabled: false
        },
        plotOptions: {
            series: {
                borderWidth: 0,
                dataLabels: {
                    enabled: true
                }
            }
        },

        tooltip: {
            headerFormat: '<span style="font-size:11px">{series.name}</span><br>',
            pointFormat: '<span style="color:{point.color}">{point.name}</span>: <b>{point.y}$</b><br/>'
        },

        series: [{
            name: "Total Profits (in USD)",
            colorByPoint: true,
            data: [{
                name: "DAXU",
                y: 61668.75
            }, {
                name: "YM",
                y: 29700
            }, {
                name: "TF ",
                y: 27750
            },
            {
                name: "ES",
                y: 6312
            },
            {
                name: "NQ",
                y: 5900
            },
            ]
        }]
    });

    $('#dvTop10ProfitOption').highcharts({
        chart: {
            type: 'column'
        },
        title: {
            text: 'Top 10 Tickers by Profits - Options'
        },
        subtitle: {
            text: ''
        },
        xAxis: {
            type: 'category'
        },
        yAxis: {
            title: {
                text: '$ in Thousands'
            }

        },
        legend: {
            enabled: false
        },
        plotOptions: {
            series: {
                borderWidth: 0,
                dataLabels: {
                    enabled: true
                }
            }
        },

        tooltip: {
            headerFormat: '<span style="font-size:11px">{series.name}</span><br>',
            pointFormat: '<span style="color:{point.color}">{point.name}</span>: <b>{point.y}$</b><br/>'
        },

        series: [{
            name: "Total Profits (in USD)",
            colorByPoint: true,
            data: [{
                name: "NFLX",
                y: 9792
            }, {
                name: "SPY",
                y: 7583.94
            }
            ]
        }]
    });
});