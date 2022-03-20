#include <stdio.h>
#include <math.h>
int fun(/**/float r         /**/,float x,float y)
{
  int bIn;
  bIn = /**/ sqrt(x*x+y*y)               /**/ < r ;
  return  bIn;
}

main()
{
   float r=-1,x,y;
   int bIn;
   while(r<0)
   { printf("Please input radius r (r>0):\n");
     scanf("%f", &r);
   }
   printf("Please input the dot(x,y):\n");
   scanf("%f%f",&x,&y);
   bIn = fun(r,x,y);
   if(bIn == 1)
     printf("in the circle!\n");
   else
     printf("out of the Circle!\n");
   getch();
}