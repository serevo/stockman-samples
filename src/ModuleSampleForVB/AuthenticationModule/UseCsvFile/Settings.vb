Namespace My
    Partial Friend NotInheritable Class MySettings
        Public Property CsvUserFilePath As String

        Public Property IsUseCsvUserId As Boolean

        Public Property CsvUseFilterType As CsvUseFilterType

        Public Property FrequentlyUsers As Dictionary(Of CsvUserInfo, Integer)
    End Class
End Namespace