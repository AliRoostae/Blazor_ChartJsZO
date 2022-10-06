

function SetConfigChart(idChart, config) {

    var con = JSON.parse(config);
    var chartZero = Chart.getChart(idChart);
    if (chartZero !== undefined) {
        chartZero.destroy();
    }
    var duc = document.getElementById(idChart);
    new Chart(duc, con);
    chartZero.reset();
 
}

function SetDataChart(idChart, data) {

    console.log("setData ...")
    var con = JSON.parse(data);
    var chartZero = Chart.getChart(idChart);
    chartZero.data = con;
    console.log(chartZero.data);
        
    chartZero.update();
  

    console.log("setData ...End")
}


function loadScript(url, callback) {

    var script = document.createElement("script")
    script.type = "text/javascript";

    if (script.readyState) {  //IE
        script.onreadystatechange = function () {
            if (script.readyState == "loaded" ||
                script.readyState == "complete") {
                script.onreadystatechange = null;
                callback();
            }
        };
    } else {  //Others
        script.onload = function () {
            callback();
        };
    }

    script.src = url;
    document.getElementsByTagName("head")[0].appendChild(script);
}

loadScript("_content/Blazor_ChartJsZO/ChartJs/chart.js", function () { });


