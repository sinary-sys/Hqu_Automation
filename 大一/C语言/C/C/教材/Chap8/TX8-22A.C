static int series_num;
int series(int diff) {
	return series_num+=diff;
}
void series_start(int seed) {
	series_num=seed;
}