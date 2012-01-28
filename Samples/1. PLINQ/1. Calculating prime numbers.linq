<Query Kind="Statements" />

IEnumerable<int> numbers = Enumerable.Range (3, 1000000);

var query = 
	from n in numbers
	where Enumerable.Range (2, (int) Math.Sqrt (n)).All (i => n % i > 0)
	select n;

int[] primes = query.ToArray();

primes.Take(100).Dump();