using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuHuynh_Vido.Shared.Dtos
{
    public class UserIMSDTODetail
    {
        public bool success { get; set; }

        public int id { get; set; }
        public string? userid { get; set; }
        public string hocvien { get; set; }

        public int Giangvienid { get; set; }
        public string? ma { get; set; }
        public string? ten { get; set; }
        public bool gvcohuuyn { get; set; }
        public string? email { get; set; }
        public string? sdt { get; set; }
        public string? diachi { get; set; }
        public string? ngaysinh { get; set; }

        public string? token { get; set; }
    }
}
