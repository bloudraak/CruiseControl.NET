using System;
using System.Configuration;
using System.Collections;
using System.Xml;
using System.IO;
using System.Text;

namespace tw.ccnet.web
{
	public class ProjectPluginsSectionHandler : IConfigurationSectionHandler
	{
		public object Create(object parent, object configContext, System.Xml.XmlNode section)
		{
			ArrayList projectPlugins = new ArrayList();
			
			foreach (XmlNode node in section.ChildNodes) 
			{
				if (node.NodeType == System.Xml.XmlNodeType.Element) 
				{
					projectPlugins.Add(new ProjectPluginSpecification(node.Attributes["linkText"].Value, node.Attributes["linkUrl"].Value));
				}
			}

			return projectPlugins;
		}
	}
}
