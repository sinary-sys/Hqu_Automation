#include <stdio.h>
#include <math.h>
unsigned int prime(unsigned int x )
{
 unsigned int mark=1,i;
 for(/* i=1 */i=2;i<sqrt(x);i++)
   if(x%i==0)
     {
      mark=0;
      break;
     }
 return (mark);
}
void main()
{
 unsigned int n,m,a,b;
 printf("Input n: ");
 scanf("%d",&n);
 if(n<11 || n>99)
    printf("%d is error!\n",n);
 else
    {
/**/ a=n/10 /**/;
     b=n/10;
     m=a*10+b;
	 if( /* prime(n)=0 */ prime(n)==1 && prime(m)==1 )
        printf("Yes!\n");
     else
        printf("No!\n");
    }
 getch();
}
