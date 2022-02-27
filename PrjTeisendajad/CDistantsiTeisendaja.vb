Public Class CDistantsiTeisendaja
    Implements IDistantsiTeisendaja

    Const KM2MI = 1.6093
    Public Function KilometersToMiles(km As Double) As Double Implements IDistantsiTeisendaja.KilometersToMiles
        Return km / KM2MI
    End Function

    Public Function MilesToKilometers(mi As Double) As Double Implements IDistantsiTeisendaja.MilesToKilometers
        Return mi * KM2MI
    End Function

End Class
