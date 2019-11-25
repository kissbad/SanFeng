function JSONToExcelConvertor(JSONData, title, filter) {
    if (!JSONData)
        return;
    //转化json为object
    var arrData = typeof JSONData != 'object' ? JSON.parse(JSONData) : JSONData;

    var excel = "<table>";

    //设置表头  
    var row = "<tr>";

    if (title) {
        //使用标题项
        for (var i in title) {
            row += "<th align='center'>" + title[i] + '</th>';
        }

    }
    else {
        //不使用标题项
        for (var i in arrData[0]) {
            row += "<th align='center'>" + i + '</th>';
        }
    }

    excel += row + "</tr>";

    //设置数据  
    for (var i = 0; i < arrData.length; i++) {
        var row = "<tr>";

        for (var index in arrData[i]) {
            //判断是否有过滤行
            if (filter) {
                if (filter.indexOf(index) == -1) {
                    var value = arrData[i][index] == null ? "" : arrData[i][index];
                    row += '<td>' + value + '</td>';
                }
            }
            else {
                var value = arrData[i][index] == null ? "" : arrData[i][index];
                row += "<td align='center'>" + value + "</td>";
            }
        }

        excel += row + "</tr>";
    }

    excel += "</table>";

    var excelFile = "<head>";
    excelFile += "<!--[if gte mso 9]>";
    //excelFile += "<xml>";
    //excelFile += "<x:ExcelWorkbook>";
    //excelFile += "<x:ExcelWorksheets>";
    //excelFile += "<x:ExcelWorksheet>";
    //excelFile += "<x:Name>";
    //excelFile += "{worksheet}";
    //excelFile += "</x:Name>";
    //excelFile += "<x:WorksheetOptions>";
    //excelFile += "<x:DisplayGridlines/>";
    //excelFile += "</x:WorksheetOptions>";
    //excelFile += "</x:ExcelWorksheet>";
    //excelFile += "</x:ExcelWorksheets>";
    //excelFile += "</x:ExcelWorkbook>";
    //excelFile += "</xml>";
    excelFile += "<![endif]-->";
    excelFile += "</head>";
    excelFile += "<body>";
    excelFile += excel;
    excelFile += "</body>";
    excelFile += "</html>";

    return excelFile;
}
