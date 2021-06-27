using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingBook.objectClass
{
    public class _11Store
    {
        // 번호	주문상태	주문번호	주문순번	결제일시	배송번호	상품명	옵션	바코드	판매자/공급업체	수량	주문금액	
        // 수취인	배송방법	택배사코드	송장번호	발주확인일	발송처리일	발송마감일	예상발송일	배송완료여부	묶음여부	배송주체	
        // 배송비결제방식	배송비	도서산간 배송비	배송비쿠폰	고객결제배송비	휴대폰번호	전화번호	우편번호	주소	배송메시지	선물포장	
        // 선물주문	구매자	구매자ID	판매방식	상품번호	판매자 상품코드	판매단가	옵션가	판매자기본할인금액	판매자 추가할인금액	서비스이용료 정책	
        // 기본서비스이용료(율)	서비스이용료	정산예정금액

        //public string serviceNum { get; set; }
        //public string orderstate { get; set; }
        public string orderNum { get; set; }
        //public string orderSequenc { get; set; }
        public string paydate { get; set; }
        //public string deliveryNum { get; set; }
        public string productName { get; set; }
        public string option { get; set; }
        //public string barcode { get; set; }
        //public string seller { get; set; }
        public string productamount { get; set; }
        public string orderPrice { get; set; }
        //public string recevierName { get; set; }
        //public string deliveryMethod { get; set; }
        //public string deliverycomCode { get; set; }
        //public string HBL { get; set; }
        //public string releaseConfirmDate { get; set; }
        //public string releaseDate { get; set; }
        //public string releaseLimitDate { get; set; }
        //public string releaseSucDate { get; set; }
        //public string isReleaseComplete { get; set; }
        //public string isBundle { get; set; }
        //public string deliveryMain { get; set; }
        //public string deliveryPricePayTool { get; set; }
        public string deliveryPrice { get; set; }
        //public string addDeliveryPrice { get; set; }
        //public string deliveryCoupone { get; set; }
        //public string payDeliveryPrice { get; set; }

        public string productNum { get; set; }

        public string orderName { get; set; }

        public string orderPhone { get; set; }

        public string PCCC { get; set; }

        public string resPrice { get; set; }
    }
}
