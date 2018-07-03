
    function getAllTables(){
        $.post("Schema/GetTables", {
            "connectStr": $("#connectString")[0].value,
            "DbType": $("input[name='DBType']:checked")[0].value
            },
            function (data, status) {
                setTable(JSON.parse(data), document.getElementById("tableDetails"));
                return data;
    });    
}

function btnConnect_click() {
    var stringData = getAllTables();
    //var jsonData = JSON.parse(getAllTables);
    
    
}

function setTable(jsonData, divContainer) {

    var col = [];
    for (var i = 0; i < jsonData.length; i++) {
        for (var key in jsonData[i]) {
            if (col.indexOf(key) === -1) {
                col.push(key);
            }
        }
    }

    // CREATE DYNAMIC TABLE.
    var table = document.createElement("table");
    table.classList.add("table");
    table.classList.add("table-striped");
    // CREATE HTML TABLE HEADER ROW USING THE EXTRACTED HEADERS ABOVE.

    var tr = table.insertRow(-1);                   // TABLE ROW.

    for (var i = 0; i < col.length; i++) {
        var th = document.createElement("th");      // TABLE HEADER.
        th.innerHTML = col[i];
        tr.appendChild(th);
    }

    // ADD JSON DATA TO THE TABLE AS ROWS.
    for (var i = 0; i < jsonData.length; i++) {

        tr = table.insertRow(-1);

        for (var j = 0; j < col.length; j++) {
            var tabCell = tr.insertCell(-1);
            tabCell.innerHTML = jsonData[i][col[j]];
        }
    }

    // FINALLY ADD THE NEWLY CREATED TABLE WITH JSON DATA TO A CONTAINER.
    divContainer.innerHTML = "";
    divContainer.appendChild(table);
}