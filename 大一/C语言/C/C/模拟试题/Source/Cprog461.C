#include <stdio.h>
double fun(float x)
{/**/
	if (x<0) return x-1;
	else if (x>0) return x+1;
	else return 0;





 /**/
}

void main()
{ 
  float x;
  printf("Input x :");
  scanf("%f",&x);
  printf("fun(%.3f)=%.3lf\n",x,fun(x));
  getch();
}