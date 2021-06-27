using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingBook.objectClass
{
    public class Coupang
    {
        //번호	묶음배송번호	주문번호	택배사	운송장번호	분리배송 Y/N	분리배송 출고예정일	주문시 출고예정일	출고일(발송일)	주문일	등록상품명	
        // 등록옵션명	노출상품명(옵션명)	노출상품ID	옵션ID	최초등록옵션명	업체상품코드	바코드	결제액	배송비구분	배송비	
        // 도서산간 추가배송비	구매수(수량)	옵션판매가(판매단가)	구매자	구매자전화번호	수취인이름	수취인전화번호	우편번호	
        // 수취인 주소	배송메세지	상품별 추가메시지	주문자 추가메시지	배송완료일	구매확정일자	개인통관번호(PCCC)	
        // 통관용구매자전화번호	기타	결제위치
        //public string serviceNum { get; set; }
        //public string bundledelNum { get; set; }
        public string orderNum { get; set; }

        public string orderDate { get; set; }
        public string productName { get; set; }
        public string optiosnName { get; set; }

        public string productCode { get; set; }
        public string paymentPrice { get; set; }
        public string deliveryPrice { get; set; }
        public string orderCount { get; set; }
        public string orderName { get; set; }
        public string orderPhone { get; set; }
        public string PCCC { get; set; }
    }
}
