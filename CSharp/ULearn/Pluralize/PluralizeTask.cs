namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
            if (count % 10 == 1)
            {
                return "рубль";
            }
            else if (count % 10 <= 4 && count % 10 != 0)
            {
                return "рубля";
            }
            return "рублей";
		}
	}
}
