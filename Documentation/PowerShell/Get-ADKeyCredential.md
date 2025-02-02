---
external help file: DSInternals.PowerShell.dll-Help.xml
Module Name: DSInternals
online version: https://github.com/MichaelGrafnetter/DSInternals/blob/master/Documentation/PowerShell/Get-ADKeyCredential.md
schema: 2.0.0
---

# Get-ADKeyCredential

## SYNOPSIS
Creates an object representing Windows Hello for Business or FIDO credentials from its binary representation or an X.509 certificate.

## SYNTAX

### FromUserCertificate (Default)
```
Get-ADKeyCredential [-Certificate] <X509Certificate2> [-DeviceId] <Guid> -HolderDN <String>
 [-CreationTime <DateTime>] [<CommonParameters>]
```

### FromDNBinary
```
Get-ADKeyCredential [-DNWithBinaryData] <String[]> [<CommonParameters>]
```

### FromBinary
```
Get-ADKeyCredential -BinaryData <Byte[]> -HolderDN <String> [<CommonParameters>]
```

### FromComputerCertificate
```
Get-ADKeyCredential [-Certificate] <X509Certificate2> -HolderDN <String> [-CreationTime <DateTime>]
 [-IsComputerKey] [<CommonParameters>]
```

## DESCRIPTION
{{Fill in the Description}}

## EXAMPLES

### Example 1
```powershell
PS C:\> {{ Add example code here }}
```

{{ Add example description here }}

## PARAMETERS

### -BinaryData
Specifies the credentials in binary/hexadecimal format.

```yaml
Type: Byte[]
Parameter Sets: FromBinary
Aliases: Binary

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Certificate
Specifies a certificate that wraps an NGC key.

```yaml
Type: X509Certificate2
Parameter Sets: FromUserCertificate, FromComputerCertificate
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreationTime
Specifies the time when the key was created. Default value is the current time.

```yaml
Type: DateTime
Parameter Sets: FromUserCertificate, FromComputerCertificate
Aliases: CreatedTime, TimeCreated, TimeGenerated

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceId
Specifies an identifier (typically objectGUID) of the associated computer.

```yaml
Type: Guid
Parameter Sets: FromUserCertificate
Aliases: ComputerId, ComputerGuid

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DNWithBinaryData
Specifies the credentials in the DN-Binary syntax.

```yaml
Type: String[]
Parameter Sets: FromDNBinary
Aliases: DNWithBinary, DistinguishedNameWithBinary

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -HolderDN
Specifies the distinguished name (DN) of the object that these credentials are associated with.

```yaml
Type: String
Parameter Sets: FromUserCertificate, FromBinary, FromComputerCertificate
Aliases: DistinguishedName, DN, ObjectDN

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsComputerKey
Indicates that the resulting key credential must meet the DS-Validated-Write-Computer requirements.

```yaml
Type: SwitchParameter
Parameter Sets: FromComputerCertificate
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.String[]

## OUTPUTS

### DSInternals.Common.Data.KeyCredential

## NOTES

## RELATED LINKS

[Add-ADReplNgcKey](Add-ADReplNgcKey.md)
[Get-ADReplAccount](Get-ADReplAccount.md)
[Get-ADDBAccount](Get-ADDBAccount.md)
