namespace IndieGameZone.Domain.RequestFeatures
{
	public abstract class RequestParameters
	{
		private int maxPageSize = 20;

		private int _pageNumber = 1;
		public int PageNumber
		{
			get => _pageNumber;
			set => _pageNumber = (value < 1) ? 1 : value;
		}

		private int _pageSize = 10;
		public int PageSize
		{
			get => _pageSize;
			set
			{
				if (value < 1)
				{
					_pageSize = 1;
				}
				else
				{
					_pageSize = (value > maxPageSize) ? maxPageSize : value;
				}
			}
		}
	}
}
