Avalonia Auto
============

A flexible, easy to configure replacement for the standard Grid control. Ported from [WPF AutoGrid](https://github.com/carbonrobot/wpf-autogrid)

Now Available on NuGet! https://www.nuget.org/packages/Avalonia.AutoGrid/

AutoGrid lets you reduce the amount of xaml when using grids for layout by allowing you to define rows and columns as simple properties and alleviating you from having to explicitly specify the row and column a child control belongs to.

Partially based on work at http://rachel53461.wordpress.com/2011/09/17/wpf-grids-rowcolumn-count-properties/

#### Standard WPF Grid

```xml
<Grid>
  <Grid.RowDefinitions>
    <RowDefinition Height="35" />
    <RowDefinition Height="35" />
  </Grid.RowDefinitions>
  <Grid.ColumnDefinitions>
    <ColumnDefinition Width="100" />
    <ColumnDefinition Width="auto" />
  </Grid.ColumnDefinitions>
  
  <Label Grid.Row="0" Grid.Column="0" />
  <TextBox Grid.Row="0" Grid.Column="1" />
  <Label Grid.Row="1" Grid.Column="0" />
  <TextBox Grid.Row="1" Grid.Column="1" />
</Grid>
```

#### AutoGrid (Same output as above)

```xml
<AutoGrid RowCount="2" RowHeight="35" Columns="100,auto">
  <Label />
  <TextBox />
  <Label />
  <TextBox />
</AutoGrid>
```

Notice how in the example above we didn't need to specify the row and column that each element belonged to; AutoGrid automatically figures out what row and column we wanted based on our configuration of the grid. AutoGrid uses a row first or column first arrangement for its auto layout which can changed by setting the Orientation property. 

Don't want AutoGrid to position elements automatically? **OK**

Explicit assignment of columns and rows still works too. This allows you to upgrade more easily. Most of time you can mix both without much trouble, but take care that this is not always the case.

#### Defining a even spaced 6x6 grid with a default margin of 10 for all cells

```xml
<local:AutoGrid ColumnCount="6" ColumnWidth="*" RowHeight="*" RowCount="6" ChildMargin="10" />
```

#### Grid with relative based column widths and fixed row height

```xml
<local:AutoGrid Columns="2*,5*" RowCount="6" RowHeight="25" />
```

#### Orientation="Horizontal" (default)

In this example, labels will fall in the first column, and textboxes will be in the second column

```xml
<AutoGrid RowCount="2" RowHeight="35" Columns="100,auto">
  <Label />     <!-- Col=0, Row=0 -->
  <TextBox />   <!-- Col=1, Row=0 -->
  <Label />     <!-- Col=0, Row=1 -->
  <TextBox />   <!-- Col=1, Row=1 -->
</AutoGrid>
```

#### Orientation="Vertical"

In this example, labels will fall in the first row, and textboxes will be in the second row

```xml
<AutoGrid RowCount="2" RowHeight="35" Columns="100,auto" Orientation="Vertical">
  <Label />     <!-- Col=0, Row=0 -->
  <TextBox />   <!-- Col=0, Row=1 -->
  <Label />     <!-- Col=1, Row=0 -->
  <TextBox />   <!-- Col=1, Row=1 -->
</AutoGrid>
```

#### Support for collapsed children

Collapsed elements will be removed from the flow, hidden elements will still occupy space in the grid

```xml
<AutoGrid RowCount="2" RowHeight="35" Columns="100,auto">
  <Label />                             <!-- Col=0, Row=0 -->
  <TextBox />                           <!-- Col=1, Row=0 -->
  <Label Visibility="Collapsed" />
  <TextBox />                           <!-- Col=0, Row=1 -->
</AutoGrid>
```
