google.charts.load("current", { packages: ["corechart"] });
google.charts.setOnLoadCallback(drawChart);

function drawChart() {
  $.getJSON(
    `https://www.rubu.be/iot/co2/co2.php?numberOfDataPoints=${NUM_DATA_POINTS}`,
    data => {
      let _data = [["time", "co2"]];
      $.each(data.data, (index, value) => {
        let time = value.time.split(",")[1].split(":");

        _data.push([`${time[0]}:${time[1]}`, parseInt(value.co2)]);
      });

      _data = new google.visualization.arrayToDataTable(_data);

      let chart = new google.visualization.LineChart(
        document.getElementById("chart")
      );

      let options = {
        chart: {
          title: "CO2",
          curveType: "function",
          legend: { position: "bottom" }
        }
      };

      chart.draw(_data, options);
    }
  );
}

// var data = google.visualization.arrayToDataTable([
//     ["Year", "Sales", "Expenses"],
//     ["2004", 1000, 400],
//     ["2005", 1170, 460],
//     ["2006", 660, 1120],
//     ["2007", 1030, 540]
//   ]);

//   var options = {
//     title: "Company Performance",
//     curveType: "function",
//     legend: { position: "bottom" }
//   };

//   var chart = new google.visualization.LineChart(
//     document.getElementById("chart")
//   );

//   chart.draw(data, options);
