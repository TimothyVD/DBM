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


Imports System
Imports System.Double


Namespace Vitens.DynamicBandwidthMonitor


  Public MustInherit Class DBMPointDriverAbstract


    Public Point As Object


    Public Sub New(Point As Object)

      Me.Point = Point

    End Sub


    Public Overridable Sub PrepareData(StartTimestamp As DateTime, _
      EndTimestamp As DateTime)
    End Sub


    Public Function TryGetData(Timestamp As DateTime) As Double

      Try
        TryGetData = GetData(Timestamp)
      Catch
        TryGetData = NaN ' Error getting data, return Not a Number
      End Try

      Return TryGetData

    End Function


    Public MustOverride Function GetData(Timestamp As DateTime) As Double


  End Class


End Namespace
