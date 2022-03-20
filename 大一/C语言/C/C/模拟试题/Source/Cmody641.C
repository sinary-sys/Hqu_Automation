#include<stdio.h>
#include<conio.h>
#include <math.h>
int main()
{	int  a,b;
	/*  int  result  */double result;

	do{	printf("Please input 2 positive integers(a and b):");
        	scanf("%d%d",&a,&b);
	}while(a<=0 /*  &&  b<=0  */||b<=0);
	result=sqrt(a)+ /* sprt(b)  */sqrt(b);
	printf("result=%.2f\n",result);
	getch();
	return 0;
}

