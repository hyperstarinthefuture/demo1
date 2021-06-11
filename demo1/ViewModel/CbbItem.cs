using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace demo1.ViewModel
{
    public class CbbItem
    {
        public CbbItem() { }
        public CbbItem(int value, string text)
        {
            this.Value = value;
            this.Text = text;
        }
        public int Value { get; set; }
        public string Text { get; set; }
        public override string ToString()
        {
            return this.Text;
        }
    }
}
