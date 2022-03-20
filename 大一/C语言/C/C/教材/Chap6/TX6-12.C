#include <stdio.h>
void main()
{
	int num,div,sum;
	for (num=2;num<1000;num++)
	{
		sum=1;
		for (div=2;div*div<num;div++)
			if (num%div==0) sum+=div+num/div;
		if (div*div==num) sum+=div;
		if (num==sum) printf("%3d is a perfect number.\n",num);
	}
}