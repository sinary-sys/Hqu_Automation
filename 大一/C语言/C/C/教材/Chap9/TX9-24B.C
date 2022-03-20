void main(void) {
	int a[100],i,sum=0;
	void *p=a;

	for (i=0;i<100;i++) ((int *)p)[i]=i+1;

	for (i=0;i<100;i++) {
		sum+=*(int *)p;
		p=(int *)p+1;
	}

	printf("sum=%d\n",sum);
}