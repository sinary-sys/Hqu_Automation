#include <stdio.h>
#include <conio.h>
void main()
{ int i,gw,sw,bw;
  for(i=100; /**/ i<1000       /**/; i++)
  { bw=i/100;
    sw=/**/ (i-bw*100)/10;              /**/
    gw= i % 10 ; 
    if(gw==3 || sw==3 || bw==3) 
	if(/**/gw==5 || sw==5 || bw==5 /**/)
              printf("%5d",i);
	}
   getch();
}
