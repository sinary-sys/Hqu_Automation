#include <stdio.h>
#include <conio.h>

void fun(int x)
{ int /**/  i /**/, flag=0;
  for(i=2; i<=x/2; i++)
    if(x%i==0)
    { printf("%4d  ",i);
      flag=1;
    }
  if(flag==/**/0   /**/)
    printf("%d is a prime number.\n",x);
}

void main()
{ int a;
  printf("Input a number (must be >0): ");
  scanf("%d",&a);
  while(a<=0)
  { printf("Input a number (must be >0): ");
    scanf("%d",&a);
  }
  fun(/**/ a  /**/);
  getch();
}
