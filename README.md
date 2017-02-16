# DisableSafeMode
A systemless program to help your Windows prevent entering safemode.<br>
<br>
A common way to prevent users entering safemode (just by google "prevent entering safemode") is modify registry keys in<br>
[HKLM\SYSTEM\CurrentControlSet\Control\SafeBoot\Minimal (or Network)].<br>
So that system can't found the safemode registry keys and can not enter safemode.<br>
<br>
But in this method, maybe broken the permissions of the registry or make any other damage, <br>
or make the system not integrity.<br>
<br>
And in Windows 10, although modified permissions, but the key about safemode is still can't be renamed or deleted.<br>
<br>
So the purpose I write this program is making a method to prevent entering safemode without modify those registry keys.<br>
<br>
This program is a services. It will be run automaticly in safemode and detecting whether in safemode.<br>
If the system in safemode, it will reboot.<br>
<br>
So after install it, when you entering safemode, your computer will reboot automaticly.<br>
<br>
(Make a program run in safemode automaticly is very easy. Just add your Services/Driver in<br> [HKLM\SYSTEM\CurrentControlSet\Control\SafeBoot\Minimal or Network].)<br>
<br>
<a href="https://github.com/liyafe1997/DisableSafeMode/releases">Release Download</a>
