#include <stdio.h>
#define N 10
void main()
{
	float score[N],total=.0f;
	int i,highindex,lowindex;
	printf("Enter the score of the students: ");
	for (i=0;i<N;i++)
	{
		scanf("%f",&score[i]);
		total+=score[i];
	}
	highindex=lowindex=0;
	for (i=1;i<N;i++)
	{
		if (score[i]>score[highindex])
			highindex=i;
		if (score[i]<score[lowindex])
			lowindex=i;
	}
	printf("The average score is %.2f\n",total/N);
	printf("The highest score is %.2f and its enter order is %d\n",
	score[highindex],highindex+1);
	printf("The lowest score is %.2f and its enter order is %d\n",
	score[lowindex],lowindex+1);
}