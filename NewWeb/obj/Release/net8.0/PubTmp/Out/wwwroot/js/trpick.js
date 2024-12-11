function trpick(trpickzd, trpickxd, trpicksd) {
	let convert_trpickzd = trpickzd;
	let convert_trpickxd = trpickxd;
	let convert_trpicksd = trpicksd;

	LODOP.ADD_PRINT_TEXT(20,0,272,20,"拣货单");
	LODOP.SET_PRINT_STYLEA(0,"FontSize",11);
	LODOP.SET_PRINT_STYLEA(0,"Alignment",2);
	LODOP.ADD_PRINT_TEXT(20,10,40,20,convert_trpickzd.invtypename);
	LODOP.SET_PRINT_STYLEA(0,"FontSize",10);
	LODOP.ADD_PRINT_TEXT(20,50,70,20,convert_trpickzd.comefrom+convert_trpickzd.goodsdeptname);
	LODOP.SET_PRINT_STYLEA(0,"FontSize",10);
	LODOP.ADD_PRINT_TEXT(20,172,70,20,convert_trpickzd.mermecdeptname);
	LODOP.SET_PRINT_STYLEA(0,"FontSize",11);
	LODOP.ADD_PRINT_TEXT(20,242,20,20,convert_trpickzd.isrecflag);
	LODOP.SET_PRINT_STYLEA(0,"FontSize",11);
	LODOP.ADD_PRINT_TEXT(60,10,54,25,"波次号:");
	LODOP.ADD_PRINT_BARCODE(40,53,226,60,"128Auto",convert_trpickzd.waveno);
	LODOP.ADD_PRINT_TEXT(105,10,65,20,"波次号ID:");
	LODOP.ADD_PRINT_TEXT(105,75,61,20,convert_trpickzd.waveid);//波次号ID
	LODOP.ADD_PRINT_TEXT(105,136,40,20,"日期:");
	LODOP.ADD_PRINT_TEXT(105,176,96,20,convert_trpickzd.credate);
	LODOP.ADD_PRINT_TEXT(125,10,50,42,"客户名称:");
	LODOP.SET_PRINT_STYLEA(0,"FontSize",11);
	LODOP.ADD_PRINT_TEXT(125,45,227,42,convert_trpickzd.companyname);
	LODOP.SET_PRINT_STYLEA(0,"FontSize",11);
	LODOP.ADD_PRINT_TEXT(167,10,40,20,"备注:");
	LODOP.ADD_PRINT_TEXT(167,50,86,20,convert_trpickzd.memo);
	LODOP.ADD_PRINT_TEXT(167,136,55,20,"收货人:");
	LODOP.ADD_PRINT_TEXT(167,191,81,20,convert_trpickzd.consignee);
	LODOP.ADD_PRINT_TEXT(187,10,63,20,"配送方式:");
	LODOP.ADD_PRINT_TEXT(187,73,65,20,convert_trpickzd.placetypename);
	LODOP.ADD_PRINT_TEXT(187,136,63,20,"运输路线:");
	LODOP.ADD_PRINT_TEXT(187,199,73,20,convert_trpickzd.translinename);
	LODOP.ADD_PRINT_LINE(207,10,207,262,0,0);
	var iCurLine=195;//标题行之后的数据从位置80px开始打印
	for (let i in convert_trpickxd){
		//A.GOODSNAME, A.GOODSTYPE, A.LOTNO, A.FACTORYNAME, A.HOLDERSNAME, A.PACKSIZE, A.ZL, A.JS, A.POSNO, A.STHOUSENAME,A.PICKDOCID
		LODOP.ADD_PRINT_TEXT(iCurLine+20*1,10,262,20,convert_trpickxd[i].goodsname);
		LODOP.SET_PRINT_STYLEA(0,"FontSize",12);
		LODOP.ADD_PRINT_TEXT(iCurLine+20*2,10,262,20,'规格:'+convert_trpickxd[i].goodstype);
		LODOP.SET_PRINT_STYLEA(0,"FontSize",12);
		LODOP.ADD_PRINT_TEXT(iCurLine+20*3,10,262,20,'批号:'+convert_trpickxd[i].lotno);
		LODOP.SET_PRINT_STYLEA(0,"FontSize",12);
		LODOP.ADD_PRINT_TEXT(iCurLine+20*1,137,115,60,convert_trpickxd[i].ecodeflag);
		LODOP.SET_PRINT_STYLEA(0,"FontSize",40);
		LODOP.ADD_PRINT_TEXT(iCurLine+20*4,10,262,20,'厂家:'+convert_trpickxd[i].factoryname);
		LODOP.SET_PRINT_STYLEA(0,"FontSize",12);
		LODOP.ADD_PRINT_TEXT(iCurLine+20*5,10,262,20,'持有人:'+convert_trpickxd[i].holdersname);
		LODOP.SET_PRINT_STYLEA(0,"FontSize",12);
		LODOP.ADD_PRINT_TEXT(iCurLine+20*6,10,262,20,'包装大小:'+convert_trpickxd[i].packsize+'/件');
		LODOP.SET_PRINT_STYLEA(0,"FontSize",12);
		LODOP.ADD_PRINT_TEXT(iCurLine+20*7,10,262,20,'中包装:'+convert_trpickxd[i].medpackinter);
		LODOP.SET_PRINT_STYLEA(0,"FontSize",20);
		LODOP.ADD_PRINT_TEXT(iCurLine+20*9,10,262,20,'总数量:'+convert_trpickxd[i].zl);
		LODOP.SET_PRINT_STYLEA(0,"FontSize",12);
		LODOP.ADD_PRINT_TEXT(iCurLine+20*10,10,262,20,'整件:'+convert_trpickxd[i].zj);
		LODOP.SET_PRINT_STYLEA(0,"FontSize",12);
		LODOP.ADD_PRINT_TEXT(iCurLine+20*11,10,262,20,'散件:'+convert_trpickxd[i].sj);
		LODOP.SET_PRINT_STYLEA(0,"FontSize",12);
		LODOP.ADD_PRINT_TEXT(iCurLine+20*12,10,262,20,'货架号:'+convert_trpickxd[i].posno);
		LODOP.SET_PRINT_STYLEA(0,"FontSize",12);
		LODOP.ADD_PRINT_TEXT(iCurLine+20*13,10,262,20,'分区:'+convert_trpickxd[i].sthousename);
		LODOP.SET_PRINT_STYLEA(0,"FontSize",12);
		LODOP.ADD_PRINT_TEXT(iCurLine+20*7,145,120,60,convert_trpickzd.zx_columna);
		LODOP.SET_PRINT_STYLEA(0,"FontSize",18);
		LODOP.ADD_PRINT_TEXT(iCurLine+20*9,137,115,60,convert_trpickzd.goodsunitflag);
		LODOP.SET_PRINT_STYLEA(0,"FontSize",40);
		LODOP.ADD_PRINT_LINE(iCurLine+20*13+19,10,iCurLine+20*13+19,262,0,0);
		iCurLine=iCurLine+20*13+5;//每行占25px	
	}																						
	LODOP.ADD_PRINT_TEXT(iCurLine+20*2,10,54,25,"拣货单:");
	LODOP.ADD_PRINT_BARCODE(iCurLine+20*1,53,221,60,"128Auto",convert_trpickzd.pickdocid);
	LODOP.ADD_PRINT_TEXT(iCurLine+20*4+5,10,63,20,"拣货条数:");
	LODOP.ADD_PRINT_TEXT(iCurLine+20*4+5,73,65,20,convert_trpicksd.jhmxs);
	LODOP.ADD_PRINT_TEXT(iCurLine+20*4+5,136,63,20,"拣货仓数:");
	LODOP.ADD_PRINT_TEXT(iCurLine+20*4+5,199,73,20,convert_trpicksd.jhkcs);
	LODOP.ADD_PRINT_TEXT(iCurLine+20*5+5,10,63,20,"打印日期:");
	LODOP.ADD_PRINT_TEXT(iCurLine+20*5+5,73,227,20,convert_trpicksd.rq);
	LODOP.ADD_PRINT_TEXT(iCurLine+20*6+5,10,63,20,"打印方式:");
	LODOP.ADD_PRINT_TEXT(iCurLine+20*6+5,73,65,20,"自动打印");
	LODOP.ADD_PRINT_TEXT(iCurLine+20*6+5,136,63,20,"制单人员:");
	LODOP.ADD_PRINT_TEXT(iCurLine+20*6+5,199,73,20,convert_trpickzd.inputmanname);
	LODOP.ADD_PRINT_TEXT(iCurLine+20*7+5,199,73,20,'');
	LODOP.PRINT() // 直接打印
	//LODOP.PREVIEW();
}