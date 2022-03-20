#include <stdio.h>
void main()
{
 int a,d,n,i;
 long x,sum;
 sum=/**/0   /**/;
 printf("a,d,n=");
 scanf("%d,%d,%d",&a,&d,&n);
 printf("Series of Numbers:\n");
 x=a;
 for(i=1; i<=/**/n   /**/; i++)
   {
    printf("%d  ",x);
	x=/**/x+d      /**/;
    sum+=x;
   }
 printf("\n Sum=%ld\n",sum);
 getch( );
}
