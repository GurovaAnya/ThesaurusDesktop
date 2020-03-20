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
        private List<Link> links;

        public string SelectedText
        {
            get { return definitionBox.SelectedText; }
        }

        public int SelectedIndex
        {
            get { return definitionBox.SelectionStart; }
        }
        

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
                if (value.Length != 4) throw new Exception("DescriptorLocation should consist of 4 elements");
                descriptorLocation = value;
                descriptorLocationBox.Text = value[0] + " " + value[1] + " " + value[2] + " " + value[3];
            }
        }

        public int[] DefinitionLocation
        {
            get { return definitionLocation; }
            set
            {
                if (value.Length != 4) throw new Exception("DefinitionLocation should consist of 4 elements");
                definitionLocation = value;
                definitionLocationBox.Text = value[0] + " " + value[1] + " " + value[2] + " " + value[3];
            }
        }

        public RelationsList Relations
        {
            get { return relations; }
            set
            {
                relations = value;
                if (value.Count > 0)
                {
                    foreach (KeyValuePair<Relation, List<Termin>> relation in value)
                    {
                        relationsBox.Text += relation.Key.Name + ": ";
                        foreach (Termin val in relation.Value)
                        {
                            LinkLabel link = new LinkLabel();
                            link.Text = val.Descriptor;
                            link.LinkClicked += new LinkLabelLinkClickedEventHandler(this.Link_LinkClicked);
                            LinkLabel.Link data = new LinkLabel.Link();
                            data.LinkData = val.ID;
                            link.Links.Add(data);
                            link.AutoSize = true;
                            link.Location =
                                this.relationsBox.GetPositionFromCharIndex(this.relationsBox.TextLength);
                            this.relationsBox.Controls.Add(link);
                            this.relationsBox.AppendText(link.Text);
                            this.relationsBox.SelectionStart = this.relationsBox.TextLength;
                            relationsBox.Text += ", ";
                        }
                    }
                }
            }
        }

        public List<Link> Links
        {
            get { return links; }
            set
            {
                links = value;
                if (value.Count > 0)
                {
                    value.Sort((x, y) => x.StartChar.CompareTo(y.StartChar));
                    foreach (Link link in value)
                    {
                        LinkLabel linkLabel = new LinkLabel();
                        //linkLabel.Text = link.Descriptor;
                        linkLabel.Text = definitionBox.Text.Substring(link.StartChar, definitionBox.Text.IndexOf(' ', link.StartChar) - link.StartChar);
                        linkLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(this.Link_LinkClicked);
                        LinkLabel.Link data = new LinkLabel.Link();
                        data.LinkData = link.DescriptorID;
                        linkLabel.Links.Add(0, link.Descriptor.Length, data.LinkData);
                        linkLabel.AutoSize = true;
                        linkLabel.Location =
                            this.definitionBox.GetPositionFromCharIndex(link.StartChar + 2);
                        this.definitionBox.Controls.Add(linkLabel);
                        string sub2 = definitionBox.Text.Substring(link.StartChar, definitionBox.Text.IndexOf(' ', link.StartChar) - link.StartChar);
                        string sub3 = definitionBox.Text.Substring(definitionBox.Text.IndexOf(' ', link.StartChar));
                        definitionBox.Text = definitionBox.Text.Substring(0, link.StartChar) + " " + sub2 + " " + sub3;
                    }
                }
            }
        }

        //public List<Link> Links
        //{
        //    get { return links; }
        //    set
        //    {
        //        linkLabel1.Text = definitionBox.Text;
        //        value.Sort((x, y) => x.StartChar.CompareTo(y.StartChar));
        //        foreach (Link link in value)
        //        {
        //            //linkLabel1.LinkArea = new LinkArea(link.StartChar, link.Descriptor.Length);
        //            LinkLabel.Link data = new LinkLabel.Link();
        //            data.LinkData = link.DescriptorID;
        //            linkLabel1.Links.Add(link.StartChar, link.Descriptor.Length, data.LinkData);
        //        }
        //        linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.Link_LinkClicked);
        //    }
        //}

        private void Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Termin termin;
            DBQueries db = new DBQueries();
            termin = db.GetTermin(Convert.ToInt32(e.Link.LinkData));
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
                    Relations = termin.Relations,
                    Links = def.Links
                };

                TerminViewForm tvf = new TerminViewForm();
                tvf.AddControl(tc);
                tvf.Show();
            }
            
        }


        public TerminControl()
        {
            InitializeComponent();
        }

    }
}
