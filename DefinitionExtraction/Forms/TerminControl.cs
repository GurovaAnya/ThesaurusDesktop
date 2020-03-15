using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DefinitionExtraction
{
    public partial class TerminControl : UserControl
    {
        public int definitionId;
        private string descriptor;
        private string relator;
        private List<string> ascriptors;
        private string definition;
        private int [] descriptorLocation;
        private int [] definitionLocation;
        

        public string Descriptor
        {
            get 
            { return descriptor; }
            set 
            { 
                descriptor = value;
                this.descriptorBox.Text = value;
            }
        }

        public string Relator
        {
            get
            { return relator; }
            set
            {
                relator = value;
                this.relatorBox.Text = value;
            }
        }

        public List<string> Ascriptors
        {
            get { return ascriptors; }
            set
            {
                ascriptors = value;
                if (value!=null)
                foreach (string asc in value)
                    ascriptorsBox.Text += asc + " "; 
            }
        }

        public string Definition
        {
            get { return definition; }
            set
            {
                definition = value;
                definitionBox.Text = value;
            }
        }

        public int [] DescriptorLocation
        {
            get { return descriptorLocation; }
            set
            {
                if (value.Length != 4) throw new Exception("descriptorLocation should consist of 4 elements");
                descriptorLocation = value;
                descriptorLocationBox.Text = value[0] + " " + value[1] + " " + value[2] + " " + value[3];
            }
        }

        public int[] DefinitionLocation
        {
            get { return definitionLocation; }
            set
            {
                if (value.Length != 4) throw new Exception("definitionLocation should consist of 4 elements");
                definitionLocation = value;
                definitionLocationBox.Text = value[0] + " " + value[1] + " " + value[2] + " " + value[3];
            }
        }


        public TerminControl()
        {
            InitializeComponent();
        }

    }
}
