#include <stdio.h>
void main()
{
	int score[2][5][2];
	int i,j,k,sum=0;

	printf("Input the score of the students: \n");
	for (i=0;i<2;i++)
		for (j=0;j<5;j++)
			for (k=0;k<2;k++)
			{
				scanf("%d",&score[i][j][k]);
				sum+=score[i][j][k];
			}
	printf("The average score is %.2f\n",sum/20.0);
}