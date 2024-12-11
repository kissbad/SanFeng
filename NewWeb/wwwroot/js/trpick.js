function trpick(trpickzd, trpickxd, trpicksd) {
	let convert_trpickzd = trpickzd;
	let convert_trpickxd = trpickxd;
	let convert_trpicksd = trpicksd;

	LODOP.ADD_PRINT_TEXT(0, 0, 272, 20, "拣货单");
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
	LODOP.SET_PRINT_STYLEA(0, "Alignment", 2);
	LODOP.ADD_PRINT_TEXT(0, 10, 40, 24, convert_trpickzd.invtypename);
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
	LODOP.ADD_PRINT_TEXT(0, 50, 70, 12, convert_trpickzd.comefrom + convert_trpickzd.goodsdeptname);
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
	LODOP.ADD_PRINT_TEXT(0, 172, 70, 12, convert_trpickzd.mermecdeptname);
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
	LODOP.ADD_PRINT_TEXT(0, 242, 20, 12, convert_trpickzd.isrecflag);
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);

	LODOP.ADD_PRINT_TEXT(35, 10, 54, 25, "波次号:");
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
	LODOP.ADD_PRINT_BARCODE(12, 53, 226, 60, "128Auto", convert_trpickzd.waveno);

	LODOP.ADD_PRINT_TEXT(75, 10, 60, 12, "总单单号:");
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
	LODOP.ADD_PRINT_TEXT(75, 60, 212, 12, convert_trpickzd.zdid);
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);

	LODOP.ADD_PRINT_TEXT(87, 10, 60, 12, "波次号ID:");
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
	LODOP.ADD_PRINT_TEXT(87, 60, 76, 12, convert_trpickzd.waveid);//波次号ID
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
	LODOP.ADD_PRINT_TEXT(87, 136, 60, 12, "日期:");
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
	LODOP.ADD_PRINT_TEXT(87, 186, 76, 12, convert_trpickzd.credate);
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);

	LODOP.ADD_PRINT_TEXT(99, 10, 60, 12, "客户名称:");
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
	LODOP.ADD_PRINT_TEXT(99, 60, 212, 12, convert_trpickzd.companyname);
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);

	LODOP.ADD_PRINT_TEXT(111, 10, 60, 12, "备注:");
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
	LODOP.ADD_PRINT_TEXT(111, 60, 76, 12, convert_trpickzd.memo);
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
	LODOP.ADD_PRINT_TEXT(111, 136, 60, 12, "收货人:");
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
	LODOP.ADD_PRINT_TEXT(111, 186, 76, 12, convert_trpickzd.consignee);
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);

	LODOP.ADD_PRINT_TEXT(123, 10, 60, 12, "配送方式:");
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
	LODOP.ADD_PRINT_TEXT(123, 60, 76, 12, convert_trpickzd.placetypename);
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
	LODOP.ADD_PRINT_TEXT(123, 136, 60, 12, "运输路线:");
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
	LODOP.ADD_PRINT_TEXT(123, 186, 76, 12, convert_trpickzd.translinename);
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);

	LODOP.ADD_PRINT_LINE(135, 10, 135, 262, 0, 0);

	var iCurLine = 124;//标题行之后的数据从位置80px开始打印
	for (let i in convert_trpickxd) {
		//A.GOODSNAME, A.GOODSTYPE, A.LOTNO, A.FACTORYNAME, A.HOLDERSNAME, A.PACKSIZE, A.ZL, A.JS, A.POSNO, A.STHOUSENAME,A.PICKDOCID
		LODOP.ADD_PRINT_TEXT(iCurLine + 12 * 1, 10, 262, 12, convert_trpickxd[i].goodsname);
		LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
		LODOP.ADD_PRINT_TEXT(iCurLine + 12 * 2, 10, 262, 12, '规格:' + convert_trpickxd[i].goodstype);
		LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
		LODOP.ADD_PRINT_TEXT(iCurLine + 12 * 3, 10, 262, 12, '批号:' + convert_trpickxd[i].lotno);
		LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
		LODOP.ADD_PRINT_TEXT(iCurLine + 12 * 1, 137, 115, 60, convert_trpickxd[i].ecodeflag);
		LODOP.SET_PRINT_STYLEA(0, "FontSize", 40);
		LODOP.ADD_PRINT_TEXT(iCurLine + 12 * 4, 10, 262, 12, '厂家:' + convert_trpickxd[i].factoryname);
		LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
		LODOP.ADD_PRINT_TEXT(iCurLine + 12 * 5, 10, 262, 12, '持有人:' + convert_trpickxd[i].holdersname);
		LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
		LODOP.ADD_PRINT_TEXT(iCurLine + 12 * 6, 10, 262, 12, '包装大小:' + convert_trpickxd[i].packsize + '/件');
		LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
		LODOP.ADD_PRINT_TEXT(iCurLine + 12 * 7, 10, 262, 12, '总数量:' + convert_trpickxd[i].zl);
		LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
		LODOP.ADD_PRINT_TEXT(iCurLine + 12 * 8, 10, 262, 12, '整件:' + convert_trpickxd[i].zj);
		LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
		LODOP.ADD_PRINT_TEXT(iCurLine + 12 * 9, 10, 262, 12, '散件:' + convert_trpickxd[i].sj);
		LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
		LODOP.ADD_PRINT_TEXT(iCurLine + 12 * 10, 10, 262, 12, '货架号:' + convert_trpickxd[i].posno);
		LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
		LODOP.ADD_PRINT_TEXT(iCurLine + 12 * 11, 10, 262, 12, '分区:' + convert_trpickxd[i].sthousename);
		LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
		LODOP.ADD_PRINT_TEXT(iCurLine + 12 * 7, 137, 115, 60, convert_trpickzd.goodsunitflag);
		LODOP.SET_PRINT_STYLEA(0, "FontSize", 40);
		LODOP.ADD_PRINT_LINE(iCurLine + 12 * 11 + 12, 10, iCurLine + 12 * 11 + 12, 262, 0, 0);
		iCurLine = iCurLine + 12 * 11 + 5;//每行占25px	
	}
	LODOP.ADD_PRINT_TEXT(iCurLine + 12 * 2, 10, 54, 25, "拣货单:");
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
	LODOP.ADD_PRINT_BARCODE(iCurLine + 12 * 1, 53, 221, 60, "128Auto", convert_trpickzd.pickdocid);
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
	LODOP.ADD_PRINT_TEXT(iCurLine + 12 * 6 + 5, 10, 63, 12, "拣货条数:");
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
	LODOP.ADD_PRINT_TEXT(iCurLine + 12 * 6 + 5, 73, 65, 12, convert_trpicksd.jhmxs);
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
	LODOP.ADD_PRINT_TEXT(iCurLine + 12 * 6 + 5, 136, 63, 12, "拣货仓数:");
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
	LODOP.ADD_PRINT_TEXT(iCurLine + 12 * 6 + 5, 199, 73, 12, convert_trpicksd.jhkcs);
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
	LODOP.ADD_PRINT_TEXT(iCurLine + 12 * 7 + 5, 10, 63, 12, "打印日期:");
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
	LODOP.ADD_PRINT_TEXT(iCurLine + 12 * 7 + 5, 73, 227, 12, convert_trpicksd.rq);
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
	LODOP.ADD_PRINT_TEXT(iCurLine + 12 * 8 + 5, 10, 63, 12, "打印方式:");
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
	LODOP.ADD_PRINT_TEXT(iCurLine + 12 * 8 + 5, 73, 65, 12, "自动打印");
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
	LODOP.ADD_PRINT_TEXT(iCurLine + 12 * 8 + 5, 136, 63, 12, "制单人员:");
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
	LODOP.ADD_PRINT_TEXT(iCurLine + 12 * 8 + 5, 199, 73, 12, convert_trpickzd.inputmanname);
	LODOP.SET_PRINT_STYLEA(0, "FontSize", 8);
	LODOP.ADD_PRINT_TEXT(iCurLine + 12 * 10 + 5, 199, 73, 12, '');
	LODOP.PRINT() // 直接打印
	//LODOP.PREVIEW();
}