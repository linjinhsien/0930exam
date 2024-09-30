namespace WebApplication1.Models
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class MyofficeACPDContext: DbContext
    {
        [Key]
        [MaxLength(20)]
        public string AcpdSid { get; set; }       // 使用者主鍵 (User primary key)

        [MaxLength(60)]
        public string AcpdCname { get; set; }     // 中文名稱 (Chinese name)

        [MaxLength(40)]
        public string AcpdEname { get; set; }     // 英文名稱 (English name)

        [MaxLength(40)]
        public string AcpdSname { get; set; }     // 簡稱 (Abbreviation)

        [MaxLength(60)]
        [EmailAddress]
        public string AcpdEmail { get; set; }     // 使用者信箱 (User email)

        public byte AcpdStatus { get; set; }      // 狀態: 0=正常 (Normal), 99=不正常 (Not normal)

        public bool AcpdStop { get; set; }        // 是否停用: 0=可登入 (Active), 1=不可登入 (Cannot log in)

        [MaxLength(600)]
        public string AcpdStopMemo { get; set; }  // 停用原因 (Deactivation reason)

        [MaxLength(30)]
        public string AcpdLoginID { get; set; }   // 登入帳號 (Login account)

        [MaxLength(60)]
        public string AcpdLoginPW { get; set; }   // 登入密碼 (Login password)

        [MaxLength(120)]
        public string AcpdMemo { get; set; }      // 備註 (Remarks)

        public DateTime AcpdNowdatetime { get; set; }  // 新增日期 (Creation date)

        [MaxLength(20)]
        public string AcpdNewID { get; set; }     // 新增人員代碼 (Created by)

        public DateTime? AcpdUpddatetime { get; set; } // 修改日期 (Last updated date)

        [MaxLength(20)]
        public string AcpdUpdID { get; set; }     // 修改人員代碼 (Last updated by)
    }

}
