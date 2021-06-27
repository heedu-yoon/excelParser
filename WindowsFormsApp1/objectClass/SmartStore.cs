using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingBook.objectClass
{
    public class SmartStore
    {
        // 상품주문번호	주문번호	배송방법(구매자 요청)	배송방법	택배사	송장번호	발송일	판매채널	구매자명	
        // 구매자ID	수취인명	주문상태	주문세부상태	결제위치	결제일	상품번호	상품명	상품종류	옵션정보	
        // 옵션관리코드	수량	옵션가격	상품가격	상품별 할인액	판매자 부담 할인액	상품별 총 주문금액	사은품	발주확인일	
        // 발송기한	발송처리일	송장출력일	배송비 형태	배송비 묶음번호	배송비 유형	배송비 합계	제주/도서 추가배송비	배송비 할인액	
        // 판매자 상품코드	판매자 내부코드1	판매자 내부코드2	수취인연락처1	수취인연락처2	배송지	구매자연락처	우편번호	
        // 배송메세지	출고지	결제수단	수수료 과금구분	수수료결제방식	결제수수료	매출연동 수수료	매출연동 수수료 구분	정산예정금액	
        // 유입경로	구매자 주민등록번호	개인통관고유부호	주문일시	배송속성	배송희망일	(수취인연락처1)	(수취인연락처2)	(우편번호)	(기본주소)	
        // (상세주소)	(구매자연락처)
        public string productOrderNum { get; set; }
        public string orderNum { get; set; }
        public string deliveryMethod { get; set; }
        public string deliveryCom { get; set; }
        public string HBL { get; set; }
        public string releaseDate { get; set; }
        public string channel { get; set; }
        public string orderName { get; set; }
        public string receiverID { get; set; }
        public string receiverName { get; set; }
        public string orderStatus { get; set; }
        public string orderDetailStatus { get; set; }
        public string payPlace { get; set; }
        public string paydate { get; set; }
        public string productNum { get; set; }
        public string productName { get; set; }
        public string productKind { get; set; }
        public string optionInfo { get; set; }
        public string optionManageCode { get; set; }
        public string account { get; set; }
        public string optionPrice { get; set; }
        public string productPrice { get; set; }
        public string discountPrice { get; set; }
        public string sellerDiscount { get; set; }
        public string amountPrice { get; set; }
        public string gift { get; set; }
        public string confirmDate { get; set; }
        public string releaseLimitDate { get; set; }
        public string releaseConfirmDate { get; set; }
        public string invoicePrintDate { get; set; }
        public string deliveryPriceState { get; set; }
        public string deliveryBundleNum { get; set; }
        public string deliveryPricestatus { get; set; }
        public string amountDeliveryPrice { get; set; }
        public string addDeliveryPrice { get; set; }
        public string deliveryDiscountPrice { get; set; }
        // 판매자 상품코드	판매자 내부코드1	판매자 내부코드2	수취인연락처1	수취인연락처2	배송지	구매자연락처	우편번호	
        // 배송메세지	출고지	결제수단	수수료 과금구분	수수료결제방식	결제수수료	매출연동 수수료	매출연동 수수료 구분	정산예정금액	
        // 유입경로	구매자 주민등록번호	개인통관고유부호	주문일시	배송속성	배송희망일	(수취인연락처1)	(수취인연락처2)	(우편번호)	(기본주소)	
        // (상세주소)	(구매자연락처)
        public string sellerProcCode { get; set; }
        public string sellerInnercode1 { get; set; }
        public string sellerInnercode2 { get; set; }
        public string receiverPhone1 { get; set; }
        public string receiverPhone2 { get; set; }
        public string deliveryPlace { get; set; }
        public string orderPhone { get; set; }
        public string addrNum { get; set; }
        public string deliveryMsg { get; set; }
        public string releasePlace { get; set; }
        public string payTools { get; set; }
        public string feeChargeState { get; set; }
        public string feePayTools { get; set; }
        public string payfee { get; set; }
        public string salesfee { get; set; }
        public string salesfeestatus { get; set; }
        public string calculatePrice { get; set; }

    }
}
