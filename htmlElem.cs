class htmlElem
{
	static int curId=0;
	int id;
	string type;
	string value;
	public List<htmlElem> childs;
	Dictionary<string, string> properties;
	Dictionary<string, string> style;
	public htmlElem(string type,string value="")
	{
		id = curId++;
		style = new Dictionary<string, string>();
		properties = new Dictionary<string, string>();
		childs = new List<htmlElem>();
		this.value = value;
		this.type = type;
	}
	public void addChild(htmlElem e)
	{
		childs.Add(e);
	}
	public void removeChild(htmlElem e)
	{
		childs.Remove(e);
	}
	public string toHTML()
	{
		string ret = "";
		ret += "<" + type + propertiesToString() +">\r\n";
		ret += value;
		foreach(htmlElem c in childs){
			ret += c.toHTML();
		}
		ret += "</" + type + ">\r\n";
		return ret;
	}
	public void removeProperty(string name)
	{
		properties.Remove(name);
	}
	public void removeStyle(string name)
	{
		style.Remove(name);
	}
	public string getProperty(string name)
	{
		return properties[name];
	}
	public void addProperty(string name,string value)
	{
		properties[name] = value;
	}
	public void addStyle(string name, string value)
	{
		style[name] = value;
	}
	public string getStyle(string name)
	{
		return style[name];
	}
	string propertiesToString()
	{
		string ret = "";
		foreach(KeyValuePair<string, string> p in properties){
			ret += " "+p.Key + "=\"" +p.Value+"\"";
		}
		return ret;
	}
	public string styleToString()
	{
		string ret = "";

		ret += "#" + id + "{\r\n";
		foreach (KeyValuePair<string, string> p in style)
		{
			ret += "\t"+p.Key + ":" + p.Value + ";\r\n";
		}
		ret += "}\r\n";
		foreach (htmlElem c in childs)
		{
			ret += c.styleToString();
		}
		return ret;
	}
}
