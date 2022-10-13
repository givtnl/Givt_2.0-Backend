// See https://aka.ms/new-console-template for more information

using HashiCorp.Cdktf;using HashiCorp.Cdktf.Providers.Azurerm.LinuxWebApp;
using HashiCorp.Cdktf.Providers.Azurerm.ResourceGroup;

Console.WriteLine("Hello, World!");

var app = new App();

var stack = new TerraformStack(app, "DevStack");
var group = new ResourceGroup(app, "DevGroup", new ResourceGroupConfig
{
    Name = $"Givt.Backend.Resources.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}",
    Location = "West Europe"
});

new LinuxWebApp(stack, "", new LinuxWebAppConfig
{
    
});

app.Synth();