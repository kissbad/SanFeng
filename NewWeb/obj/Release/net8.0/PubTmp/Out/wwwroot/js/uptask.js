function uptask(uptaskzd, uptaskxd) {
    //COMEFROM, COMPANYID, CREDATE, COMPANYNAME, TASKID, CHECKMANNAME
    //ADD_PRINT_TEXT(Y,X,W,H,strContent)增加纯文本项
    let convert_uptaskzd = uptaskzd;
    let convert_uptaskxd = uptaskxd;

    LODOP.SET_PRINT_STYLEA(0, "TextNeatRow", true);
    LODOP.ADD_PRINT_TEXT(0, 0, 272, 20, "上架单");
    LODOP.SET_PRINT_STYLEA(0, "FontSize", 11);
    LODOP.SET_PRINT_STYLEA(0, "Alignment", 2);
    LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
    LODOP.ADD_PRINT_TEXT(0, 10, 40, 20, convert_uptaskzd.comefrom);
    LODOP.SET_PRINT_STYLEA(0, "FontSize", 10);
    LODOP.ADD_PRINT_TEXT(0, 190, 80, 20, convert_uptaskzd.zx_columna);
    LODOP.SET_PRINT_STYLEA(0, "FontSize", 10);
    LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
    LODOP.ADD_PRINT_TEXT(20, 10, 65, 20, "供应商ID:");
    LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
    LODOP.ADD_PRINT_TEXT(20, 75, 61, 20, convert_uptaskzd.companyid);//波次号ID
    LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
    LODOP.ADD_PRINT_TEXT(20, 136, 40, 20, "日期:");
    LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
    LODOP.ADD_PRINT_TEXT(20, 176, 96, 20, convert_uptaskzd.credate);
    LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
    LODOP.ADD_PRINT_TEXT(40, 10, 262, 20, convert_uptaskzd.companyname);
    LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
    LODOP.ADD_PRINT_TEXT(40, 147, 115, 20, convert_uptaskzd.ecodeflag);
    LODOP.SET_PRINT_STYLEA(0, "FontSize", 40);
    LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
    LODOP.ADD_PRINT_TEXT(60, 10, 90, 20, "上架单任务ID:");
    LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
    LODOP.ADD_PRINT_TEXT(60, 100, 172, 20, convert_uptaskzd.taskid);
    LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
    LODOP.ADD_PRINT_TEXT(80, 10, 65, 20, "验收员:");
    LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
    LODOP.ADD_PRINT_TEXT(80, 75, 197, 20, convert_uptaskzd.checkmanname);
    LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
    var iCurLine = 80;//标题行之后的数据从位置100px开始打印
    for (let i in convert_uptaskxd) {
        //GOODSID,GOODSNAME,GOODSTYPE,FACTORYNAME,GOODSUNIT,DTLGOODSQTY,ZJ,SJ,LOTNO, STHOUSENAME, POSNO, ECODEFLAG, IODTLID 
        LODOP.ADD_PRINT_HTM(iCurLine + 20 * 1, 10, "100%", "100%",
            "<table border='1px solid #00000' cellspacing='0' cellpadding='0' style='width: 252px; text-align: center;table-layout: fixed; white-space: nowrap;'>" +
            "<tr><td style='width: 70px;height: 20px;'>商品编码</td><td colspan='3' style='overflow: hidden;'>" + convert_uptaskxd[i].goodsid + "</td></tr>" +
            "<tr><td style='width: 70px;height: 20px;'>商品名称</td><td colspan='3' style='overflow: hidden;'>" + convert_uptaskxd[i].goodsname + "</td></tr>" +
            "<tr><td style='width: 70px;height: 20px;'>商品规格</td><td colspan='3' style='overflow: hidden;'>" + convert_uptaskxd[i].goodstype + "</td></tr>" +
            "<tr><td style='width: 70px;height: 20px;'>生产厂家</td><td colspan='3' style='overflow: hidden;'>" + convert_uptaskxd[i].factoryname + "</td></tr>" +
            "<tr><td style='width: 70px;height: 20px;'>包装单位</td><td style='width: 60px;overflow: hidden;'>" + convert_uptaskxd[i].goodsunit + "</td>" +
            "<td rowspan='2' style='width: 20px;'>件数</td><td style='overflow: hidden;'>整件:" + convert_uptaskxd[i].zj + "</td></tr>" +
            "<tr><td style='width: 70px;height: 20px;'>数量</td><td style='width: 60px; overflow: hidden;'>" + convert_uptaskxd[i].dtlgoodsqty + "</td>" +
            "<td style='overflow: hidden;'>散件:" + convert_uptaskxd[i].sj + "</td></tr>" +
            "<tr><td style='width: 70px;height: 20px;'>批号</td><td colspan='3' style='overflow: hidden;'>" + convert_uptaskxd[i].lotno + "</td></tr>" +
            "<tr><td style='width: 70px;height: 20px;'>货位</td><td colspan='3' style='overflow: hidden;'>" + convert_uptaskxd[i].sthousename + "</td></tr>" +
            "<tr><td style='width: 70px;height: 20px;'>货架号</td><td colspan='3' style='overflow: hidden;'>" + convert_uptaskxd[i].posno + "</td></tr>" +
            "<tr><td style='width: 70px;height: 20px;'>电子监管</td><td colspan='3' style='overflow: hidden;'>" + convert_uptaskxd[i].ecodeflag + "</td></tr>" +
            "<tr><td style='width: 70px;height: 50px;'>入库细单</td><td colspan='3' style='overflow: hidden;'>" +
            // LODOP.ADD_PRINT_BARCODE(iCurLine+225,100,182,40,"128Auto",convert_uptaskxd[i].IODTLID)+
            "</td></tr></table>");
        LODOP.ADD_PRINT_BARCODE(iCurLine + 230, 100, 182, 40, "128Auto", convert_uptaskxd[i].iodtlid)
        iCurLine = iCurLine + 260
    }
    LODOP.ADD_PRINT_TEXT(iCurLine + 20, 10, 252, 20, '');
    LODOP.PRINT() // 直接打印	
    //LODOP.PREVIEW();
}