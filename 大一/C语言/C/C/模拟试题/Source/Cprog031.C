#include <stdio.h>
#include <math.h>
double fun1(float x)
{
 /**/


	double y;
	y=12.5;
	if (x<5)
		y=exp(x)+0.9;
	else
	if (x>5)
		y=(sin(x)-7.8)/(2*x);
	return y;

 /**/
}

void main()
{
  float x;
  double y;
  clrscr();
  printf("Please input a number:\n");
  scanf("%f",&x);
  y = fun1(x);
  printf("fun1(%.2f)=%.2f\n",x,y);
  getch();
}
