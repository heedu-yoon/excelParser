using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountingBook.objectClass;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Excel.Application excelApp = new Excel.Application();
        Excel.Workbook workbook = null;

        private string file_path = "";
        private string save_file_path = "";

        private Hashtable mainTable = new Hashtable();
        private ArrayList deliveryList = new ArrayList();

        private ArrayList coupangList = new ArrayList();
        private ArrayList _11storeList = new ArrayList();
        private ArrayList smartstoreList = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            openFileDialog1.InitialDirectory = "C:\\";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file_path = openFileDialog1.FileName;
                textBox1.Text = file_path;
            }
        }

        private void loadExcel()
        {
            workbook = excelApp.Workbooks.Open(file_path);

            foreach (Excel.Worksheet worksheet in workbook.Worksheets)
            {
                if (worksheet.Name.Equals("쉬퍼맨"))
                {
                    Excel.Range range = worksheet.UsedRange;

                    object[,] data = (object[,])range.Value;

                    if (data == null)
                        continue;

                    for (int row = 2; row <= data.GetLength(0); row++)
                    {
                        Delivery delivery = new Delivery();

                        if (data[row, 1] == null)
                            continue;

                        delivery.serviceNum         = data[row, 1] != null ? data[row, 1].ToString() : "";
                        delivery.serviceData        = data[row, 2] != null ? data[row, 2].ToString() : "";
                        delivery.name               = data[row, 3] != null ? data[row, 3].ToString() : "";
                        delivery.clearance          = data[row, 4] != null ? data[row, 4].ToString() : "";
                        delivery.tracktingNum       = data[row, 5] != null ? data[row, 5].ToString() : "";
                        delivery.productNum         = data[row, 6] != null ? data[row, 6].ToString() : "";
                        delivery.sumPrice           = data[row, 7] != null ? data[row, 7].ToString() : "";
                        delivery.weight             = data[row, 8] != null ? data[row, 8].ToString() : "";
                        delivery.deliveryPrice      = data[row, 9] != null ? data[row, 9].ToString() : "";
                        delivery.HBL                = data[row, 10] != null ? data[row, 10].ToString() : "";
                        delivery.addressNum         = data[row, 11] != null ? data[row, 11].ToString() : "";
                        delivery.receiverAddr       = data[row, 12] != null ? data[row, 12].ToString() : "";
                        delivery.phone              = data[row, 13] != null ? data[row, 13].ToString() : "";
                        delivery.msg                = data[row, 14] != null ? data[row, 14].ToString() : "";
                        delivery.marketOrderNum     = data[row, 15] != null ? data[row, 15].ToString() : "";
                        writeText(delivery.name);

                        deliveryList.Add(delivery);
                    }
                }
                else if(worksheet.Name.Equals("쿠팡"))
                {
                    Excel.Range range = worksheet.UsedRange;

                    object[,] data = (object[,])range.Value;

                    if (data == null)
                        continue;

                    for (int row = 2; row <= data.GetLength(0); row++)
                    {

                        if (data[row, 1] == null)
                            continue;

                        Coupang obj = new Coupang();

                        obj.orderDate = data[row, 10].ToString();
                        obj.orderNum = data[row, 3].ToString();
                        obj.productCode = data[row, 17].ToString();
                        obj.productName = data[row, 11].ToString();
                        obj.optiosnName = data[row, 12].ToString();
                        obj.orderCount = data[row, 23].ToString();
                        obj.orderName = data[row, 25].ToString();
                        obj.orderPhone = data[row, 26].ToString();
                        obj.paymentPrice = data[row, 19].ToString();
                        obj.deliveryPrice = data[row, 21].ToString();
                        obj.PCCC = data[row, 36].ToString();

                        writeText("coupang : " + obj.orderName);

                        coupangList.Add(obj);
                    }

                    writeText("load coupang success");
                }
                else if (worksheet.Name.Equals("11번가"))
                {
                    Excel.Range range = worksheet.UsedRange;

                    object[,] data = (object[,])range.Value;

                    if (data == null)
                        continue;

                    for (int row = 2; row <= data.GetLength(0); row++)
                    {

                        if (data[row, 1] == null)
                            continue;

                        _11Store obj = new _11Store();

                        obj.paydate = data[row, 5].ToString();
                        obj.orderNum = data[row, 3].ToString();
                        obj.productNum = data[row, 39].ToString();
                        obj.productName = data[row, 7].ToString();
                        obj.option = data[row, 8].ToString();
                        obj.productamount = data[row, 11].ToString();
                        obj.orderName = data[row, 36].ToString();
                        obj.orderPhone = data[row, 29].ToString();
                        obj.orderPrice = data[row, 12].ToString();
                        obj.deliveryPrice = data[row, 28].ToString();
                        obj.PCCC = data[row, 57].ToString();
                        obj.resPrice = data[row, 48].ToString();

                        _11storeList.Add(obj);
                    }

                    writeText("load 11store success");
                }
                else if (worksheet.Name.Equals("스마트스토어"))
                {
                    Excel.Range range = worksheet.UsedRange;

                    object[,] data = (object[,])range.Value;

                    if (data == null)
                        continue;

                    for (int row = 2; row <= data.GetLength(0); row++)
                    {

                        if (data[row, 1] == null)
                            continue;

                        SmartStore obj = new SmartStore();

                        obj.paydate = data[row, 58].ToString();
                        obj.orderNum = data[row, 2].ToString();
                        obj.productNum = data[row, 16].ToString();
                        obj.productName = data[row, 17].ToString();
                        obj.optionInfo = data[row, 19].ToString();
                        obj.account = data[row, 21].ToString();
                        obj.orderName = data[row, 9].ToString();
                        obj.orderPhone = data[row, 44].ToString();
                        obj.productPrice = data[row, 26].ToString();
                        obj.amountDeliveryPrice = data[row, 35].ToString();
                        obj.PCCC = data[row, 57].ToString();
                        obj.calculatePrice = data[row, 54].ToString();

                        smartstoreList.Add(obj);
                    }

                    writeText("load smartstore success");
                }

            }

            initSaveSheet();
        }

        private void initSaveSheet()
        {
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet workseet = workbook.Worksheets.Add();

            workseet.Cells[1, 1] = "주문플랫폼";
            workseet.Cells[1, 2] = "주문일자";
            workseet.Cells[1, 3] = "국내오더넘버";
            workseet.Cells[1, 4] = "업체상품코드";
            workseet.Cells[1, 5] = "품목";
            workseet.Cells[1, 6] = "옵션";
            workseet.Cells[1, 7] = "수량";
            workseet.Cells[1, 8] = "구매자";
            workseet.Cells[1, 9] = "구매자연락처";
            workseet.Cells[1, 10] = "수취인";
            workseet.Cells[1, 11] = "수취인연락처";
            workseet.Cells[1, 12] = "주소";
            workseet.Cells[1, 13] = "우편번호";
            workseet.Cells[1, 14] = "메시지";
            workseet.Cells[1, 15] = "개인통관번호";
            workseet.Cells[1, 16] = "상품결제금액";
            workseet.Cells[1, 17] = "고객결제배송비";
            workseet.Cells[1, 18] = "정산금액";
            workseet.Cells[1, 19] = "발주일자";
            workseet.Cells[1, 20] = "해외구매처";
            workseet.Cells[1, 21] = "해외오더넘버";
            workseet.Cells[1, 22] = "결제카드";
            workseet.Cells[1, 23] = "해외현지화폐";
            workseet.Cells[1, 24] = "구매금액(USD)";
            workseet.Cells[1, 25] = "구매금액(원화)";
            workseet.Cells[1, 26] = "배송대행지";
            workseet.Cells[1, 27] = "택배사";
            workseet.Cells[1, 28] = "운송장번호";
            workseet.Cells[1, 29] = "국제배송비";
            workseet.Cells[1, 30] = "화물택배사";
            workseet.Cells[1, 31] = "화물운송장번호";
            workseet.Cells[1, 32] = "예상화물택배비";
            workseet.Cells[1, 33] = "관부가세";

            List<ResultObject> list = getResultObj();

            int cnt = 2;
            foreach(ResultObject res in list)
            {
                workseet.Cells[cnt, 1] = res.orderMarket;
                workseet.Cells[cnt, 2] = res.orderDate;
                workseet.Cells[cnt, 3] = res.innerOrderNum;
                workseet.Cells[cnt, 4] = res.productCode;
                workseet.Cells[cnt, 5] = res.ProductName;
                workseet.Cells[cnt, 6] = res.option;
                workseet.Cells[cnt, 7] = res.orderCount;
                workseet.Cells[cnt, 8] = res.orderPerName;
                workseet.Cells[cnt, 9] = res.orderPhone;
                workseet.Cells[cnt, 10] = res.name;
                workseet.Cells[cnt, 11] = res.phone;
                workseet.Cells[cnt, 12] = res.address;
                workseet.Cells[cnt, 13] = res.addrNum;
                workseet.Cells[cnt, 14] = res.msg;
                workseet.Cells[cnt, 15] = res.PCCC;
                workseet.Cells[cnt, 16] = res.payPrice;
                workseet.Cells[cnt, 17] = res.payDeliveryPrice;
                workseet.Cells[cnt, 18] = res.resPrice;
                workseet.Cells[cnt, 19] = res.releaseDate;
                workseet.Cells[cnt, 20] = res.buyCom;
                workseet.Cells[cnt, 21] = res.buyOrderNum;
                workseet.Cells[cnt, 22] = res.payCard;
                workseet.Cells[cnt, 23] = res.coststate;
                workseet.Cells[cnt, 24] = res.usdPrice;
                workseet.Cells[cnt, 25] = res.wonPrice;
                workseet.Cells[cnt, 26] = res.deliveryPlace;
                workseet.Cells[cnt, 27] = res.deliveryCom;
                workseet.Cells[cnt, 28] = res.HBL;
                workseet.Cells[cnt, 29] = res.deliveryPrice;
                workseet.Cells[cnt, 30] = res.deliveryCom2;
                workseet.Cells[cnt, 31] = res.HBL2;
                workseet.Cells[cnt, 32] = res.deliveryPrice2;
                workseet.Cells[cnt, 33] = res.tax;

                cnt++;

                writeText("write obj : " + res.name);
            }

            workseet.Columns.AutoFit();
            //workbook.Save();
            workbook.SaveAs(save_file_path, Excel.XlFileFormat.xlWorkbookDefault);
            workbook.Close(true);
            excelApp.Quit();

            writeText("success process");
        }

        private List<ResultObject> getResultObj()
        {
            List<ResultObject> list = new List<ResultObject>();
            bool isHit = false;
            string beforePCCC = "";

            foreach(Delivery delivery in deliveryList)
            {
                // 쿠팡
                foreach(Coupang coupang in coupangList)
                {
                    if(!String.IsNullOrEmpty(delivery.clearance) && delivery.clearance.Equals(coupang.PCCC))
                    {
                        ResultObject obj = new ResultObject();

                        obj.orderMarket = "쿠팡";
                        obj.orderDate = coupang.orderDate.Substring(0, 10);
                        obj.innerOrderNum = coupang.orderNum;
                        obj.productCode = coupang.productCode;
                        obj.ProductName = coupang.productName;
                        obj.option = coupang.optiosnName;
                        obj.orderCount = coupang.orderCount;
                        obj.orderPerName = coupang.orderName;
                        obj.orderPhone = coupang.orderPhone;
                        obj.name = delivery.name;
                        obj.phone = delivery.phone;
                        obj.address = delivery.receiverAddr;
                        obj.addrNum = delivery.addressNum;
                        obj.msg = delivery.msg;
                        obj.PCCC = delivery.clearance;
                        obj.payPrice = coupang.paymentPrice;
                        obj.payDeliveryPrice = coupang.deliveryPrice;
                        obj.resPrice = ((int.Parse(coupang.paymentPrice) + int.Parse(coupang.deliveryPrice)) * 0.88).ToString();
                        obj.releaseDate = delivery.serviceData;
                        obj.buyCom = "";
                        obj.buyOrderNum = delivery.marketOrderNum;
                        obj.payCard = "";
                        obj.coststate = "";
                        obj.usdPrice = "";
                        obj.wonPrice = obj.PCCC.Equals(beforePCCC) ? "" : delivery.sumPrice.Replace("\\", "").Replace(",", "");
                        obj.deliveryPlace = "";
                        obj.deliveryCom = "";
                        obj.HBL = delivery.HBL;
                        obj.deliveryPrice = obj.PCCC.Equals(beforePCCC) ? "" : delivery.deliveryPrice;
                        obj.deliveryCom2 = "";
                        obj.deliveryPrice2 = "";
                        obj.tax = "";

                        writeText("is Hot Coupang : " + obj.name);

                        list.Add(obj);

                        beforePCCC = obj.PCCC;
                    }
                }

                foreach(_11Store store in _11storeList)
                {
                    if (!String.IsNullOrEmpty(delivery.clearance) && delivery.clearance.Equals(store.PCCC))
                    {
                        ResultObject obj = new ResultObject();

                        obj.orderMarket = "11번가";
                        obj.orderDate = store.paydate.Substring(0, 10).Replace("/", "-");
                        obj.innerOrderNum = store.orderNum;
                        obj.productCode = store.productNum;
                        obj.ProductName = store.productName;
                        obj.option = store.option;
                        obj.orderCount = store.productamount;
                        obj.orderPerName = store.orderName;
                        obj.orderPhone = store.orderPhone;
                        obj.name = delivery.name;
                        obj.phone = delivery.phone;
                        obj.address = delivery.receiverAddr;
                        obj.addrNum = delivery.addressNum;
                        obj.msg = delivery.msg;
                        obj.PCCC = delivery.clearance;
                        obj.payPrice = store.orderPrice;
                        obj.payDeliveryPrice = store.deliveryPrice;
                        obj.resPrice = store.resPrice;
                        obj.releaseDate = delivery.serviceData;
                        obj.buyCom = "";
                        obj.buyOrderNum = delivery.marketOrderNum;
                        obj.payCard = "";
                        obj.coststate = "";
                        obj.usdPrice = "";
                        obj.wonPrice = obj.PCCC.Equals(beforePCCC) ? "" : delivery.sumPrice.Replace("\\", "").Replace(",", "");
                        obj.deliveryPlace = "";
                        obj.deliveryCom = "";
                        obj.HBL = delivery.HBL;
                        obj.deliveryPrice = obj.PCCC.Equals(beforePCCC) ? "" : delivery.deliveryPrice;
                        obj.deliveryCom2 = "";
                        obj.deliveryPrice2 = "";
                        obj.tax = "";

                        writeText("is Hit 11store : " + obj.name);

                        list.Add(obj);

                        beforePCCC = obj.PCCC;
                    }
                }

                foreach(SmartStore store in smartstoreList)
                {
                    if (!String.IsNullOrEmpty(delivery.clearance) && delivery.clearance.Equals(store.PCCC))
                    {
                        ResultObject obj = new ResultObject();

                        obj.orderMarket = "11번가";
                        obj.orderDate = store.paydate.Substring(0, 10);
                        obj.innerOrderNum = store.orderNum;
                        obj.productCode = store.productNum;
                        obj.ProductName = store.productName;
                        obj.option = store.optionInfo;
                        obj.orderCount = store.account;
                        obj.orderPerName = store.orderName;
                        obj.orderPhone = store.orderPhone;
                        obj.name = delivery.name;
                        obj.phone = delivery.phone;
                        obj.address = delivery.receiverAddr;
                        obj.addrNum = delivery.addressNum;
                        obj.msg = delivery.msg;
                        obj.PCCC = delivery.clearance;
                        obj.payPrice = store.productPrice;
                        obj.payDeliveryPrice = store.amountDeliveryPrice;
                        obj.resPrice = store.calculatePrice;
                        obj.releaseDate = delivery.serviceData;
                        obj.buyCom = "";
                        obj.buyOrderNum = delivery.marketOrderNum;
                        obj.payCard = "";
                        obj.coststate = "";
                        obj.usdPrice = "";
                        obj.wonPrice = obj.PCCC.Equals(beforePCCC) ? "" : delivery.sumPrice.Replace("\\", "").Replace(",", "");
                        obj.deliveryPlace = "";
                        obj.deliveryCom = "";
                        obj.HBL = delivery.HBL;
                        obj.deliveryPrice = obj.PCCC.Equals(beforePCCC) ? "" : delivery.deliveryPrice;
                        obj.deliveryCom2 = "";
                        obj.deliveryPrice2 = "";
                        obj.tax = "";

                        writeText("is Hit smartstore : " + obj.name);

                        list.Add(obj);

                        beforePCCC = obj.PCCC;
                    }
                }
            }

            writeText("make mesultObj success");

            return list;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(file_path) || string.IsNullOrEmpty(save_file_path))
                return;

            loadExcel();
        }

        private void writeText(string msg)
        {
            richTextBox1.AppendText(msg);
            richTextBox1.AppendText("\r\n");
            richTextBox1.ScrollToCaret();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "xlsx";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                save_file_path = saveFileDialog1.FileName.ToString();
                textBox2.Text = save_file_path;
            }
        }
    }
}
