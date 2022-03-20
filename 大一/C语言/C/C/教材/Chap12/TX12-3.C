#include <stdio.h>
#include <stdlib.h>

struct employee {
	int EId;
	char name[20];
	char tel[12];
	float salary;
}*temp,*p;

void main(void) {
	FILE *fp1,*fp2;
	if ((fp1=fopen("e:\\tc\\example.txt","w+"))==NULL) {
		printf("Open error on writing\n");
		exit(0);
	}
	temp=(struct employee *)malloc(sizeof(struct employee));
	p=(struct employee *)malloc(sizeof(struct employee));

	printf("Input EId: ");
	scanf("%d",&temp->EId);
	printf("Input name: ");
	scanf("%s",temp->name);
	printf("Input tel: ");
	scanf("%s",temp->tel);
	printf("Input salary: ");
	scanf("%f",&temp->salary);

	fwrite(temp,sizeof(struct employee),1,fp1);
	fclose(fp1);

	if ((fp2=fopen("e:\\tc\\example.txt","r+"))==NULL) {
		printf("Open error on reading\n");
		exit(0);
	}
	fread(p,sizeof(struct employee),1,fp2);
	printf("New employee's detail: \n");
	printf("Eid\tname\ttel\t\tsalary\n");
	printf("%d\t%s\t%s\t%.2f\n",p->EId,p->name,p->tel,p->salary);
	fclose(fp2);
}