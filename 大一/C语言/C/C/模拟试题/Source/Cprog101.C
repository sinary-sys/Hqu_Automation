#include <stdio.h>
#include <math.h>
void fun(double a[],double x,int n)
{
 /**/
	double y;
	y=(2*n+1)*pow(x,n)/(n*(n+1));
	a[0]=y;
	a[1]=y-(int)y;


 /**/
}

main()
{
   int n;
   double a[2],x;
   printf("\nPlease enter x,n:");
   scanf("%lf,%d",&x,&n);
   while(x<1.0 || x>2.0 || n<0 || n>10)
    { printf("\nInvalid data (1.0<=x<=2.0,0<n<=10)\n\nPlease enter x,n:");
     scanf("%lf,%d",&x,&n);
     }
   fun(a,x,n);
   printf("\nResult: a[0]=%f,a[1]=%f",a[0],a[1]);
   getch();
}

