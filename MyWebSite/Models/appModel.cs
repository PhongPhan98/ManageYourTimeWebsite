using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebSite.Models
{
    public class appModel
    {
        public ThongTinKhaiBao thongtinkhaibao { get; set; }

        public List<ToChucHoTro> tochuchotro { get; set; }
    }
}