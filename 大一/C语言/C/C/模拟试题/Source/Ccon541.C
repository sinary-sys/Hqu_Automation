#include <stdio.h>
#include <conio.h>
void main()
{ int i, a1, a2, a3;
  for(/**/i=100         /**/; i<1000 ; i++)
  { a3=i/100;
    a2=(i/10) % 10;
    /**/a1=i%10;           /**/
    if(a1+a2+a3==18)
	printf("%5d", /**/ i  /**/);	 
  }
  getch();
}

