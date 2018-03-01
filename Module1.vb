Module Module1
    Friend Function ImageToByte(ByVal img As Image) As Byte()
        Dim imgStream As New System.IO.MemoryStream()
        img.Save(imgStream, System.Drawing.Imaging.ImageFormat.Png)
        Return imgStream.ToArray
    End Function
End Module
