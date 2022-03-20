#include <stdio.h>
float average(int grade[],int n)
{
	int i,total=0;
	for (i=0;i<n;i++) total+=grade[i];
	return (float)total/n;
}
void main()
{
	int grade[]={80,72,96,58,64,76};
	printf("The average score of the students is %.2f\n",
	average(grade,sizeof(grade)/sizeof(int)));
}