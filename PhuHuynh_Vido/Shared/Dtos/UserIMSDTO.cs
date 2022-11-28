using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace PhuHuynh_Vido.Shared.Dtos
{
    public class UserIMSDTO
    {
        public bool success { get; set; }
        [Required]
        [JsonProperty(PropertyName = "user")]
        public User user { get; set; }
        public string? token { get; set; }
    }
    public class User
    {
        public int id { get; set; }
        public string? userid { get; set; }
        public string hocvien { get; set; }
        [Required]
        [JsonProperty(PropertyName = "giangVien")]
        public Giangvien giangVien { get; set; }
    }
    public class Giangvien
    {
        public int id { get; set; }
        public string? ma { get; set;}
        public string? ten { get; set;}
        public bool gvcohuuyn { get; set;}
        public string? email { get; set; }
        public string? sdt { get; set; }
        public string? diachi { get; set; }
        public string? ngaysinh { get; set; }
    }
}
