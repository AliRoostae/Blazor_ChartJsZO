
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

//////////////////////Import////////////////






var dotNetHelper;
function SetAssemblyName(dotNetHelperarg) {
    dotNetHelper = dotNetHelperarg;
}


function SetConfigChart(idChart, config) {
    var con = JSON.parse(config);
    var chartZero = Chart.getChart(idChart);
    if (chartZero !== undefined) {
        chartZero.destroy();
    }
    con.options.onClick = HandleClickChartZo;
    var duc = document.getElementById(idChart);
    new Chart(duc, con);
    chartZero.reset();
}

function SetDataChart(idChart, data) {
    var con = JSON.parse(data);
    var chartZero = Chart.getChart(idChart);
    chartZero.data = con;
    chartZero.update();
}
function HandleClickChartZo(e, legendItem, legend) {
    if (legendItem === undefined || legendItem == null) return;
    var p = legendItem[0];
    if (p === undefined || p == null) return;
    var outResult = {
        "LabelsData": legend.data.labels[p.index],
        "ValueDataset": legend.data.datasets[p.datasetIndex].data[p.index],
        "IndexDataset": p.datasetIndex,
        "ValueDatasetsIndex": p.index,
        "labelDataset": legend.data.datasets[p.datasetIndex].label
    };
    var myJSON = JSON.stringify(outResult);
    return dotNetHelper.invokeMethodAsync('ClickChartZo', myJSON);
}




