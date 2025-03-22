﻿namespace Aplication.Interfaces.Helpers;

public interface IGeolocationService
{
    double CalculateDistance(double lat1, double lon1, double lat2, double lon2);
}