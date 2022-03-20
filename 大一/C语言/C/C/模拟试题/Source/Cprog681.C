#include <stdio.h>
#include <conio.h>
#include <math.h>

double fun(float x)
{ /**/

	return (0.723+log(3*x))/(fabs(x-0.17)+0.5);

 /**/
}

int main()
{
  printf("\nfun(%.3f) = %.3lf\n",0.106,fun(0.106));
  getch();
  return 0;
} 