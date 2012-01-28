<Query Kind="Program">
  <GACReference>Microsoft.VisualStudio.QualityTools.UnitTestFramework, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a</GACReference>
  <Namespace>Microsoft.VisualStudio.TestTools.UnitTesting</Namespace>
</Query>

void Main()
{
		TestedClass testedClass = new TestedClass();
		PrivateObject privateObject = new PrivateObject(testedClass);
	bool result = (bool)privateObject.Invoke("PrivateMethod",BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.InvokeMethod | BindingFlags.IgnoreCase | BindingFlags.IgnoreReturn, string.Empty);
}

// Define other methods and classes here
public class TestedClass
{
	private bool privateField = true;
   
	private bool PrivateMethod(string test)
	{
		return privateField;
	}
}

