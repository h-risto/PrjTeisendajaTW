Public Class CTeisendaja
    Implements ITeisendaja

    Const KM2MI = 1.6093
    Public Function KilometersToMiles(km As Double) As Double Implements ITeisendaja.KilometersToMiles
        Return km / KM2MI
    End Function

    Public Function MilesToKilometers(mi As Double) As Double Implements ITeisendaja.MilesToKilometers
        Return mi * KM2MI
    End Function



    Public Function KmhToMs(kmh As Double) As Double Implements ITeisendaja.KmhToMs
        Throw New NotImplementedException()
    End Function

    Public Function MsToKmh(ms As Double) As Double Implements ITeisendaja.MsToKmh
        Throw New NotImplementedException()
    End Function
End Class
