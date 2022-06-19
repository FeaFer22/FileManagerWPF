using System;

namespace FileManagerWPF.Models
{
    public class Item : IItemInfo
    {
        public string itemName { get; set; }
        public DateTime itemDateChanged { get; set; }
        public string itemSize { get; set; }
        public string itemType { get; set; }
        public string itemPath { get; set; }
    }
}
