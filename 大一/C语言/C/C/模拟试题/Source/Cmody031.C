#include <stdio.h>
#include <conio.h>
void main()
{ int m,n,result,flag=0;
 /* char ch, */
  char ch;
  clrscr();
  printf("Input an expression: ");
  scanf("%d%c%d",&m,&ch,&n);
 /* switch ch */
  switch (ch)
  { case '+': result=m+n; break;
    case '-': result=m-n; break;
    case '*': result=m*n; break;
    case '%': result=m%n; break;
    case '/': result=m/n; break;
    default: { printf("Error!\n"); flag=1; }
  }
  if (!flag) printf("%d %c %d = %d\n",m,ch,n,result);
  getch();
}