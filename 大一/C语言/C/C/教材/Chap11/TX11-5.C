#include <stdio.h>
void main(void) {
	struct employee {
		int EId;
		char name[20];
		char tel[12];
		float salary;
	}emp[3];

	int i;
	for (i=0;i<3;i++) {
		printf("Input Employee's Eid: ");
		scanf("%d",&emp[i].EId);
		printf("Input Employee's name: ");
		scanf("%s",emp[i].name);
		printf("Input Employee's Tel: ");
		scanf("%s",emp[i].tel);
		printf("Input Employee's salary: ");
		scanf("%f",&emp[i].salary);
	}

	printf("Eid\tname\ttel\t\tsalary\n");
	for (i=0;i<3;i++) {
		printf("%d\t%s\t%s\t%.2f\n",emp[i].EId,emp[i].name,
					emp[i].tel,emp[i].salary);
	}
}