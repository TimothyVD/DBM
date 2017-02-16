Option Explicit
Option Strict


' DBM
' Dynamic Bandwidth Monitor
' Leak detection method implemented in a real-time data historian
'
' Copyright (C) 2014, 2015, 2016, 2017  J.H. Fitié, Vitens N.V.
'
' This file is part of DBM.
'
' DBM is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' DBM is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License
' along with DBM.  If not, see <http://www.gnu.org/licenses/>.


Namespace Vitens.DynamicBandwidthMonitor


  Public Class DBMPointDriver


    ' Description: Returns zero for every request.
    ' Identifier (Point): Object (unused)
    ' Remarks: Template for custom developed drivers.


    Public Point As Object


    Public Sub New(Point As Object)

      Me.Point = Point ' Required, but unused.

    End Sub


    Public Function GetData(StartTimestamp As DateTime, _
      EndTimestamp As DateTime) As Double

      Return 0 ' Return zero for every request.

    End Function


  End Class


End Namespace
