#include <stdio.h>
void main()
{ int n;
  /**/void PrintLetters(int n);                    /**/
  printf("Please input n (n>=1 and n<=10) :");
  scanf("%d",&n);
  if( !(n>=1&&n<=10) )  return;
  PrintLetters(n);
  getch();
}

void PrintLetters(int n)
{
  char ch='a';
  int  row,col;
  for(row=1;row<=n;row++)
  {
	for(col=1;/**/col<=row              /**/;col++)
        putchar(ch);
	/**/ch++;        /**/
    printf("\n");
  }
}


