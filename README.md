[1]: http://dotnetsolutionsbytomi.blogspot.se/2011/06/creating-awesome-logging-control-with.html
[nuget]: https://nuget.org/packages/NlogViewer/

NlogViewer
==========

NlogViewer is a simple WPF-control to show NLog-logs. It's heavily inspired by [this blog][1].

Forked from [erizet/NlogViewer](https://github.com/erizet/NlogViewer)

## How to use?

Add a namespace to your Window, like this:

        xmlns:nlog ="clr-namespace:NlogViewer;assembly=NlogViewer"

then add the control.

        <nlog:NlogViewer x:Name="logCtrl" /> 

To setup NlogViewer as a target, add the following to your Nlog.config.

```xml
  <extensions>
    <add assembly="NlogViewer" />
  </extensions>
  <targets>
    <target xsi:type="NlogViewer"
            name="ctrl"
            autoScroll="true"
            maxLines="100"
            lastSelect="true" />
  </targets>
  <rules>
    <logger name="*" minlevel="Trace" writeTo="ctrl" />
  </rules>
```

## Configuration Syntax

```xml
<target xsi:type="NlogViewer"
        name="String"
        autoScroll="Boolean"
        maxLines="Integer"
        lastSelect="Boolean" />
```

## Parameters
### General Options
* **name** - Name of the target.
* **autoScroll** - Indicates whether scroll bar will be moved automatically to show most recent log entries. (default true)
* **maxLines** - Maximum number of lines control will store.  
After exceeding the maximum number, first line will be deleted. (default 50)
* **lastSelect** - Automatically select most recent log entries. (dafault true)