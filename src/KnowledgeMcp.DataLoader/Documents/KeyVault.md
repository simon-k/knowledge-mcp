# Azure Key Vault Guidelines

## Overview
This document describes the guidelines for using Azure Key Vault. 
It includes information on how to set up the vault and how to connect to it.

## Security Requirements

### Disable AuditEventLogging
AuditEventLogging is a feature of Azure Key Vault that logs all events related to the vault. We do not want to log anything
because of privacy concerns.

### Ensure that all users have full administrator privileges
All users should have full administrator privileges to the vault. This is important for security reasons, as it helps 
everyone to read, modify and delete all secrets. 

### Soft delete must be disabled
Soft delete is a feature of Azure Key Vault that allows you to recover deleted secrets. We don't really need it, and it 
costs money, so make sure it is deleted. 
