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
        private RelationsList relations;
        

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
                if (value != "")
                    this.relatorBox.Text = "(" + value + ")";
                else relatorBox.Text = "";
            }
        }

        public List<string> Ascriptors
        {
            get { return ascriptors; }
            set
            {
                ascriptors = value;
                ascriptorsBox.Text = "";
                if (value.Count > 0)
                {
                    for(int i=0;i<value.Count-1;i++)
                        ascriptorsBox.Text += value[i] + ", ";
                    ascriptorsBox.Text += value[value.Count - 1];
                }

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

        public RelationsList Relations
        {
            get { return relations; }
            set
            {
                if (value.Count > 0)
                {
                    foreach (KeyValuePair<Relation, List<Termin>> relation in value)
                    {
                        relationsBox.Text += relation.Key.Name + ":";
                        foreach (Termin val in relation.Value)
                        {
                            LinkLabel link = new LinkLabel();
                            link.Text = val.Descriptor;
                            link.LinkClicked += new LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
                            LinkLabel.Link data = new LinkLabel.Link();
                            data.LinkData = val.ID;
                            link.Links.Add(data);
                            link.AutoSize = true;
                            link.Location =
                                this.relationsBox.GetPositionFromCharIndex(this.relationsBox.TextLength);
                            this.relationsBox.Controls.Add(link);
                            this.relationsBox.AppendText(link.Text);
                            this.relationsBox.SelectionStart = this.relationsBox.TextLength;
                            relationsBox.Text += " ,";
                        }
                    }
                }
            }
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Termin termin;
            using (DB db = new DB())
            {
                termin = db.GetTermin((int)e.Link.LinkData);
            }
            foreach (Definition def in termin.Definitions)
            {
                TerminControl tc = new TerminControl
                {
                    Relator = termin.Relator,
                    Descriptor = termin.Descriptor,
                    Definition = def.Content,
                    Ascriptors = termin.Ascriptors,
                    definitionId = def.ID,
                    DefinitionLocation = new int[] { def.StartLine, def.StartChar, def.EndLine, def.EndChar },
                    DescriptorLocation = new int[] { termin.StartLine, termin.StartChar, termin.EndLine, termin.EndChar },
                    Relations = termin.relations
                };


            }
            
        }


        public TerminControl()
        {
            InitializeComponent();
        }

    }
}
