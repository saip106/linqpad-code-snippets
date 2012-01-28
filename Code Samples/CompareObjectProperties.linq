<Query Kind="Program" />

void Main()
{
	
}

public bool PropertiesEqual(object comparisonObject)
{

	Type sourceType = this.GetType();
	Type destinationType = comparisonObject.GetType();

	if (sourceType == destinationType)
	{
		PropertyInfo[] sourceProperties = sourceType.GetProperties();
		foreach (PropertyInfo pi in sourceProperties)
		{
			if ((sourceType.GetProperty(pi.Name).GetValue(this, null) == null && destinationType.GetProperty(pi.Name).GetValue(comparisonObject, null) == null))
			{
				// if both are null, don't try to compare  (throws exception)
			}
			else if (!(sourceType.GetProperty(pi.Name).GetValue(this, null).ToString() == destinationType.GetProperty(pi.Name).GetValue(comparisonObject, null).ToString()))
			{
				// only need one property to be different to fail Equals.
				return false;
			}
		}
	}
	else
	{
		throw new ArgumentException("Comparison object must be of the same type.","comparisonObject");
	}

	return true;
}
