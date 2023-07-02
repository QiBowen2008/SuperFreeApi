以下Api均为网络上的公益项目，在此为方便小白操作进行打包，直接用“对象.方法”即可调用，无需WebRequest

nuget地址：[](https://www.nuget.org/profiles/Qibowen2008)

主要Api源头：https://api.aa1.cn  

https://api.axtn.net/zh_cn



# Saying Maker——为你的应用程序添加随机名言 #
## 使用示范 ##


    using System;
	using SayingMaker;
	using System.Windows.Forms;

	namespace Test
	{
    	public partial class Form1 : Form
    	{
        	public Form1()
        	{
            	InitializeComponent();
        	}

        	private void Form1_Load(object sender, EventArgs e)
        	{
            	textBox1.Text = Maker.GetSaying();
        	}
    	}
	}
## 效果 ##

![](https://raw.github.com/QiBowen2008/SuperFreeApi/main/SayingMaker/1.jpg))

# IPSearch——使你的应用程序拥有IP查询功能
功能：查询IP地址的位置，ans编号，服务器经纬度，运营公司。

## 使用示范： ##

    using System;
	using System.Windows.Forms;

	namespace DLLtest
	{
    	public partial class Form1 : Form
    	{
    	    public Form1()
    	    {
    	        InitializeComponent();
    	    }
	
	
    	    private void button1_Click(object sender, EventArgs e)
    	    {
    	        string ip = textBox1.Text;
    	        textBox2.Text = SuperFreeApi.IPSearch.IPSearch.GetIPregion (ip);
    	        textBox3.Text = SuperFreeApi.IPSearch.IPSearch.GetIPlatitude(ip);
    	        textBox4.Text = SuperFreeApi.IPSearch.IPSearch.GetIPlongitude(ip);
    	        textBox5.Text = SuperFreeApi.IPSearch.IPSearch.GetIPasn(ip);
    	        textBox6.Text = SuperFreeApi.IPSearch.IPSearch.GetIPLLC(ip);
    	    }
    	}
	}	

## 效果： ##

![](https://raw.github.com/QiBowen2008/SuperFreeApi/main/IPSearch/%E6%8D%95%E8%8E%B7.PNG)

# WeatherReporetr——为你的应用程序嵌入天气预报 #

功能：输入市级行政区或县级行政区全民，即可获取查询天气

## 使用示范 ##

界面效果：

![](https://raw.github.com/QiBowen2008/SuperFreeApi/main/WeatherReporter/1.PNG)

C#代码

    using System;
	using SuperFreeApi.WeatherReporter;
	using System.Windows.Forms;

	namespace DLLtest
	{
    	public partial class Form1 : Form
    	{
        	public Form1()
        	{
           	 	InitializeComponent();
        	}


        	private void button1_Click(object sender, EventArgs e)
        	{
            	string city = textBox1.Text;
            	textBox2.Text = WeatherReporter.GetProvince(city);
            	textBox3.Text = WeatherReporter.GetWeather(city);
            	textBox4.Text = WeatherReporter.GetTemperature(city);
            	textBox5.Text = WeatherReporter.GetWindDirection(city);
            	textBox6.Text = WeatherReporter.GetWindPower(city);
            	textBox7.Text = WeatherReporter.GetHumidity(city);
            	textBox8.Text = WeatherReporter.GetReporttime(city);
        	}


    	}
	}

VB.NET代码

    Imports SuperFreeApi.WeatherReporter
	Public Class Form1
    	Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        	Dim city As String = textBox1.Text
        	textBox2.Text = WeatherReporter.GetProvince(city)
        	textBox3.Text = WeatherReporter.GetWeather(city)
        	textBox4.Text = WeatherReporter.GetTemperature(city)
        	textBox5.Text = WeatherReporter.GetWindDirection(city)
        	textBox6.Text = WeatherReporter.GetWindPower(city)
        	textBox7.Text = WeatherReporter.GetHumidity(city)
        	textBox8.Text = WeatherReporter.GetReporttime(city)
    	End Sub
	End Class

# XinHuaDictionary——给你的程序内嵌在线字典 #
## 使用示范 ##

C#代码

	using System;
	using SuperFreeApi.XinHuaDictionary;
	using System.Windows.Forms;

	namespace DLLtest
	{
	    public partial class Form1 : Form
	    {
	        public Form1()
	        {
	            InitializeComponent();
	        }
	
	        private void button1_Click(object sender, EventArgs e)
	        {
	            string character = textBox1.Text;
	            textBox2.Text = Dictionary.GetCharacterbs (character);
	            textBox3.Text = Dictionary.GetCharacteryj (character);
	            textBox4.Text = Dictionary.GetCharacterbsbh (character);
	            textBox5.Text = Dictionary.GetCharacterbwbh (character);
	            textBox6.Text = Dictionary.GetCharacterzsbh  (character);
	            textBox7.Text = Dictionary.GetCharacterbsxf (character);
	        }
	    }
	}

VB.NET代码

    Imports SuperFreeApi.XinHuaDictionary

	Public Class Form1
    	Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
    	    Dim character As String = textBox1.Text
    	    textBox2.Text = Dictionary.GetCharacterbs(character)
    	    textBox3.Text = Dictionary.GetCharacteryj(character)
    	    textBox4.Text = Dictionary.GetCharacterbsbh(character)
    	    textBox5.Text = Dictionary.GetCharacterbwbh(character)
    	    textBox6.Text = Dictionary.GetCharacterzsbh(character)
    	    textBox7.Text = Dictionary.GetCharacterbsxf(character)
    	End Sub
	End Class

效果

![](https://raw.github.com/QiBowen2008/SuperFreeApi/main/XinHuaDictionary/1.PNG)

# CyDictionary——成语词典模块 #

功能：查询成语解释，用法，辨析（仅限部分），造句，出处

## 使用示范 ##

界面：

![](https://raw.github.com/QiBowen2008/SuperFreeApi/main/Cydictionary/1.PNG)

C#代码

    using System;
	using SuperFreeApi.CyDictionary;
	using System.Windows.Forms;

	namespace DLLtest
	{
    	public partial class Form1 : Form
    	{
    	    public Form1()
    	    {
    	        InitializeComponent();
    	    }
	
    	    private void button1_Click(object sender, EventArgs e)
    	    {
    	        string Cy = textBox1.Text;
    	        textBox2.Text = Dictionary.Getcyjs(Cy);
    	        textBox3.Text = Dictionary.Getcyzj(Cy);
    	        textBox4.Text = Dictionary.Getcycc(Cy);
    	        textBox5.Text = Dictionary.Getcybx(Cy);
    	        textBox6.Text = Dictionary.Getcysy(Cy);
    	    }
    	}
	}

VB.NET代码

    Imports SuperFreeApi.CyDictionary

	Public Class Form1
    	Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
    	    Dim Cy As String = textBox1.Text
    	    textBox2.Text = Dictionary.Getcyjs(Cy)
    	    textBox3.Text = Dictionary.Getcyzj(Cy)
    	    textBox4.Text = Dictionary.Getcycc(Cy)
    	    textBox5.Text = Dictionary.Getcybx(Cy)
    	    textBox6.Text = Dictionary.Getcysy(Cy)
    	End Sub
	End Class
