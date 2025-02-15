﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Airplane<T, T2>
{
    public T Destination { get; set; }
    public T PassangerName { get; set; }
    public T FlightNumber { get; set; }
    public T2 DepartureDate { get; set; }
    public Airplane(T destination, T passangerName, T flightNumber, T2 departureDate)
    {
        Destination = destination;
        PassangerName = passangerName;
        FlightNumber = flightNumber;
        DepartureDate = departureDate;
    }
    public void UpdateDestination(T newDestination)
    {
        Destination = newDestination;
    }
    public void UpdatePassangerName(T newPassangerName)
    {
        PassangerName = newPassangerName;
    }
    public void UpdateFlightNumber(T newFlightNumber)
    {
        FlightNumber = newFlightNumber;
    }
    public void UpdateDepartureDate(T2 newDepartureDate)
    {
        DepartureDate = newDepartureDate;
    }
}