#include <stdio.h>
 void main(void) {
	float score[5][3],aver[5]={0},highest;
	int i,j;
	printf("Enter the scores of students: \n");
	for (i=0;i<5;i++)
	{
		for (j=0;j<3;j++)
		{
			scanf("%f",&score[i][j]);
			aver[i]+=score[i][j];
		}
		aver[i]/=3.0;
	}
	highest=aver[0];
	for (i=1;i<5;i++)
		if (aver[i]>highest) highest=aver[i];
	printf("The highest average score is %.2f\n",highest);
}