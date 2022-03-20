#include <stdio.h>
void main()
{
	float x,y,result;
	char op;
	printf("Enter an expression: ");
	scanf("%f%c%f",&x,&op,&y);
	switch (op)
	{
		case '+': 	result=x+y;break;
		case '-': 	result=x-y;break;
		case '*': 	result=x*y;break;
		case '/': 	if (y) {
						result=x/y;
						break;
					}
					else {
						printf("error: divided by zero!\n");
						exit(1);
					}
		default: printf("Invalid operator.\n");
	}
	printf("%g%c%g=%g\n",x,op,y,result);
}