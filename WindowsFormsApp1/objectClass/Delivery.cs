using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingBook.objectClass
{
    public class Delivery
    {
        //신청번호	신청일	수취인	개인통관고유번호	중국트래킹번호	수량	총구매비	무게	배송비	송장번호(HBL)	우편번호	수취인 주소	연락처	배송메시지	오픈마켓 주문번호
        public string serviceNum { get; set; }
        public string serviceData { get; set; }
        public string name { get; set; }
        public string clearance { get; set; }
        public string tracktingNum { get; set; }
        public string productNum { get; set; }
        public string sumPrice { get; set; }
        public string weight { get; set; }
        public string deliveryPrice { get; set; }
        public string HBL { get; set; }
        public string addressNum { get; set; }
        public string receiverAddr { get; set; }
        public string phone { get; set; }
        public string msg { get; set; }
        public string marketOrderNum { get; set; }

    }
}
