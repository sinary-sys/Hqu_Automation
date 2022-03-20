#include <stdio.h>
#include <conio.h>
#include <math.h>

double fun(float x)
{ /**/

	if (x>0) return x;
	else if (x<0) return sqrt(1+x*x);
	else return 0;


 /**/
}

int main()
{
  printf("fun(0.58)=%lf\n",fun(0.58));
  printf("fun(0)=%lf\n",fun(0));
  printf("fun(-1.5)=%lf\n",fun(-1.5));
  getch();
  return 0;
}