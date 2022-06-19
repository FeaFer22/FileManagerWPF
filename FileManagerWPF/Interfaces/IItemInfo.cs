using System;
using System.IO.Packaging;

namespace FileManagerWPF.Models
{
    interface IItemInfo
    {
        public string itemName { get; set; }
        public DateTime itemDateChanged { get; set; }
        public string itemSize { get; set; }
        public string itemType { get; set; }
        public string itemPath { get; set; }
    }
}
