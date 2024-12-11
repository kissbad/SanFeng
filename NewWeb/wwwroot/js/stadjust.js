function stadjust(stadjustzd) {
	//A.STORERNAME,A.CREDATE,A.STADJUSTID,A.SOURCEID,A.HPXX,A.PHXX,A.SL,A.POSNO,A.STHOUSENAME,A.NEWPOSNO,A.NEWSTHOUSENAME
	let convert_stadjustzd = stadjustzd;
	LODOP.SET_PRINT_STYLE("FontSize",11);
	LODOP.ADD_PRINT_TEXT(0,0,272,20,convert_stadjustzd.storername+"补货单");
	LODOP.SET_PRINT_STYLEA(0,"Alignment",2);
	LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
	LODOP.ADD_PRINT_TEXT(20,10,65,20,"生成日期:");
	LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
	LODOP.ADD_PRINT_TEXT(20,75,177,20,convert_stadjustzd.credate);//波次号ID
	LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
	LODOP.ADD_PRINT_TEXT(40,10,65,20,'补货单ID:');//波次号ID
	LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
	LODOP.ADD_PRINT_TEXT(40,75,61,20,convert_stadjustzd.stadjustid);//波次号ID
	LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
	LODOP.ADD_PRINT_TEXT(40,136,54,20,'来源ID:');//波次号ID
	LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
	LODOP.ADD_PRINT_TEXT(40,190,62,20,convert_stadjustzd.sourceid);//波次号ID
	LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
	LODOP.ADD_PRINT_TEXT(60,10,65,20,"货品信息:");
	LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
	LODOP.ADD_PRINT_TEXT(60,75,177,60,convert_stadjustzd.hpxx);
	LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
	LODOP.ADD_PRINT_TEXT(120,10,65,20,"批号:");
	LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
	LODOP.ADD_PRINT_TEXT(120,75,177,20,convert_stadjustzd.phxx);
	LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
	LODOP.ADD_PRINT_TEXT(140,10,65,20,"数量:");
	LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
	LODOP.ADD_PRINT_TEXT(140,75,177,20,convert_stadjustzd.sl);
	LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
	LODOP.ADD_PRINT_TEXT(160,10,65,20,'原分区:');
	LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
	LODOP.ADD_PRINT_TEXT(160,75,177,20,convert_stadjustzd.sthousename);
	LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
	LODOP.ADD_PRINT_TEXT(180,10,65,20,'新分区:');
	LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
	LODOP.ADD_PRINT_TEXT(180,75,177,20,convert_stadjustzd.newsthousename);
	LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
	LODOP.ADD_PRINT_TEXT(200,10,65,20,'原货位:');
	LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
	LODOP.ADD_PRINT_TEXT(200,75,177,20,convert_stadjustzd.posno);
	LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
	LODOP.ADD_PRINT_TEXT(220,10,65,20,'新货位:');
	LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
	LODOP.ADD_PRINT_TEXT(220,75,177,20,convert_stadjustzd.newposno);
	LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
	LODOP.ADD_PRINT_BARCODE(240,10,252,60,"128Auto",convert_stadjustzd.stadjustid);
	LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
	LODOP.ADD_PRINT_TEXT(300,10,252,20,'');
	LODOP.SET_PRINT_STYLEA(0, 'ItemType', 1) // ->放在某处后面表示每一页都有这个内容
	LODOP.PRINT() // 直接打印
	//LODOP.PREVIEW();

}