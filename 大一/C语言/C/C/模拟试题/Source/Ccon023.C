#include <stdio.h>
#include <conio.h>
int prime(int n)
{ int k,flag=1;
  for(k=2; k<=n/2+1; k++)
	if (n%k==0) { flag=/**/0   /**/ ; break;}
  return flag;
}
void main()
{ int num, a;
  clrscr();
  do
  { printf("Please input an even number:");
    scanf("%d", &num);
  }while(num<=6||num%2==1);
  for(a=2;a<=num/2+1;a++)
  if(prime(a) && prime(/**/num-a       /**/))
    printf("\n %d = %d + %d ", num, a, num-a);
}

