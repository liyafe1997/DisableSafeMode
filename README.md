# DisableSafeMode
A systemless program to help your Windows prevent entering safemode.

A common way to prevent users entering safemode (just google "prevent entering safemode") is modify registry keys in
[HKLM\SYSTEM\CurrentControlSet\Control\SafeBoot\Minimal (or Network)],
so that system can't found the safemode registry keys.
But in this method, maybe broken the permissions of the registry or make any other damage, or make the system not integrity.
And in Windows 10, although modified permissions, but the key about safemode is still can't be renamed or deleted.

So the purpose I write this program is making a method to prevent entering safemode without modify those registry keys.
This program is a services. It will be run automaticly in safemode and detecting whether in safemode.
If the system in safemode, it will reboot.
So after install it, when you entering safemode, your computer will reboot automaticly.
(Make a program run in safemode automaticly is very easy. Just add your Services/Driver in HKLM\SYSTEM\CurrentControlSet\Control\SafeBoot\Minimal or Network.)

<a href="https://github.com/liyafe1997/DisableSafeMode/releases">Release Download</a>
