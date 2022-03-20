#include <stdio.h>
#include <conio.h>

int prime(int x)
{ int i,mark=1;
  for(i=2;i<=x/2;i++)
	if(/* x%i=0 */x%i==0)
    { mark=0;
      break;
    }
  return mark;
}

int main()
{  int /**/ n,a,b /**/;
   do
   {
      printf("Input even number( number>=6 ):");
      scanf("%d",&n);
   }while(n%2==1 || n<6);
   for(a=2;a<n;a++)
   {  b=/* n+a */n-a;
      if( prime(a)*prime(b)==1 )
      {  printf("%d+%d=%d\n",a,b,n);
	 break;
      }
   }
   getch();
   return 0;
}
