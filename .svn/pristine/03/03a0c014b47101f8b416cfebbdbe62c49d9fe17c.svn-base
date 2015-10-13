using System;
using System.Collections.Generic;
using System.Xml;

namespace CW2_OOD
{
    /* Expects an XML file looking a bit like this:

<?xml version="1.0" ?>
<!DOCTYPE course [
    <!ELEMENT course (level*) >
    <!ATTLIST course name CDATA #REQUIRED >

    <!ELEMENT level (module*) >
    <!ATTLIST level level (4|5|6) #REQUIRED >

    <!ELEMENT module (assessment*) >
    <!ATTLIST module code CDATA #REQUIRED >
    <!ATTLIST module name CDATA #REQUIRED >
    <!ATTLIST module credit CDATA #REQUIRED >


    <!ELEMENT assessment EMPTY >
    <!ATTLIST assessment name CDATA #REQUIRED >
    <!ATTLIST assessment mark CDATA "n/a" >
    <!ATTLIST assessment weight CDATA ""n/a"" >
]>
<course name="Computer science" >
    <level level="5">
        <module name="Object Oriented Development" credit="30">
            <assessment name="Coursework 1" mark="100" weight="50"/>
            <assessment name="Coursework 2" mark="100" weight="50"/>
        </module>
    </level>
</course>

     */

    public enum Level
	{
		LEVEL_4 = 4,
		LEVEL_5 = 5,
		LEVEL_6 = 6,
	}

	public class Course
	{
		protected XmlDocument root;
		protected XmlNode coursenode;
		protected XmlNode nameattr;

		public Course(XmlDocument root, XmlNode coursenode)
		{
			this.root = root;
			this.coursenode = coursenode;
			this.nameattr = this.coursenode.Attributes.GetNamedItem("name");
			mergeLevels();
		}

		public string getName()
		{
			return nameattr.Value;
		}

		public void setName(string name)
		{
			nameattr.Value = name;
		}

		protected void mergeLevels()
		{
			/* Merge identical level nodes */
			/* This iterates over every level registered in the Level enum. */
			foreach (Level l in (Level[]) Enum.GetValues(typeof(Level)))
			{
				XmlNode levelnode = null;
				/* Iterate over every level node in the course. */
				List<XmlNode> mergedLevels = new List<XmlNode>();

				foreach (XmlNode ln in coursenode.ChildNodes)
				{
					int level;

					if(!int.TryParse(ln.Attributes.GetNamedItem("level").Value, out level))
					{
						continue;
					}

					if(level == (int)l)
					{
						if(levelnode == null)
						{
							levelnode = ln;
						}
						else
						{
							foreach(XmlNode module in ln.ChildNodes)
							{
								levelnode.AppendChild (module);
							}

							mergedLevels.Add(ln);
						}
					}
				}

				foreach(XmlNode n in mergedLevels)
				{
					coursenode.RemoveChild(n);
				}
			}
		}

		/* Used internally */
		protected XmlNode getLevel(Level l)
		{
			foreach(XmlNode node in coursenode.ChildNodes)
			{
				if(int.Parse(node.Attributes.GetNamedItem("level").Value) == (int)l)
				{
					return node;
				}
			}

			/* No node exists. */
			XmlElement levelnode = root.CreateElement("level");
			XmlAttribute levelattr = root.CreateAttribute("level");
			levelattr.Value = ((int)l).ToString();
			levelnode.Attributes.Append(levelattr);
			coursenode.AppendChild(levelnode);

			return levelnode;
		}

        public int getModuleCount(Level l)
        {
            XmlNode level = getLevel(l);
            return level.ChildNodes.Count;
        }

        public static int sumModuleCredit(Module[] modules)
        {
            int acc = 0;
            foreach (Module m in modules)
            {
                acc += m.getCredit();
            }

            return acc;
        }

        public int sumModuleCredit(Level l)
        {
            return sumModuleCredit(getModules(l));
        }

		public Module[] getModules(Level l)
		{
			int modcount;
			Module[] modlist;
			XmlNode level = getLevel(l);

			modcount = level.ChildNodes.Count;
            modlist = new Module[modcount];

			for(int i = 0; i < modcount; i++)
			{
				modlist[i] = new Module(root, level.ChildNodes[i]);
			}

			return modlist;
		}

		public Module addModule(Level l, string code, string name, int cred)
		{
			Module module;
			XmlNode level = getLevel(l);
			XmlElement modnode;

			modnode = root.CreateElement("module");
            modnode.Attributes.Append(root.CreateAttribute("code"));
			modnode.Attributes.Append(root.CreateAttribute("name"));
            modnode.Attributes.Append(root.CreateAttribute("credit"));
			level.AppendChild (modnode);

			module = new Module(root, modnode);
            module.setCode(code);
			module.setName(name);
            module.setCredit(cred);

			return module;
		}

        public void delModule(Level l, Module module)
        {
            XmlNode level = getLevel(l);
            level.RemoveChild(module.getNode());
        }
	}
}

