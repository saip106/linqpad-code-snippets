<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	Task task = Task.Factory.StartNew (
		() => GetPrimes().Dump()
	);
}

int GetPrimes()
{
	var query =
		from n in Enumerable.Range (3, 5000000).AsParallel()
		where Enumerable.Range (2, (int) Math.Sqrt (n)).All (i => n % i > 0)
		select n;		

	return query.Count();
}
