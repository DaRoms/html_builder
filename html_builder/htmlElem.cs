using System.Collections.Generic;
using System.Windows.Forms;
class htmlElem
{
	static int curId=0;
	int id;
	string type;
	string value;
	public List<htmlElem> childs;
	Dictionary<string, string> properties;
	Dictionary<string, string> style;
	public Control control;


	private void createControl(){
		if (type.ToLower () == "button") {
			control = new Button ();
		}
	}
	public void updateControl(){

		int width = changeToCoords(getProperty ("width"));
		if (width != 0) {
			control.Width = width;
		}
		int height = changeToCoords(getProperty ("height"));
		if (height != 0) {
			control.Height = height;
		}
		int top = changeToCoords(getProperty ("top"));
		if (top != 0) {
			control.Top = top;
		}
		int left = changeToCoords(getProperty ("left"));
		if (left != 0) {
			control.Left = left;
		}

		control.Text = value;

	}
	//Changes string "500px" to int 500
	private int changeToCoords(string s){
		if (s != null && s.Length > 2) {
			return int.Parse (s.Substring (0, s.Length - 2));
		}		
		return 0;
	}



	public htmlElem(string type,string value="")
	{
		id = curId++;
		style = new Dictionary<string, string>();
		properties = new Dictionary<string, string>();
		childs = new List<htmlElem>();
		this.value = value;
		this.type = type;
		createControl ();
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
		properties.Remove(name.ToLower());
	}
	public void removeStyle(string name)
	{
		style.Remove(name.ToLower());
	}
	public string getProperty(string name)
	{
		if (properties.ContainsKey (name)) {
			return properties [name].ToLower ();
		}
		else
			return null;
	}
	public void addProperty(string name,string value)
	{
		properties[name.ToLower()] = value.ToLower();
	}
	public void addStyle(string name, string value)
	{
		style[name.ToLower()] = value.ToLower();
	}
	public string getStyle(string name)
	{
		if (style.ContainsKey (name.ToLower()))
			return style [name].ToLower ();
		else
			return null;
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
