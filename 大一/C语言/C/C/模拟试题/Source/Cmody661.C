#include<stdio.h>
#include<conio.h>
int main()
{   int  x, /* i=1 */i=0, j;
    char a[16];
    do{
      printf("Enter a decimal positive number:");
      scanf("%d", &x);
    }while(x<=0);
    while(x!=0)
	{  a[i]='0'+ /* x%2 */x%8;
	   /* i-- */i++;
       x=x/8;
   }
   printf("Octal number is :");
   for(j=i-1;j>=0; j--)  putchar(a[j]);
   putchar('\n');
   getch();
   return 0;
}

