#include<stdio.h>
/* my_add(int n) */
double my_add(int n)
{
 double sum = 0.0;
 int i;
 for(i=1;i<=n;i++)
   {
	sum+=(2*i-1)/(2+/* 3*i */3.0*i);
   }
 return (/* 0 */sum);
}

void main()
{
 printf("my_add(9) = %11.5lf\n", my_add(9));
 getch();
}