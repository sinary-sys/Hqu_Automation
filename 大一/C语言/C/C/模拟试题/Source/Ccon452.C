#include <stdio.h>
void lookup( int y )
{
 int a,b,c;
 for(/**/a=1     /**/; a<10; a++)
	for(b=1; b<10; /**/ b++    /**/)
      for(c=1; c<10; c++)
        {
		 if(a*b+/**/b*c+a*c       /**/ ==y)
            printf("a=%d,b=%d,c=%d\n",a,b,c);
        }
}

void main()
{
 int result=95;
 lookup(result);
 getch();
}
