Public Class CTeisendaja
    Implements ITeisendaja

    Const KM2MI = 1.6093
    Public Function KilometersToMiles(km As Double) As Double Implements ITeisendaja.KilometersToMiles
        Return km / KM2MI
    End Function

    Public Function MilesToKilometers(mi As Double) As Double Implements ITeisendaja.MilesToKilometers
        Return mi * KM2MI
    End Function

    Public Function CelciusToFahrenheit(c As Double) As Double Implements ITeisendaja.CelciusToFahrenheit
        Return (c * 9 / 5) + 32
    End Function

    Public Function FahrenheitToCelsius(f As Double) As Double Implements ITeisendaja.FahrenheitToCelsius
        Return (f - 32) * 5 / 9
    End Function

    Public Function KmhToMs(kmh As Double) As Double Implements ITeisendaja.KmhToMs
        Throw New NotImplementedException()
    End Function

    Public Function MsToKmh(ms As Double) As Double Implements ITeisendaja.MsToKmh
        Throw New NotImplementedException()
    End Function
End Class
