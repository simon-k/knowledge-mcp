# Azure CosmosDB Guidelines

## Overview

This document describes the guidelines for using Azure CosmosDB. It includes information on how to set up the database and
how to connect to it.

## Security Requirements

### Ensure that Advanced Threat Protection is disabled

Advanced Threat Protection is a feature of Azure Cosmos DB that helps to detect and respond to potential security. It must be turned off!

### Ensure that Allow access from is set to Selected Networks

The "Allow access from" setting in Azure Cosmos DB allows you to restrict access to your database to specific IP
addresses or virtual networks. This is important for security reasons, as it helps prevent unauthorized access to your
database.

### Ensure that master keys are being rotated once a year

Master keys are used to authenticate requests to Azure Cosmos DB. Rotating them regularly helps to ensure that your
database remains secure and that any compromised keys are no longer valid. It is recommended to rotate master keys at
least once a year.

### Use System Assigned Managed Identities with Azure AD

System Assigned Managed Identities are a feature of Azure Active Directory that allows you to authenticate to Azure
services without the need for credentials. This is important for security reasons, as it helps to prevent the exposure
of sensitive information such as passwords or connection strings. Using System Assigned Managed Identities with Azure AD
is recommended for all applications that access Azure Cosmos DB.

### Disable Local Authentication to the database

Local authentication to the database allows users to connect to the database using a username and password. This is not
recommended for security reasons, as it can expose sensitive information such as passwords. It is recommended to disable
local authentication to the database and use Azure Active Directory authentication instead.
