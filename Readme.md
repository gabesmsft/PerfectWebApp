# Azure Web App - HTTP 5xx and alert rule for basic testing

Simple example to test returning an HTTP 500 error. If you set an environment variable named foo with a value of bar, the HomeController Index method returns 1/0 to the view, which throws an exception.

Also includes an alert that triggers when HTTP 5xx errors occur within 5 minutes.

[![Deploy To Azure](https://raw.githubusercontent.com/Azure/azure-quickstart-templates/master/1-CONTRIBUTION-GUIDE/images/deploytoazure.svg?sanitize=true)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Fgabesmsft%2FPerfectWebApp%2Fmaster%2Fdeploy%2Fazuredeploy.json)
