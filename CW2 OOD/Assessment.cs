using System;
using System.Xml;

namespace CW2_OOD
{
	public class Assessment
	{
		protected XmlNode assessmentnode;
		protected XmlNode nameattr;
		protected XmlNode markattr;
        protected XmlNode weightattr;

		public Assessment(XmlNode assessmentnode)
		{
			this.assessmentnode = assessmentnode;
			this.nameattr = this.assessmentnode.Attributes.GetNamedItem("name");
			this.markattr = this.assessmentnode.Attributes.GetNamedItem("mark");
            this.weightattr = this.assessmentnode.Attributes.GetNamedItem("weight");
		}

        public XmlNode getNode()
        {
            return assessmentnode;
        }

		public void setName(string name)
		{
			nameattr.Value = name;
		}

		public string getName()
		{
			return nameattr.Value;
		}

		public void setMark(int mark)
		{
			markattr.Value = mark.ToString();
		}

		public int getMark()
		{
			int mark;
			if(!int.TryParse (markattr.Value, out mark))
			{
				mark = 0;
			}

			return mark;
		}

        public void setWeight(int weight)
        {
            weightattr.Value = weight.ToString();
        }

        public int getWeight()
        {
            int weight;
            if (!int.TryParse(weightattr.Value, out weight))
            {
                weight = 0;
            }

            return weight;
        }

        public double score()
        {
            return (double)getMark() * ((double)getWeight() / 100.0);
        }
	}
}
