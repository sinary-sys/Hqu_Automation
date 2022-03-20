#include <stdio.h>
void main()
{
	int score;
	printf("Input the score of the student: ");
	scanf("%d",&score);
	if (score>=90 && score<=100) printf("Score: A\n");
	else if (score>=80 && score<90) printf("Score: B\n");
	else if (score>=70 && score<80) printf("Score: C\n");
	else if (score>=60 && score<70) printf("Score: D\n");
	else if (score>=0 && score<60) printf("Score: E\n");
	else printf("Invalid score!\n");
}