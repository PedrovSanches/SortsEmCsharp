using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortsEmCsharp
{
    public partial class Form_Output : Form
    {
        public Form_Output()
        {
            InitializeComponent();
        }
        public string string_original
        { 
            get { return txt_original.Text; }
            set { txt_original.Text = value; }
        }
        public string string_novo
        {
            get { return txt_novo.Text; }
            set { txt_novo.Text = value; }
        }
        
    }
}
