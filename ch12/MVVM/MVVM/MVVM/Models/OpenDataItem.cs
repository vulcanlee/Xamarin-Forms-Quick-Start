using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM.Models
{
    public class OpenDataItem
    {
        public string 創業空間名稱 { get; set; }
        public string 所屬單位 { get; set; }
        public string 創業空間類型 { get; set; }
        public string 招募團隊類型 { get; set; }
        public double 座標經度 { get; set; }
        public double 座標緯度 { get; set; }
        public string 空間用途 { get; set; }
        public string 縣市區域 { get; set; }
        public string 地址 { get; set; }
        public string 詳細照片 { get; set; }
        public string 連絡電話 { get; set; }
        [JsonProperty(PropertyName = "聯絡e-mail")]
        public string 聯絡email { get; set; }
        public string 官方網站 { get; set; }
        public string 使用坪數 { get; set; }
        public string 使用時間 { get; set; }
        public DateTime 建立時間 { get; set; }
        public DateTime 修改時間 { get; set; }
    }
}
