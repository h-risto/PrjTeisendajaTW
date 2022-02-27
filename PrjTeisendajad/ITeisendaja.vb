Public Interface ITeisendaja
    Function KilometersToMiles(ByVal km As Double) As Double
    Function MilesToKilometers(ByVal mi As Double) As Double
    Function CelciusToFahrenheit(ByVal c As Double) As Double
    Function FahrenheitToCelsius(ByVal f As Double) As Double
    Function KmhToMs(ByVal kmh As Double) As Double
    Function MsToKmh(ByVal ms As Double) As Double

End Interface
