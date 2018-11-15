<!-- default file list -->
*Files to look at*:

* [Window1.xaml](./CS/Window1.xaml) (VB: [Window1.xaml](./VB/Window1.xaml))
* [Window1.xaml.cs](./CS/Window1.xaml.cs) (VB: [Window1.xaml](./VB/Window1.xaml))
<!-- default file list end -->
# How to get the currently focused row


<p>The following example demonstrates how to obtain a grid row, which is currently focused.</p><p>Starting with version 2013 vol 1 the <strong>TableView</strong><strong>.</strong><strong>FocusedRow</strong> property is marked as obsolete. The <strong>GridControl.</strong><strong>CurrentItem/GridControl.SelectedItem</strong> property should be used instead.</p><p></p>


<h3>Description</h3>

<p>To do this, it is necessary to create a custom view, derived from the <strong>TableView</strong> class, and introduce the <strong>FocusedRow</strong> dependency property in it. Then this property can be used in XAML to provide two-way binding to the currently focused row.</p><p>Note that we&#39;ve added this property to the TableView class in v2009 vol 3. So, if you upgrade to this version, you won&#39;t need to create a custom view.</p>

<br/>


