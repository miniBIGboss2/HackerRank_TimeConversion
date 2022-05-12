namespace TimeConversionHackerRank
{
    public static class ConvertToMilitary
    {
        public static string GetConverted(string time)
        {
            if (time[^2..] == "AM")
            {
                if (time[..2] == "12")
                    return "00" + time[2..^2];

                return time[..8];
            }

            else if (time[^2..] == "PM")
            {
                if (time[..2] == "12")
                    return time[..8];

                var temp = Convert.ToInt32(time[..2]) + 12;
                return temp + time[2..^2];
            }

            return "Error";
        }
    }
}
