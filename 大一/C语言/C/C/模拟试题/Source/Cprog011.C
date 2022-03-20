#include <math.h>
#include <stdio.h>
double fun1(double x)
{ /**/


	return (sin(x)+tan(x)+log(10))/(1.5+fabs(x));
  /**/
}
void main()
{
  clrscr();
  printf("fun1(0.85) = %6.3lf\n", fun1(0.85));
  printf("fun1(4.00) = %6.3lf\n", fun1(4.00));
  printf("fun1(6.76) = %6.3lf\n", fun1(6.76));
  getch();
}
