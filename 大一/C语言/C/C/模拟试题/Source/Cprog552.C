#include <stdio.h>
#include <conio.h>
double fun(int n)
{ /**/

	int i;
	double numerator=1.0,denominator=1.0,sum=.0;

	for (i=1;i<=n;i++)
	{
		sum+=numerator/denominator;
		numerator=-numerator;
		denominator+=3;
	}

	return sum;
  /**/
}

void main()
{ int n;
  printf("Input n(n>=0): ");
  scanf("%d",&n);
  printf("fun(%d)=%f\n ",n,fun(n));
  getch();
}

