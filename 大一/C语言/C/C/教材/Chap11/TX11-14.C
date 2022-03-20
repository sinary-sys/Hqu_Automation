#include <stdio.h>
void main(void) {
	struct employee {
		int EId;
		char name[20];
		char tel[12];
		float salary;
		char qqOrMsn;
		union online {
			long int qq;
			char msn[30];
		}on;
	}*pemp;
	float temp;
	pemp=(struct employee *)malloc(sizeof(struct employee));
	printf("Input Eid: ");
	scanf("%d",&pemp->EId);
	printf("Input name: ");
	scanf("%s",pemp->name);
	printf("Input tel: ");
	scanf("%s",pemp->tel);
	printf("Input salary: ");
	scanf("%f",&temp);
	pemp->salary=temp;
	printf("Input online communication method(Q or M): ");
	scanf("%*c%c",&pemp->qqOrMsn);
	if (pemp->qqOrMsn=='Q' || pemp->qqOrMsn=='q') {
		printf("Input QQ number: \n");
		scanf("%ld",&(pemp->on).qq);
		printf("New employee's detail: \n");
		printf("Eid\tname\ttel\t\tsalary\tonline\n");
		printf("%d\t%s\t%s\t%.2f\t%s\n",pemp->EId,pemp->name,
					pemp->tel,pemp->salary,(pemp->on).qq);
	}
	else if (pemp->qqOrMsn=='M' || pemp->qqOrMsn=='m') {
		printf("Input QQ number: \n");
		scanf("%ld",&(pemp->on).msn);
		printf("New employee's detail: \n");
		printf("Eid\tname\ttel\t\tsalary\tonline\n");
		printf("%d\t%s\t%s\t%.2f\t%s\n",pemp->EId,pemp->name,
					pemp->tel,pemp->salary,(pemp->on).msn);
	}else {
		printf("error input\n");
		exit(0);
	}
}