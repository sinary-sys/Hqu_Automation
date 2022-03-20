#include <stdio.h>
float fun(float x)
{/**/
	if (x<=1) return 0.05*x;
	else if (x<=3) return 0.5+0.06*(x-1);
	else if (x<=5) return 1+0.07*(x-3);
	else return 2+0.09*(x-5);





 /**/
}

void main()
{ 
  float x;
  printf("Input x :");
  scanf("%f",&x);
  if(x<0)
     printf("%.2f is error!\n",x);
  else
     printf("fun(%.2f)=%.2f\n",x,fun(x));
  getch();
}
