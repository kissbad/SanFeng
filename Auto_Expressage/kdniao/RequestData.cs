using Auto_Expressage.npserver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Expressage.kdniao
{
    public class RequestData
    {
        public string OrderCode { get; set; }
        public string ShipperCode { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPwd { get; set; }
        public string MonthCode { get; set; }
        public string SendSite { get; set; }
        public string SendStaff { get; set; }
        public int PayType { get; set; } = 3;
        public int ExpType { get; set; }
        public Sender Sender { get; set; } = new Sender();
        public Receiver Receiver { get; set; } = new Receiver();
        public Commodity[] Commodity { get; set; }
        public IEnumerable<AddService> AddService { get; set; }
        public int IsNotice { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int TransType { get; set; }
        public int Weight { get; set; }
        public int Quantity { get; set; }
        public int Volume { get; set; }
        public int IsReturnPrintTemplate { get; set; }
        public string Remark { get; set; }
        public string TemplateSize { get; set; }
        public RequestData(wqh_Expressage exp)
        {
            this.OrderCode = exp.salesid;
            this.ShipperCode = exp.expresscode;
            this.CustomerName = exp.customername;
            this.CustomerPwd = exp.customerpwd;
            this.MonthCode = exp.monthcode;
            this.SendSite = exp.sendsite;
            this.SendStaff = exp.sendstaff;
            this.ExpType = exp.exptype;

            this.Receiver = new Receiver();
            this.Receiver.Name = exp.consignee;
            this.Receiver.Mobile = exp.consigneetelephone;
            this.Receiver.Address = exp.receivingaddress;
            this.Receiver.ProvinceName = exp.provincename;
            this.Receiver.CityName = exp.cityname;
            this.Receiver.ExpAreaName = exp.countryname;


            this.Sender = new Sender();
            Sender.Name = exp.INPUTMANNAME;
            Sender.Mobile = exp.MOBILENO;
            Sender.ProvinceName = exp.PROVINCENAME_S;
            Sender.CityName = exp.CITYNAME_S;
            Sender.ExpAreaName = exp.COUNTRYNAME_S;
            Sender.Address = exp.ADDRESS_S;

            this.Commodity = new Commodity[] { new Commodity() };

            this.TransType = exp.transtype;

            //if (ShipperCode == "JD" && TransType == 29)
            //{
            //    this.AddService = new AddService[] { new AddService("INSURE", exp.zx_insure.ToString()), new AddService("Delivery", "24") ,
            //        new AddService("COD", exp.COD.ToString())};
            //}
            //else { this.AddService = new AddService[] { new AddService("INSURE", exp.zx_insure.ToString()) }; }

            List<AddService> addServices = new List<AddService>
            {
                new AddService("INSURE", exp.zx_insure.ToString())
            };

            if (ShipperCode == "JD" || ShipperCode == "JDKY") {
                if (exp.COD > 0) {
                    addServices.Add(new AddService("COD", exp.COD.ToString()));
                }
                if (TransType == 29) {
                    addServices.Add(new AddService("Delivery", "24"));
                }
            }
            this.AddService = addServices;

            this.IsNotice = 0;

            if(ShipperCode == "SF")
            {
                this.StartDate = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd 16:00:00");
            }
            else {
                this.StartDate = DateTime.Now.ToString("yyyy-MM-dd 20:00:00");
            }
            
            this.EndDate = DateTime.Now.AddDays(3).ToString("yyyy-MM-dd") + " 00:00:00";


            this.IsReturnPrintTemplate = 1;
            this.Quantity = exp.dbs;
            this.Remark = exp.customname;

        }
    }
}
