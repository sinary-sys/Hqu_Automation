#include <stdio.h>
double fun(float x,float y)
{/**/
	if (x<=0) return x+y;
	else if (y>0) return (x*x+1)/(y*y+2);
	else return (x-2)/(x*(y*y+1));





 /**/  
}

void main()
{ 
  float x,y;
  printf("Input x,y: ");
  scanf("%f,%f",&x,&y);
  printf("fun(%.3f,%.3f)=%.3lf\n",x,y,fun(x,y));
  getch();
}