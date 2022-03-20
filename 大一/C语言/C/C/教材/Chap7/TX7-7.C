#include <stdio.h>
void main()
{
	int score[5][3],i,j;
	float C_total=.0f,DS_total=.0f,SE_total=.0f;
	printf("Input the three course scores of five students: \n");
	for (i=0;i<5;i++)
		for (j=0;j<3;j++)
			scanf("%d",&score[i][j]);
	for (i=0;i<5;i++)
	{
		C_total+=score[i][0];
		DS_total+=score[i][1];
		SE_total+=score[i][2];
	}
	printf("The average score of C is %.2f\n",C_total/5.0f);
	printf("The average score of Data Structure is %.2f\n",DS_total/5.0f);
	printf("The average score of Software Engineering is %.2f\n",SE_total/5.0f);
}