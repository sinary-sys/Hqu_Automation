#include <stdio.h>
float average(int grade[],int n)
{
	if (n==1) return grade[0];
	else return (average(grade,n-1)*(n-1)+grade[n-1])/n;
}
void main()
{
	int grade[]={80,72,96,58,64,76};
	printf("The average score of the students is %.2f\n",
	average(grade,sizeof(grade)/sizeof(int)));
}