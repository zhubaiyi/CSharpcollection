/*
 * 由SharpDevelop创建。
 * 用户： jinkows
 * 日期: 2012-03-13
 * 时间: 8:32
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System ;

class RandomNumberClass
{
	private static Random randomKey;
	int num;
	static RandomNumberClass ()
	{
		randomKey =new Random ();
		//num=10;   //error
	}
	
	public void ShowRandomNumber()
	{
		//return randomKey.Next();
		Console .WriteLine ("Next Random Number:{0}",randomKey.Next() );
	}
	
	
}

class Test
{
	static void Main()
	{
		RandomNumberClass a =new RandomNumberClass ();
		RandomNumberClass b=new RandomNumberClass ();
		a.ShowRandomNumber ();
		b.ShowRandomNumber ();
		
	}
}
