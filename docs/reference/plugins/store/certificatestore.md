---
sidebar: reference
---

# Windows Certificate Store
Default plugin, saves certificates to the Windows Certificate store. Which store is used is based on the following priorities:

- Store configured for the specific renewal
- Global default is configured in [settings.json](/win-acme/reference/settings)
- `WebHosting` store (if it exists, i.e. Windows 2012+ with IIS)
- The machine-level `My` store (better known as Personal)

## Keep existing
The `--keepexisting` switch can be used to prevent the program from deleting older 
versions of the certificate from the store.

## Unattended
`[--store certificatestore] [--certificatestore My] [--keepexisting]`