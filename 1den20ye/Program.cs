Console.WriteLine(num(new int [] { 1, 3, 55, 6, 33}));

int num (int[] n)
{int product = 1;
	foreach (var i in n)
	{
		if ((i >= 1) && (i <= 20))
		{
            product *= i;
        }
    }
	return product;
}

