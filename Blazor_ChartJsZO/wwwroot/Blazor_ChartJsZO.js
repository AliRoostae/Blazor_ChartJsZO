
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
function SetAssemblyName(dotNetHelperarg, idChart) {
    
    if (dotNetHelper === undefined) {
        dotNetHelper = [{ id: idChart, asmb: dotNetHelperarg }];
    } else {
       dotNetHelper.push({ id: idChart, asmb: dotNetHelperarg });
    }
    console.log(dotNetHelper);
}
function DisposAssemblyName(idChart) {

    dotNetHelper.forEach(obj => {
        if (obj.id == idChart) {
            dotNetHelper.splice(obj, 1);
        }
    });
    console.log(dotNetHelper);
}


function SetConfigChart(idChart, config) {
    let con = JSON.parse(config);
    let chartZero = Chart.getChart(idChart);
    if (chartZero !== undefined) {
        chartZero.destroy();
    }
    con.options.onClick = HandleClickChartZo;
    let duc = document.getElementById(idChart);
    new Chart(duc, con);
    chartZero.reset();
}

function SetDataChart(idChart, data) {
    let con = JSON.parse(data);
    let chartZero = Chart.getChart(idChart);
    chartZero.data.datasets.push(con);
    chartZero.update();
}

function UpdateDataChart(idChart, data) {
    let con = JSON.parse(data);
    let chartZero = Chart.getChart(idChart);
    chartZero.data = con;
    chartZero.update();
}
function UpdateDetaset(idChart, data,idDataset) {
    let con = JSON.parse(data);
    let chartZero = Chart.getChart(idChart);
    chartZero.data.datasets[idDataset] = con;
    chartZero.update();
}

function AddDataToDetaset(idChart, data,idDataset) {
    let con = JSON.parse(data);
    let chartZero = Chart.getChart(idChart);
    con.forEach((item) => chartZero.data.datasets[idDataset].data.push(item));
    chartZero.update();
    console.log(chartZero.data.datasets[idDataset].data)
}

function UpdateLabelChart(idChart, label) {
    let con = JSON.parse(label);
    let chartZero = Chart.getChart(idChart);
    chartZero.data.labels = con;
    chartZero.update();
 
}

function UpdateTypeChart(idChart, type) {
    
    var chartZero = Chart.getChart(idChart);
    chartZero.config.type = type;
    chartZero.update();
}

function HandleClickChartZo(e, legendItem, legend) {
    let selectClass;
    dotNetHelper.forEach(obj => {
        if (obj.id == legend.canvas.id) {
            selectClass = obj.asmb;
        }
    });
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
    return selectClass.invokeMethodAsync('ClickChartZo', myJSON);
}




