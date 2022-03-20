#include <stdio.h>
void main()
{
  int i,counter=/* 1 */0;
  for(i=100;i<=200;i++)
	if( /* (i%3)&&(i%5) */!(i%3)&&!(i%5) )
    {
      printf("%-5d",i);
      counter++;
    }
  printf("\ncounter=%d\n",counter);
  getch();
}







