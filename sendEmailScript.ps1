$Username = $args[0]
$EmailTo = $args[4]
$EmailFrom = "Team7@CPSC5210"
$Subject = "Latest Regression Test"
$Body = "PFA the latest test results"
$SMTPServer = "smtp.gmail.com"
$SMTPMessage = New-Object System.Net.Mail.MailMessage($EmailFrom, $EmailTo, $Subject, $Body)
$Attachment1 = New-Object System.Net.Mail.Attachment($args[2])
$SMTPMessage.Attachments.Add($Attachment1)
$Attachment2 = New-Object System.Net.Mail.Attachment($args[3])
$SMTPMessage.Attachments.Add($Attachment2)
$SMTPClient = New-Object Net.Mail.SmtpClient($SmtpServer, 587)
$SMTPClient.EnableSsl = $true
$SMTPClient.Credentials = New-Object System.Net.NetworkCredential($Username, $args[1]);
$SMTPClient.Send($SMTPMessage)

Write-Output "Email with build & test logs sent successfully"