#include <stdio.h>
#include <conio.h>
void main()
{
  float x,y; 
  /* int result; */float result;
  printf("\nPlease input x,y: ");
  scanf( "%f%f" ,&x,&y);
  while(/*x==1 && y==1 */x==1 || y==1)
  {
    printf("Error£ºDivided by zero!");
    printf("\nPlease input x,y: ");
    scanf("%f%f",&x,&y);  
   }
  result= (x*x+1)/(x-1)+(y+1)/(y-1);  
  printf("\nResult=%.2f\n",result);
  getch();
}
