using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelInfo
{
    public class PostsInfo
    {
        public int PId         { get; set; }
        public string PTitle      { get; set; }
        public string PContent    { get; set; }
        public DateTime CreateDate  { get; set; }
        public string CreateUser  { get; set; }
        public string PState      { get; set; }
        public int PageView    { get; set; }
        public int PlateId     { get; set; }
    }
}
