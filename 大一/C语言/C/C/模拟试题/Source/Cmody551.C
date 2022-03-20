#include <stdio.h>
#include <conio.h>
void main()
{
  int/* i,num[100];*/i,num[100],count;
  count=0 ;
  for( i=100;i<=500;i++ )
    if( /*i%5 =0 && i%7=0 */i%5==3 && i%7==2)
	{ 
        /*num[i]=i;*/num[count]=i;
		count++;
	}   
  for(i=0; i<count;i++)
    printf("%5d", num[i]); 
  
  getch();
}
