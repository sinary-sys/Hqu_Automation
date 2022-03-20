#include <stdio.h>
void main()
{
   double x;int n;
   double fun(double x,int n);
   printf("Please enter x,n:");
   scanf("%lf%d",&x,&n);
   printf("fun=%lf\n",fun(x,n));
   getch();
}

double fun(double x,int n)
{ /**/

	if (n==0)
		return 1;
	if (n==1)
		return x;
	if (n>1)
		return ((2*n-1)*x-fun(x,n-1)-(n-1)*fun(x,n-2))/n;




  /**/
}
