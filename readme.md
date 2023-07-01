这些nuget包均是基于从网络上收集的免费api打包的，零基础小白可以直接调用，有一些服务可能不稳定

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
