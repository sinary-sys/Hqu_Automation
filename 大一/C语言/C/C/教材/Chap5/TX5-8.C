#include <stdio.h>
void main()
{
	int score;
	char grade;
	printf("Input the score of the student: ");
	do {
		scanf("%d",&score);
	}while (score<0||score>100);
	switch (score/10)
	{
		case 9:
		case 10:	grade='A';break;
		case 8: 	grade='B';break;
		case 7:		grade='C';break;
		case 6:		grade='D';break;
		default:	grade='E';
	}
	printf("The student gets %c grade.\n",grade);
}