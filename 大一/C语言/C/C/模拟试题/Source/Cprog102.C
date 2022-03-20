#define N 6
#define M 9
void fun(int a[],int b[],int c[])
{
 /**/

	int i,j,l,k=0;
	for (i=N-1,j=0;i>=0&&j<M;)
		if (a[i]>b[j])
			c[k++]=a[i--];
		else
			c[k++]=b[j++];
	for (l=i;l>=0;l--)
		c[k++]=a[l];
	for (l=j;l<M;l++)
		c[k++]=b[l];

 /**/
}

main()
 {
   int a[N]={2,5,8,10,18,24},b[M]={96,88,70,36,24,18,11,10,2};
   int c[N+M],n;
   fun(a,b,c);
   printf("The result is: ");
   for(n=0;n<N+M;n++)
    printf("%d ",c[n]);
   getch();
 }

