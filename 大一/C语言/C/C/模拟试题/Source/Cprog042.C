#include <stdio.h>
double f(double k,int n)
{ double t=0;
  /**/
	int i,sign=1;
	for (i=1;i<=n;i++)
	{
		t=t+1.0/(i*(i+1))*sign;
		sign=-sign;
	}
	t=t*k;
  /**/
  return (t);
}
void main()
{  double sum;
   sum=f(5.36,9);
   printf("f(5.36,9)= %.3lf\n ",sum);
   getch();
}

