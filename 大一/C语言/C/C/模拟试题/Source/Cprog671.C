#include <stdio.h>
#include <conio.h>
#include <math.h>

double fun(float x)
{ /**/

	if (x<1) return x;
	else if (x<5) return 3.2+1.1*x;
	else return log(x);


 /**/
}

int main()
{
  printf("fun(0.27)=%lf\n",fun(0.27));
  printf("fun(4.3)=%lf\n",fun(4.3));
  printf("fun(6.9)=%lf\n",fun(6.9));
  getch();
  return 0;
}

