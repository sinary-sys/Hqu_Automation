#include <stdio.h>
#include <math.h>
void main()
{  int s;
   float n,t,pi;
   s=/**/1  /**/ ;
   pi=0;
   t=n=1.0;
   while (fabs(t)>=1e-5)
   {
     pi=pi+t;
	 n+=/**/2     /**/;
	 s=/**/-s    /**/;
     t=s/n;
   }
   pi=pi*4;
   printf("pi=%f\n",pi);
   getch();
}
