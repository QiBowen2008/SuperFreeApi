# Saying Maker����Ϊ���Ӧ�ó������������� #
## ʹ��ʾ�� ##


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
## Ч�� ##

![](https://raw.github.com/QiBowen2008/SuperFreeApi/main/SayingMaker/1.jpg)
