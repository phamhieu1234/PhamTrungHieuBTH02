using System.Text.RegularExpressions;

namespace PhamTrungHieuExcel.Models.Process
{
    public class StringProcess
    {
        public string AutoGenerateCode(string strInput)
        {
            string strReuslt = "", numPart = "", strPart= "";
            //tach phan so tu strInput
            //Vd strInput = "STD0001" thanh numPart = "0001"
            numPart = Regex.Match(strInput,@"\D+").Value;
            //tach phan tu chu tu strInput
            strPart = Regex.Match(strInput,@"\D+").Value;
            //tang phan tu so len 1 don vị
            int intPart = (Convert.ToInt32(numPart)+1);
            //bổ sung cac ky tu 0 con thieu
            for (int i = 0; i <numPart.Length - intPart.ToString().Length;i++);
            {
                strPart +="0";
            }
            strReuslt = strPart + intPart;
            return strReuslt;
        }
    }
}