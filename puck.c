#include <stdio.h>
#include <stdlib.h>
#define FLAG 101


typedef struct
{
	int troup_val;
	struct point* next;
	struct point* prev;
} point;

void add_point(point* list, int val)
{
	point *p1, *p2;
	p1 = list;
	p2 = (point*)malloc(sizeof(point));
	p2->troup_val = val;
	p2->next = NULL;
	while(p1->next != NULL)
	{
		p1 = p1->next;
	}
	p1->next = p2;
	p2->prev = p1;
	p1 = NULL;
	p2 = NULL;
	free(p1);
	free(p2);
}

void tail_exchange(point* from_group, point* to_group)
{
	point *p1, *p2;
	p1 = from_group;
	p2 = to_group;
	while(p1->next != NULL)
	{
		p1 = p1->next;
	}
	
	while(p2->next != NULL)
	{
		p2 = p2->next;
	}
	p2->next = p1;
	p1->prev->next = NULL;
	p1->prev = p2;
	p1 = NULL;
	p2 = NULL;
	free(p1);
	free(p2);
}

int sum_strength(point* list)
{
	int sum;
	point* p1;
	p1 = list
	while(p1 != NULL)
	{
		sum = sum + p1->troup_val;
		if(p1->next != NULL)
		{
			p1 = p1->next;
		}
	}
	
	return sum;
}

int num_pep(point* list)
{
	if(list = NULL)
	{
		return -1;
	}
	point* p1 = list;
	int i = 0;
	while(p1 != NULL)
	{
		if(p1->next != NULL)
		{
			p1 = p1->next;
		}
		i++;
	}
	return i;
}

void rearrange(point* list)
{
	point* p1, *p2;
	p1 = list;
	
}


int main()
{
	int n;
	scanf("%d",&n);
	if((n > 12)||(n < 1))
	{
		return 0;
	}
	int *troup;
	troup = (int*)malloc(n*sizeof(int));
	int i;
	for(i = 0; i < n; i++)
	{
		scanf("%d",&troup[i]);
		if((troup[i] > 100)||(troup[i] < 1))
		{
			return 0;
		}
	}
	int sum = 0;
	for( i = 0; i< n; i++)
	{
		sum = sum + troup[i];
	}
	float average = ((float)sum / (float) n);
	point*  group1, *group2, *group3;
	point* flag;
	flag = (point*)malloc(sizeof(point));
	flag->troup_val = FLAG;
	flag->next = NULL;
	flag->prev = NULL;
	group1 = (point*)malloc(sizeof(point));
	group1->prev = NULL;
	group1->next = NULL;
	group1->troup_val = 0;
	group2 = (point*)malloc(sizeof(point));
	group2->next = NULL;
	group2->prev = NULL;
	group2->troup_val = 0;
	group3 = (point*)malloc(sizeof(point));
	group3->next = NULL;
	group3->prev = NULL;
	group3->troup_val = 0;
	for(i = 0; i < n; i++)
	{
		add_point(group1,troup[i]);
	}
	int mun_pep1 = 0, num_pep2 = 0, num_pep3 = 0, 
	float str_dv1 = 0, str_dv2 = 0, str_dv3 = 0;
	while()
}
