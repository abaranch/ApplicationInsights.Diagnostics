<Query Kind="Expression">
  <NuGetReference>ApplicationInsights.Diagnostics</NuGetReference>
  <Namespace>ApplicationInsights.Diagnostics</Namespace>
  <Namespace>System.Reactive.Linq</Namespace>
</Query>

DiagnosticObservable
	.Create()
	.Select(i => i.FormattedMessage)