''' <summary>
''' InputConverter takes in user input and converts to user specified temperature scale.
''' </summary>
Public Class InputConverter

  Private Enum Scale
    Fahrenheit = 0
    Celsius
    Kelvin
  End Enum

  ''' <summary>
  ''' Convert the user specified temperature, from scale, and to scale to the user desired scale with the appropriately converted temperature.
  ''' </summary>
  ''' <param name="iInputDegree">temperature degree as a number</param>
  ''' <param name="iInputScale">scale to convert from</param>
  ''' <param name="iOutputScale">scaled to convert to</param>
  ''' <returns></returns>
  Public Function ConvertUserInput(iInputDegree As Double, iInputScale As Integer, iOutputScale As Integer) As Double
    If iInputScale = iOutputScale Then
      Return iInputDegree
    End If

    Select Case iInputScale
      Case Scale.Fahrenheit
        Select Case iOutputScale
          Case Scale.Celsius
            Return ConvertUnitFromFahrenheitToCelsius(iInputDegree)
          Case Scale.Kelvin
            Return ConvertUnitFromFahrenheitToKelvin(iInputDegree)
        End Select
      Case Scale.Celsius
        Select Case iOutputScale
          Case Scale.Fahrenheit
            Return ConvertUnitFromCelsiusToFahrenheit(iInputDegree)
          Case Scale.Kelvin
            Return ConvertUnitFromCelsiusToKelvin(iInputDegree)
        End Select
      Case Scale.Kelvin
        Select Case iOutputScale
          Case Scale.Fahrenheit
            Return ConvertUnitFromKelvinToFahrenheit(iInputDegree)
          Case Scale.Celsius
            Return ConvertUnitFromKelvinToCelsius(iInputDegree)
        End Select
    End Select

    Return iInputDegree
  End Function

  Private Function ConvertUnitFromFahrenheitToCelsius(dInput As Double) As Double
    Return ((dInput - 32) * 5 / 9)
  End Function

  Private Function ConvertUnitFromFahrenheitToKelvin(dInput As Double) As Double
    Return ((dInput - 32) * 5 / 9 + 273.15)
  End Function

  Private Function ConvertUnitFromCelsiusToFahrenheit(dInput As Double) As Double
    Return ((dInput * 9 / 5) + 32)
  End Function

  Private Function ConvertUnitFromCelsiusToKelvin(dInput As Double) As Double
    Return (dInput + 273.15)
  End Function

  Private Function ConvertUnitFromKelvinToFahrenheit(dInput As Double) As Double
    Return ((dInput - 273.15) * 9 / 5 + 32)
  End Function

  Private Function ConvertUnitFromKelvinToCelsius(dInput As Double) As Double
    Return (dInput - 273.15)
  End Function

End Class
